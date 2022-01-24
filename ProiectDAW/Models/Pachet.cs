using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Models
{
    public class Pachet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        public Guid CazareID { get; set; }
        public Guid FacilitateID { get; set; }
        public Cazare Cazare { get; set; }
        public Facilitate Facilitate { get; set; }
    }
}
