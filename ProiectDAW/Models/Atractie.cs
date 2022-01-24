using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProiectMDS.Models
{
    public class Atractie
    {
        [Key]
        // Generates a value when a row is inserted
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        [Required]
        public string Denumire { get; set; }

        [DataType(DataType.Time)]
        [Required]
        public TimeSpan OraDeschidere { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public TimeSpan OraInchidere { get; set; }

        [Required]
        public float Pret { get; set; }

        [Required]
        public string Oras { get; set; }

        [Required]
        [StringLength(200)]
        public string Adresa { get; set; }
        public ICollection<Bilet> Bilet { get; set; }
    }
}
