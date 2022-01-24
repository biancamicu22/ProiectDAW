using BC = BCrypt.Net.BCrypt;
using ProiectDAW.Data;
using ProiectDAW.DTO;
using System.Linq;
using ProiectDAW.Utilities;
using ProiectDAW.Models;
using System;
using System.Collections.Generic;

namespace ProiectDAW.Services
{
    public class UserService : IUserService
    {
        public DatabaseContext dbContext;
        private IJWTUtils IJWTUtils;

        public UserService(DatabaseContext databaseContext,IJWTUtils jWTUtils)
        {
            dbContext = databaseContext;
            IJWTUtils = jWTUtils;  
        }
        public UserResponseDTO Authenticate(UserRequestDTO model)
        {
            var user = dbContext.Utilizatori.FirstOrDefault(x => x.Username == model.UserName);
            if (user == null || !BC.Verify(model.Password, user.Parola))
            {
                return null;
            }

            var jwtToken = IJWTUtils.GenerateJWToken(user);
            return new UserResponseDTO(user, jwtToken);
        }

        public void Create(UserDTO utilizator)
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

            dbContext.Utilizatori.Add(user);
            dbContext.SaveChanges();
        }

        public List<Utilizator> GetAll()
        {
            return dbContext.Utilizatori.ToList();
        }

        public Utilizator GetById(Guid Id)
        {
            return dbContext.Utilizatori.SingleOrDefault(x => x.ID == Id);
        }
    }
}

