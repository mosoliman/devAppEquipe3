using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionStageEquipe3.Areas.Stages.Models
{
    public class RegionAdministrative
    {
        [Key]
        public int RegionAdministrativeId { get; set; }

        [StringLength(200, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Description de la region administrative")]
        public string DescriptionRegionAdministrative { get; set; }

        public ICollection<ResponsableAdmin> ResponsableAdmins { get; set; }
    }
}
