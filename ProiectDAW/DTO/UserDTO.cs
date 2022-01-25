using ProiectDAW.Models;
using System;

namespace ProiectDAW.DTO
{
    public class UserDTO
    {

        public string Username { get; set; }

        public string Nume { get; set; }

        public string Prenume { get; set; }

        public string Email { get; set; }

        public string Telefon { get; set; }

        public string Parola { get; set; }
        public DateTime DataNasterii { get; set; }

        public Role Role { get; set; }  
    }
}
