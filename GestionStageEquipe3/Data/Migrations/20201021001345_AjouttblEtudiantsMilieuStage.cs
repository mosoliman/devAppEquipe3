using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionStageEquipe3.Data.Migrations
{
    public partial class AjouttblEtudiantsMilieuStage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MilieuStage",
                columns: table => new
                {
                    MilieuStageId = table.Column<Guid>(nullable: false),
                    NomEntreprise = table.Column<string>(maxLength: 200, nullable: true),
                    AdresseEntreprise = table.Column<string>(maxLength: 200, nullable: true),
                    VilleEntreprise = table.Column<string>(maxLength: 45, nullable: true),
                    ProvinceEntreprise = table.Column<string>(maxLength: 20, nullable: true),
                    CodepostaleEntreprise = table.Column<string>(maxLength: 7, nullable: true),
                    RegionAdministrativeEntreprise = table.Column<string>(maxLength: 45, nullable: true),
                    ResponsablePolitesseID = table.Column<string>(maxLength: 200, nullable: true),
                    PrenomResponsable = table.Column<string>(maxLength: 200, nullable: true),
                    NomResponsable = table.Column<string>(maxLength: 200, nullable: true),
                    ResponsableTitreID = table.Column<string>(maxLength: 200, nullable: true),
                    AdresseResponsable = table.Column<string>(maxLength: 200, nullable: true),
                    VillResponsable = table.Column<string>(maxLength: 45, nullable: true),
                    ProvinceResponsable = table.Column<string>(maxLength: 20, nullable: true),
                    CodePostalResponsable = table.Column<string>(maxLength: 7, nullable: true),
                    NomMilieuStage = table.Column<string>(maxLength: 200, nullable: true),
                    MilieuStageActif = table.Column<bool>(nullable: false),
                    AttenteTexte = table.Column<string>(maxLength: 2000, nullable: true),
                    NombreMaximumEtudiant = table.Column<int>(nullable: false),
                    NumeroStage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MilieuStage", x => x.MilieuStageId);
                });

            migrationBuilder.CreateTable(
                name: "EtudiantsMilieuStage",
                schema: "dbo",
                columns: table => new
                {
                    MilieuStageEtudiantId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<string>(maxLength: 450, nullable: false),
                    MilieuStageId = table.Column<Guid>(nullable: false),
                    DataCanditature = table.Column<DateTime>(nullable: false),
                    Actif = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EtudiantsMilieuStage", x => x.MilieuStageEtudiantId);
                    table.ForeignKey(
                        name: "FK_EtudiantsMilieuStage_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EtudiantsMilieuStage_MilieuStage_MilieuStageId",
                        column: x => x.MilieuStageId,
                        principalTable: "MilieuStage",
                        principalColumn: "MilieuStageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EtudiantsMilieuStage_Id",
                schema: "dbo",
                table: "EtudiantsMilieuStage",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_EtudiantsMilieuStage_MilieuStageId",
                schema: "dbo",
                table: "EtudiantsMilieuStage",
                column: "MilieuStageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EtudiantsMilieuStage",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "MilieuStage");
        }
    }
}
