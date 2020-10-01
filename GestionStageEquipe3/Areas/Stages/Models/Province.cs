using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionStageEquipe3.Areas.Stages.Models
{
    [Table("Province", Schema = "dbo")]
    public class Province
    {
        [Key]
        public int PolitesseId { get; set; }

        [StringLength(200, ErrorMessage = "Vous devez entrer moins de caractères")]
        [Display(Description = "Description de la province")]
        public string DescriptionProvince { get; set; }

        public ICollection<ResponsableAdmin> ResponsableAdmins { get; set; }
    }
}
