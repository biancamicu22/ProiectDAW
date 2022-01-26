using System;

namespace ProiectDAW.DTO
{
    public class VacantaUpdateDTO
    {
        public Guid ID { get; set; }
        public string Denumire { get; set; }

        public DateTime DataInceput { get; set; }

        public DateTime DataSfarsit { get; set; }

        public string Oras { get; set; }

        public string Tara { get; set; }

    }
}
