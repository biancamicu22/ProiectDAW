using System;

namespace ProiectDAW.DTO
{
    public class RezervareCazareDTO
    {
        public Guid VacantaID { get; set; }
        public Guid CazareID { get; set; }
        public DateTime DataSosire { get; set; }
        public DateTime DataPlecare { get; set; }
        public string CodRezervare { get; set; }
    }
}
