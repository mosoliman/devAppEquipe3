using GestionStageEquipe3.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionStageEquipe3.Areas.Stages.Models
{
    [Table("EtudiantsMilieuStage", Schema = "dbo")]
    public class EtudiantsMilieuStage
    {

        [Key]
        public int MilieuStageEtudiantId { get; set; }

        [StringLength(450)]
        [Required]
        public string Id { get; set; }

        public Guid MilieuStageId { get; set; }

        public DateTime DataCanditature { get; set; }

        [Required(ErrorMessage = "Veuillez indiquer un statut")]
        [Display(Name = "Statut de la candidature")]
        public bool Actif { get; set; }

        [ForeignKey("MilieuStageId")]
        public MilieuStage MilieuStage { get; set; }

        [ForeignKey("Id")]
        public ApplicationUser ApplicationUser { get; set; }
    }
}
