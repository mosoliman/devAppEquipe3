using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionStageEquipe3.Areas.Stages.Models
{
    [Table("Politesse", Schema = "dbo")]
    public class Politesse
    {
        [Key]
        public int PolitesseId { get; set; }

        [StringLength(200, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Description de la politesse")]
        public string DescriptionPolitesse { get; set; }

        public ICollection<MilieuStage> MilieuStages {get; set; }

    }
}
