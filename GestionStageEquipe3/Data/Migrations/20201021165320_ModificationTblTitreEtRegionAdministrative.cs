using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionStageEquipe3.Data.Migrations
{
    public partial class ModificationTblTitreEtRegionAdministrative : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescriptionRegionAdministrative",
                schema: "dbo",
                table: "Titre");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionTitre",
                schema: "dbo",
                table: "Titre",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RegionAdministrativeId",
                table: "ResponsableAdmin",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "RegionAdministratives",
                columns: table => new
                {
                    RegionAdministrativeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescriptionRegionAdministrative = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegionAdministratives", x => x.RegionAdministrativeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ResponsableAdmin_RegionAdministrativeId",
                table: "ResponsableAdmin",
                column: "RegionAdministrativeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResponsableAdmin_RegionAdministratives_RegionAdministrativeId",
                table: "ResponsableAdmin",
                column: "RegionAdministrativeId",
                principalTable: "RegionAdministratives",
                principalColumn: "RegionAdministrativeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResponsableAdmin_RegionAdministratives_RegionAdministrativeId",
                table: "ResponsableAdmin");

            migrationBuilder.DropTable(
                name: "RegionAdministratives");

            migrationBuilder.DropIndex(
                name: "IX_ResponsableAdmin_RegionAdministrativeId",
                table: "ResponsableAdmin");

            migrationBuilder.DropColumn(
                name: "DescriptionTitre",
                schema: "dbo",
                table: "Titre");

            migrationBuilder.DropColumn(
                name: "RegionAdministrativeId",
                table: "ResponsableAdmin");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionRegionAdministrative",
                schema: "dbo",
                table: "Titre",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);
        }
    }
}
