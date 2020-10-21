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
        // ENTREPRISE
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid MilieuStageId { get; set; }

        [StringLength(200, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Nom de l'entreprise")]
        public string NomEntreprise { get; set; }


        [StringLength(200, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "l'adresse de l'entreprise")]
        public string AdresseEntreprise { get; set; }

        [StringLength(45, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Ville de l'entreprise")]
        public string VilleEntreprise { get; set; }


        /*******************************Foreign keys****************************************/
        [StringLength(20, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Province du de l'entreprise")]
        public string ProvinceEntreprise { get; set; }
        /**********************************************************************************/

        [StringLength(7, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Code postal de l'entreprise")]
        public string CodepostaleEntreprise { get; set; }

        [StringLength(45, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Région administrative de l'entreprise")]
        public string RegionAdministrativeEntreprise { get; set; }


        // RESPONSABLE ADMINISTRATIF
        /*******************************Foreign keys****************************************/
        [StringLength(200, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Politesse du responsable administratif")]
        public string ResponsablePolitesseID { get; set; }
        /**********************************************************************************/

        [StringLength(200, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Prénom du responsable administratif")]
        public string PrenomResponsable { get; set; }

        [StringLength(200, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Nom du responsable administratif")]
        public string NomResponsable { get; set; }

        /*******************************Foreign keys****************************************/
        [StringLength(200, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Titre du responsable administratif")]
        public string ResponsableTitreID { get; set; }
        /**********************************************************************************/


        [StringLength(200, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "l'adresse du responsable administratif")]
        public string AdresseResponsable { get; set; }

        [StringLength(45, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Ville du responsable administratif")]
        public string VilleResponsable { get; set; }

        /*******************************Foreign keys****************************************/
        [StringLength(20, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Province du responsable administratif")]
        public string ProvinceResponsable { get; set; }
        /**********************************************************************************/

        [StringLength(7, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Code postal du responsable administratif")]
        public string CodePostalResponsable { get; set; }

        // MILIEU DE STAGE
        [StringLength(200, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Nom du milieu de stage")]
        public string NomMilieuStage { get; set; }

        public bool MilieuStageActif { get; set; }

        [StringLength(2000, ErrorMessage = " ")]
        public string AttenteTexte { get; set; }

        public int NombreMaximumEtudiant { get; set; }

        public string NumeroStage { get; set; }





        public ICollection<EtudiantsMilieuStage> EtudiantsMilieuStage { get; set; }


    }
}
