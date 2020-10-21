using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionStageEquipe3.Areas.Stages.Models
{
    [Table("Titre", Schema = "dbo")]
    public class Titre
    {
        [Key]
        public int TitreId { get; set; }

        [StringLength(200, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Description du titre")]
        public string DescriptionTitre { get; set; }

        public ICollection<MilieuStage> MilieuStages { get; set; }


    }
}
