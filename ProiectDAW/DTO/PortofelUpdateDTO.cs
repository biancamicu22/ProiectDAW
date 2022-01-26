using System;

namespace ProiectDAW.DTO
{
    public class PortofelUpdateDTO
    {
        public Guid ID { get; set; }
        public float Suma { get; set; }
        public DateTime? DateModified { get; set; }
        public Guid UtilizatorID { get; set; }
    }
}
