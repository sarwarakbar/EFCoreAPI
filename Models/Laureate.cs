using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICore.Models
{
    public class Laureate
    {
        [Column("id")]
        [Required]
        public int id { get; set; }

        [Column("firstname")]
        [Required]
        [StringLength(50)]
        public string firstname { get; set; }

        [Column("surname")]
        [Required]
        [StringLength(50)]
        public string surname { get; set; }

        [Column("motivation")]
        [Required]
        [StringLength(500)]
        public string motivation { get; set; }

        [Column("share")]
        [Required]
        public int share { get; set; }

        [ForeignKey("prizeID")]
        public virtual Prize Prize { get; set; }
    }
}
