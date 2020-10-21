using GestionStageEquipe3.Areas.Stages.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionStageEquipe3.Data
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<EtudiantsMilieuStage> EtudiantsMilieuStage { get; set; }
    }
}
