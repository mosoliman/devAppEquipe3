using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionStageEquipe3.Data.Migrations
{
    public partial class MilieuStage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ResponsableAdmin",
                columns: table => new
                {
                    ResponsableAdminId = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    Prenom = table.Column<string>(maxLength: 200, nullable: true),
                    Nom = table.Column<string>(maxLength: 200, nullable: true),
                    PolitesseID = table.Column<string>(maxLength: 200, nullable: true),
                    TitreID = table.Column<string>(maxLength: 200, nullable: true),
                    Courriel = table.Column<string>(maxLength: 200, nullable: true),
                    Telephone = table.Column<string>(maxLength: 17, nullable: true),
                    Poste = table.Column<int>(maxLength: 4, nullable: false),
                    Cellulaire = table.Column<string>(maxLength: 17, nullable: true),
                    Telecopieur = table.Column<string>(maxLength: 17, nullable: true),
                    Adresse = table.Column<string>(maxLength: 200, nullable: true),
                    Ville = table.Column<string>(maxLength: 45, nullable: true),
                    Province = table.Column<string>(maxLength: 20, nullable: true),
                    CodePostal = table.Column<string>(maxLength: 7, nullable: true),
                    Actif = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResponsableAdmin", x => x.ResponsableAdminId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResponsableAdmin");
        }
    }
}
