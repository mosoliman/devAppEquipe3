﻿using System;
using System.Collections.Generic;
using System.Text;
using GestionStageEquipe3.Areas.Stages.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GestionStageEquipe3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employeur>().Property(e => e.EmployeurId).HasDefaultValue("newid()");
        }

    }
}
