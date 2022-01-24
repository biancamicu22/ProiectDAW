using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Models
{
    public class Bilet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        public Guid VacantaID { get; set; }
        public Guid AtractieID { get; set; }
        public string CodBilet { get; set; }
        public DateTime DataVizita { get; set; }
        public Vacanta Vacanta { get; set; }
        public Atractie Atractie { get; set; }
    }
}
