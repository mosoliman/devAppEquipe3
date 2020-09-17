﻿using System;
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
        [Display(Description = "Nom de l'entreprise")]
        public string NomEmployeur { get; set; }

        [Required(ErrorMessage = "Veuillez indiquer un statut")]
        [Display(Description = "Statut de l'employer")]
        public bool Actif { get; set; }
    }
}
