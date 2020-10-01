using System;
using System.Collections.Generic;
using System.Text;
using GestionStageEquipe3.Areas.Stages.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GestionStageEquipe3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<ResponsableAdmin> ResponsableAdmin { get; set; }

        public DbSet<Politesse> Politesse { get; set; }

        public DbSet<Titre> Titre { get; set; }

        public DbSet<Province> Province { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ResponsableAdmin>().Property(e => e.ResponsableAdminId).HasDefaultValueSql("newid()");
        }

    }
}
