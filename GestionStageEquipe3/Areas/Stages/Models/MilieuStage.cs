using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionStageEquipe3.Areas.Stages.Models
{
    public class MilieuStage
    {
        // Milieu Stage
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid MilieuStageId { get; set; }

        [StringLength(200, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Numéro")]
        public string NumeroMilieuStage { get; set; }

        [StringLength(200, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Nom du milieu de stage")]
        public string NomMilieuStage { get; set; }

        [StringLength(200, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Nom de l'entreprise")]
        public string NomEntreprise { get; set; }

        [StringLength(200, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "l'adresse de l'entreprise")]
        public string AdresseEntreprise { get; set; }

        [StringLength(45, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Ville de l'entreprise")]
        public string VilleEntreprise { get; set; }


        /*******************************Foreign keys Province****************************************/
        public int ProvinceEntrepriseId { get; set; }

        public Province Province { get; set; }
        /*******************************Foreign keys Region Administrative****************************************/
        public int RegionAdministrativeEntrepriseId { get; set; }

        public RegionAdministrative RegionAdministrative { get; set; }
        /**********************************************************************************/

        [StringLength(7, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Code postal de l'entreprise")]
        public string CodepostaleEntreprise { get; set; }

        public bool Actif { get; set; }

        public int NombreMaximumEtudiant { get; set; }







        // RESPONSABLE ADMINISTRATIF
        /*******************************Foreign keys Politesse****************************************/
        public int PolitesseResponsableId { get; set; }

        public Politesse Politesse { get; set; }
        /**********************************************************************************/

        [StringLength(200, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Prénom du responsable administratif")]
        public string PrenomResponsable { get; set; }

        [StringLength(200, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Nom du responsable administratif")]
        public string NomResponsable { get; set; }

        /*******************************Foreign keys Titre****************************************/
        public int TitreResponsableId { get; set; }

        public Titre Titre { get; set; }
        /**********************************************************************************/

        [StringLength(200, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Courriel du responsable administratif")]
        public string CourrielResponsable { get; set; }

        [StringLength(17, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Numéro de téléphone du responsable administratif")]
        public string TelephoneResponsable { get; set; }

        [StringLength(4, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Numéro de Poste du responsable administratif")]
        public string PosteResponsable { get; set; }

        [StringLength(17, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Numéro cellulaire du responsable administratif")]
        public string CellulaireResponsable { get; set; }

        [StringLength(17, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Numéro du télécopieur du responsable administratif")]
        public string TelecopieurResponsable { get; set; }

        [StringLength(200, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "l'adresse du responsable administratif")]
        public string AdresseResponsable { get; set; }

        [StringLength(45, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Ville du responsable administratif")]
        public string VilleResponsable { get; set; }

        [StringLength(7, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Code postal du responsable administratif")]
        public string CodePostalResponsable { get; set; }

        /*******************************Foreign keys Province****************************************/
        //public int ProvinceResponsableId { get; set; }

       // public Province ProvinceResponsable { get; set; }
        /*******************************Foreign keys Region Administrative****************************************/


        public ICollection<EtudiantsMilieuStage> EtudiantsMilieuStage { get; set; }


    }
}
