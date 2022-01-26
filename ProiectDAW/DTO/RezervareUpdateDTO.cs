using System;

namespace ProiectDAW.DTO
{
    public class RezervareUpdateDTO
    {
        public Guid ID { get; set; }
        public Guid UtilizatorID { get; set; }

        public Guid VacantaID { get; set; }

        public DateTime DataRezervare { get; set; }

        public string Review { get; set; }

        public int Rating { get; set; }
    }
}
