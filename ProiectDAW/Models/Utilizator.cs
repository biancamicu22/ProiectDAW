using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ProiectDAW.Models;

namespace ProiectDAW.Models
{
    public class Utilizator
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        [Required]
        public string Username { get; set; }
        
        [Required]
        public string Nume { get; set; }
        
        [Required]
        public string Prenume { get; set; }
        
        [Required]
        public string Email { get; set; }

        [Required]
        [StringLength(10)]
        public string Telefon { get; set; }
        
        [Required]
        public string Parola { get; set; }
        [Column(TypeName="Date")]
        public DateTime DataNasterii { get; set; }
        public ICollection<Rezervare> Rezervare { get; set; }
        public ICollection<Fotografie> Fotografie { get; set; }
        public Portofel Portofel {  get; set; }

        public Role Role { get; set; }
    }
}
