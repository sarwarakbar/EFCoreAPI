using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICore.Models
{
    public class Prize
    {
        [Column("prizeId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int prizeID { get; set; }


        [Column("year")]
        [Required]
        [StringLength(50)]
        public string year { get; set; }

        [Column("category")]
        [Required]
        [StringLength(50)]
        public string category { get; set; }

        [Column("laureates")]
        [Required]
        public Laureate[] laureates { get; set; }

        [Column("overallMotivation")]
        [Required]
        [StringLength(500)]
        public string overallMotivation { get; set; }
    }
}
