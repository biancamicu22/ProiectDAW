using System;

namespace ProiectDAW.DTO
{
    public class BiletDTO
    {
        public Guid VacantaID { get; set; }
        public Guid AtractieID { get; set; }
        public string CodBilet { get; set; }
        public DateTime DataVizita { get; set; }
    }
}
