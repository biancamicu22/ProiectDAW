using BC = BCrypt.Net.BCrypt;
using ProiectDAW.Data;
using ProiectDAW.DTO;
using System.Linq;
using ProiectDAW.Utilities;
using ProiectDAW.Models;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Options;

namespace ProiectDAW.Services
{
    public class UserService : IUserService
    {
        public DatabaseContext _dbContext;
        private IJWTUtils _IJWTUtils;
        private readonly AppSettings _appSettings;

        public UserService(DatabaseContext databaseContext,IJWTUtils jWTUtils, IOptions<AppSettings> appSettings)
        {
            _dbContext = databaseContext;
            _IJWTUtils = jWTUtils;
            _appSettings = appSettings.Value;
        }
        public UserResponseDTO Authenticate(UserRequestDTO model)
        {
            var user = _dbContext.Utilizatori.FirstOrDefault(x => x.Username == model.UserName);
            if (user == null || !BC.Verify(model.Password, user.Parola))
            {
                throw new ApplicationException("Username or password is incorrect");
            }

            var jwtToken = _IJWTUtils.GenerateJWToken(user);
            return new UserResponseDTO(user, jwtToken);
        }

        public UserResponseDTO Create(UserDTO utilizator)
        {
            Utilizator user = new Utilizator {
                Username = utilizator.Username,
                Email = utilizator.Email,
                DataNasterii = utilizator.DataNasterii,
                Role = utilizator.Role,
                Nume = utilizator.Nume,
                Prenume = utilizator.Prenume,
                Parola = BC.HashPassword(utilizator.Parola) ,
                Telefon = utilizator.Telefon,
                };

            _dbContext.Utilizatori.Add(user);
            _dbContext.SaveChanges();

   
            var jwtToken = _IJWTUtils.GenerateJWToken(user);
            return new UserResponseDTO(user, jwtToken);
        }

        public List<Utilizator> GetAll()
        {
            return _dbContext.Utilizatori.ToList();
        }

        public Utilizator GetById(Guid Id)
        {
            return _dbContext.Utilizatori.SingleOrDefault(x => x.ID == Id);
        }
    }
}

