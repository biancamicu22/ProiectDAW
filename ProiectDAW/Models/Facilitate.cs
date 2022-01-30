using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectDAW.Models
{
    public class Facilitate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FacilitateId { get; set; }

        [Required]
        public string Denumire { get; set; }
        public ICollection<Pachet> Pachet { get; set; }
    }
}
