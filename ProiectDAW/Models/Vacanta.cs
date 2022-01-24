using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProiectDAW.Models
{
    public class Vacanta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        [Required]
        public string Denumire { get; set; }

        [Required]
        [Column(TypeName = "Date")]
        public DateTime DataInceput { get; set; }

        [Required]
        [Column(TypeName = "Date")]
        public DateTime DataSfarsit { get; set; }

        [Required]
        public string Oras { get; set; }

        public string Tara { get; set; }

        public ICollection<Rezervare> Rezervare { get; set; }

        public ICollection<Bilet> Bilet { get; set; }

        public ICollection<RezervareCazare> RezervareCazare { get; set; }
    }
}