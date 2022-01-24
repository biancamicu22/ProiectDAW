using ProiectDAW.Models;
using System;

namespace ProiectDAW.Utilities
{
    public interface IJWTUtils
    {
        public string GenerateJWToken(Utilizator utilizator);
        public Guid ValidateJWToken(string token);
    }
}
