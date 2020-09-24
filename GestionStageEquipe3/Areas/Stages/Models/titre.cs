using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionStageEquipe3.Areas.Stages.Models
{
    public class Politesse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid PolitesseId { get; set; }

        [StringLength(200, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Description de la Politesse")]
        public string DescriptionPolitesse { get; set; }

    }
}
