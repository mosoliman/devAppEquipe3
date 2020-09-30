using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionStageEquipe3.Areas.Stages.Models
{
    public class ResponsableAdmin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ResponsableAdminId { get; set; }

        [StringLength(200, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Prénom du responsable administratif")]
        public string Prenom { get; set; }

        [StringLength(200, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Nom du responsable administratif")]
        public string Nom { get; set; }

        /*******************************Foreign keys****************************************/
        [StringLength(200, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Politesse du responsable administratif")]
        public string PolitesseID { get; set; }
        /**********************************************************************************/

        /*******************************Foreign keys****************************************/
        [StringLength(200, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Titre du responsable administratif")]
        public string TitreID { get; set; }
        /**********************************************************************************/


        [StringLength(200, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Courriel du responsable administratif")]
        public string Courriel { get; set; }

        /* trouver comment mettre 10 min */
        [StringLength(17, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Numéro de téléphone du responsable administratif")]
        public string Telephone { get; set; }


        [StringLength(4, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Numéro de Poste du responsable administratif")]
        public int Poste { get; set; }

        /* trouver comment mettre 10 min */
        [StringLength(17, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Numéro cellulaire du responsable administratif")]
        public string Cellulaire { get; set; }

        /* trouver comment mettre 10 min */
        [StringLength(17, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Numéro du télécopieur du responsable administratif")]
        public string Telecopieur { get; set; }

        [StringLength(200, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "l'adresse du responsable administratif")]
        public string Adresse { get; set; }

        [StringLength(45, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Ville du responsable administratif")]
        public string Ville { get; set; }

        /*******************************Foreign keys****************************************/
        [StringLength(20, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Province du responsable administratif")]
        public string Province { get; set; }
        /**********************************************************************************/

        [StringLength(7, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Code postal du responsable administratif")]
        public string CodePostal { get; set; }

        public bool Actif { get; set; }

        

        

        
    }
}
