using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace ProiectDAW.Models
{
    public class Cazare
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Nume { get; set; }

        [Required,StringLength(30)]
        public string TipCazare { get; set; }

        [Required]
        public float Pret { get; set; }

        [Required]
        public string Oras { get; set; }

        [Required]
        public string Adresa { get; set; }

        public ICollection<RezervareCazare> RezervareCazare { get; set; }
        public ICollection<Pachet> Pachet { get; set; }
    }
}
