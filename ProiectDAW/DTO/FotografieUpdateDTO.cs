using System;

namespace ProiectDAW.DTO
{
    public class FotografieUpdateDTO
    {
        public Guid ID { get; set; }
        public string Titlu { get; set; }
        public DateTime Data { get; set; }
        public Guid UtilizatorID { get; set; }
    }
}
