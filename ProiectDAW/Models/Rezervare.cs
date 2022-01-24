using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProiectMDS.Models
{
    public class Rezervare
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        public Guid UtilizatorID { get; set; }

        public Guid VacantaID { get; set; }

        [Column(TypeName = "Date")]
        public DateTime DataRezervare { get; set; }

        public string Review { get; set; }

        public int Rating { get; set; }

        public Utilizator Utilizator { get; set; }
        public Vacanta Vacanta { get; set; }
    }
}
