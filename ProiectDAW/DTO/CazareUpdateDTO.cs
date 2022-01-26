using System;

namespace ProiectDAW.DTO
{
    public class CazareUpdateDTO
    {
        public Guid ID { get; set; }
        public string Nume { get; set; }

        public string TipCazare { get; set; }

        public float Pret { get; set; }

        public string Oras { get; set; }

        public string Adresa { get; set; }
    }
}
