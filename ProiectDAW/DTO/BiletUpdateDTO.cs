using System;

namespace ProiectDAW.DTO
{
    public class BiletUpdateDTO
    {
        public Guid ID { get; set; }
        public Guid VacantaID { get; set; }
        public Guid AtractieID { get; set; }
        public string CodBilet { get; set; }
        public DateTime DataVizita { get; set; }
    }
}
