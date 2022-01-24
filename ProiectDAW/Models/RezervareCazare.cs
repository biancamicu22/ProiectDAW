using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProiectMDS.Models
{
    public class RezervareCazare
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public  Guid ID { get; set; }
        public Guid VacantaID { get; set; }
        public Guid CazareID { get; set; }
        [Column(TypeName = "Date")]
        public DateTime DataSosire { get; set; }
        [Column(TypeName = "Date")]
        public DateTime DataPlecare { get; set; }
        public string CodRezervare { get; set; }
        public Vacanta Vacanta { get; set; }
        public Cazare Cazare { get; set; }
    }
}
