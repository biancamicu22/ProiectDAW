using System;
using ProiectDAW.Models;

namespace ProiectDAW.DTO
{
    public class UserResponseDTO
    {

        public Guid ID { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        public string Token { get; set; }

        public UserResponseDTO(Utilizator user, string token)
        {
            ID = user.ID;
            Username = user.Username;
            FirstName = user.Nume;
            LastName = user.Prenume;
            Role = user.Role;
            Token = token;
        }
    }
}
