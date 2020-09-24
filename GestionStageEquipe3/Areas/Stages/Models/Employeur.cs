using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionStageEquipe3.Areas.Stages.Models
{
    public class Employeur
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid EmployeurId { get; set; }

        [StringLength(200, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Prénom de l'employeur")]
        public string PrénomEmployeur { get; set; }

        [StringLength(200, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Nom de l'employeur")]
        public string NomEmployeur { get; set; }

        [StringLength(200, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Courriel de l'employeur")]
        public string CourrielEmployeur { get; set; }

        [StringLength(200, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "l'adresse de l'employeur")]
        public string AdresseEmployeur { get; set; }

        [StringLength(6, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Code postal de l'employeur")]
        public string CodePostalEmployeur { get; set; }

        [StringLength(10, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Numéro de téléphone de l'employeur")]
        public int TelephoneEmployeur { get; set; }

        [StringLength(10, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Numéro de téléphone de l'employeur")]
        public int TelephoneEmployeur { get; set; }

        [StringLength(10, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Numéro de Poste de l'employeur")]
        public int PosteEmployeur { get; set; }

        [StringLength(10, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Numéro cellulaire de l'employeur")]
        public int CellulaireEmployeur { get; set; }

        [StringLength(10, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Numéro du télécopieur de l'employeur")]
        public int TelecopieurEmployeur { get; set; }

        [StringLength(200, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Courriel de l'employeur")]
        public string AdresseEmployeur { get; set; }


    }
}
