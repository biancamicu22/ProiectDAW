using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectDAW.Models
{
    public class Fotografie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        public string Titlu { get; set; }
        public DateTime Data { get; set; }
        public Guid UtilizatorID { get; set; }
        public Utilizator Utilizator { get; set; }
    }
}
