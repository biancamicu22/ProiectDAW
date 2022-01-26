using System;

namespace ProiectDAW.DTO
{
    public class AtractieUpdateDTO
    {
        public Guid ID { get; set; }
        public string Denumire { get; set; }

        public TimeSpan OraDeschidere { get; set; }

        public TimeSpan OraInchidere { get; set; }

        public float Pret { get; set; }

        public string Oras { get; set; }

        public string Adresa { get; set; }
    }
}
