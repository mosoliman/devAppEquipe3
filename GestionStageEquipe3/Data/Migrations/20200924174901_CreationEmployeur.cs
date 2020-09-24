using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionStageEquipe3.Data.Migrations
{
    public partial class CreationEmployeur : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employeur",
                columns: table => new
                {
                    EmployeurId = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    PrénomEmployeur = table.Column<string>(maxLength: 200, nullable: true),
                    NomEmployeur = table.Column<string>(maxLength: 200, nullable: true),
                    CourrielEmployeur = table.Column<string>(maxLength: 200, nullable: true),
                    AdresseEmployeur = table.Column<string>(maxLength: 200, nullable: true),
                    CodePostalEmployeur = table.Column<string>(maxLength: 6, nullable: true),
                    TelephoneEmployeur = table.Column<int>(maxLength: 10, nullable: false),
                    PosteEmployeur = table.Column<int>(maxLength: 10, nullable: false),
                    CellulaireEmployeur = table.Column<int>(maxLength: 10, nullable: false),
                    TelecopieurEmployeur = table.Column<int>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employeur", x => x.EmployeurId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employeur");
        }
    }
}
