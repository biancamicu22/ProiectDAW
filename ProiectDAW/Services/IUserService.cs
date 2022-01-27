using ProiectDAW.DTO;
using ProiectDAW.Models;
using System;
using System.Collections.Generic;

namespace ProiectDAW.Services
{
    public interface IUserService
    {
        //Auth
        UserResponseDTO Authenticate(UserRequestDTO model);
        UserResponseDTO Create(UserDTO utilizator);
        List<Utilizator> GetAll();
        Utilizator GetById(Guid Id);
    }
}
