using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionStageEquipe3.Data.Migrations
{
    public partial class modificationTblMilieustage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResponsableAdmin_Province_ProvinceId",
                table: "ResponsableAdmin");

            migrationBuilder.DropForeignKey(
                name: "FK_ResponsableAdmin_RegionAdministratives_RegionAdministrativeId",
                table: "ResponsableAdmin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Province",
                schema: "dbo",
                table: "Province");

            migrationBuilder.DropIndex(
                name: "IX_ResponsableAdmin_RegionAdministrativeId",
                table: "ResponsableAdmin");

            migrationBuilder.DropColumn(
                name: "PolitesseId",
                schema: "dbo",
                table: "Province");

            migrationBuilder.DropColumn(
                name: "RegionAdministrativeId",
                table: "ResponsableAdmin");

            migrationBuilder.DropColumn(
                name: "AttenteTexte",
                table: "MilieuStage");

            migrationBuilder.DropColumn(
                name: "MilieuStageActif",
                table: "MilieuStage");

            migrationBuilder.DropColumn(
                name: "NumeroStage",
                table: "MilieuStage");

            migrationBuilder.DropColumn(
                name: "ProvinceEntreprise",
                table: "MilieuStage");

            migrationBuilder.DropColumn(
                name: "ProvinceResponsable",
                table: "MilieuStage");

            migrationBuilder.DropColumn(
                name: "RegionAdministrativeEntreprise",
                table: "MilieuStage");

            migrationBuilder.DropColumn(
                name: "ResponsablePolitesseID",
                table: "MilieuStage");

            migrationBuilder.DropColumn(
                name: "ResponsableTitreID",
                table: "MilieuStage");

            migrationBuilder.DropColumn(
                name: "VillResponsable",
                table: "MilieuStage");

            migrationBuilder.AddColumn<int>(
                name: "ProvinceId",
                schema: "dbo",
                table: "Province",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<bool>(
                name: "Actif",
                table: "MilieuStage",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "CellulaireResponsable",
                table: "MilieuStage",
                maxLength: 17,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CourrielResponsable",
                table: "MilieuStage",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumeroMilieuStage",
                table: "MilieuStage",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PolitesseId",
                table: "MilieuStage",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PolitesseResponsableId",
                table: "MilieuStage",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PosteResponsable",
                table: "MilieuStage",
                maxLength: 4,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProvinceEntrepriseId",
                table: "MilieuStage",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProvinceId",
                table: "MilieuStage",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RegionAdministrativeEntrepriseId",
                table: "MilieuStage",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RegionAdministrativeId",
                table: "MilieuStage",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TelecopieurResponsable",
                table: "MilieuStage",
                maxLength: 17,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TelephoneResponsable",
                table: "MilieuStage",
                maxLength: 17,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TitreId",
                table: "MilieuStage",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TitreResponsableId",
                table: "MilieuStage",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "VilleResponsable",
                table: "MilieuStage",
                maxLength: 45,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Province",
                schema: "dbo",
                table: "Province",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_MilieuStage_PolitesseId",
                table: "MilieuStage",
                column: "PolitesseId");

            migrationBuilder.CreateIndex(
                name: "IX_MilieuStage_ProvinceId",
                table: "MilieuStage",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_MilieuStage_RegionAdministrativeId",
                table: "MilieuStage",
                column: "RegionAdministrativeId");

            migrationBuilder.CreateIndex(
                name: "IX_MilieuStage_TitreId",
                table: "MilieuStage",
                column: "TitreId");

            migrationBuilder.AddForeignKey(
                name: "FK_MilieuStage_Politesse_PolitesseId",
                table: "MilieuStage",
                column: "PolitesseId",
                principalSchema: "dbo",
                principalTable: "Politesse",
                principalColumn: "PolitesseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MilieuStage_Province_ProvinceId",
                table: "MilieuStage",
                column: "ProvinceId",
                principalSchema: "dbo",
                principalTable: "Province",
                principalColumn: "ProvinceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MilieuStage_RegionAdministratives_RegionAdministrativeId",
                table: "MilieuStage",
                column: "RegionAdministrativeId",
                principalTable: "RegionAdministratives",
                principalColumn: "RegionAdministrativeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MilieuStage_Titre_TitreId",
                table: "MilieuStage",
                column: "TitreId",
                principalSchema: "dbo",
                principalTable: "Titre",
                principalColumn: "TitreId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ResponsableAdmin_Province_ProvinceId",
                table: "ResponsableAdmin",
                column: "ProvinceId",
                principalSchema: "dbo",
                principalTable: "Province",
                principalColumn: "ProvinceId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MilieuStage_Politesse_PolitesseId",
                table: "MilieuStage");

            migrationBuilder.DropForeignKey(
                name: "FK_MilieuStage_Province_ProvinceId",
                table: "MilieuStage");

            migrationBuilder.DropForeignKey(
                name: "FK_MilieuStage_RegionAdministratives_RegionAdministrativeId",
                table: "MilieuStage");

            migrationBuilder.DropForeignKey(
                name: "FK_MilieuStage_Titre_TitreId",
                table: "MilieuStage");

            migrationBuilder.DropForeignKey(
                name: "FK_ResponsableAdmin_Province_ProvinceId",
                table: "ResponsableAdmin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Province",
                schema: "dbo",
                table: "Province");

            migrationBuilder.DropIndex(
                name: "IX_MilieuStage_PolitesseId",
                table: "MilieuStage");

            migrationBuilder.DropIndex(
                name: "IX_MilieuStage_ProvinceId",
                table: "MilieuStage");

            migrationBuilder.DropIndex(
                name: "IX_MilieuStage_RegionAdministrativeId",
                table: "MilieuStage");

            migrationBuilder.DropIndex(
                name: "IX_MilieuStage_TitreId",
                table: "MilieuStage");

            migrationBuilder.DropColumn(
                name: "ProvinceId",
                schema: "dbo",
                table: "Province");

            migrationBuilder.DropColumn(
                name: "Actif",
                table: "MilieuStage");

            migrationBuilder.DropColumn(
                name: "CellulaireResponsable",
                table: "MilieuStage");

            migrationBuilder.DropColumn(
                name: "CourrielResponsable",
                table: "MilieuStage");

            migrationBuilder.DropColumn(
                name: "NumeroMilieuStage",
                table: "MilieuStage");

            migrationBuilder.DropColumn(
                name: "PolitesseId",
                table: "MilieuStage");

            migrationBuilder.DropColumn(
                name: "PolitesseResponsableId",
                table: "MilieuStage");

            migrationBuilder.DropColumn(
                name: "PosteResponsable",
                table: "MilieuStage");

            migrationBuilder.DropColumn(
                name: "ProvinceEntrepriseId",
                table: "MilieuStage");

            migrationBuilder.DropColumn(
                name: "ProvinceId",
                table: "MilieuStage");

            migrationBuilder.DropColumn(
                name: "RegionAdministrativeEntrepriseId",
                table: "MilieuStage");

            migrationBuilder.DropColumn(
                name: "RegionAdministrativeId",
                table: "MilieuStage");

            migrationBuilder.DropColumn(
                name: "TelecopieurResponsable",
                table: "MilieuStage");

            migrationBuilder.DropColumn(
                name: "TelephoneResponsable",
                table: "MilieuStage");

            migrationBuilder.DropColumn(
                name: "TitreId",
                table: "MilieuStage");

            migrationBuilder.DropColumn(
                name: "TitreResponsableId",
                table: "MilieuStage");

            migrationBuilder.DropColumn(
                name: "VilleResponsable",
                table: "MilieuStage");

            migrationBuilder.AddColumn<int>(
                name: "PolitesseId",
                schema: "dbo",
                table: "Province",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "RegionAdministrativeId",
                table: "ResponsableAdmin",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AttenteTexte",
                table: "MilieuStage",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "MilieuStageActif",
                table: "MilieuStage",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "NumeroStage",
                table: "MilieuStage",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProvinceEntreprise",
                table: "MilieuStage",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProvinceResponsable",
                table: "MilieuStage",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RegionAdministrativeEntreprise",
                table: "MilieuStage",
                type: "nvarchar(45)",
                maxLength: 45,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResponsablePolitesseID",
                table: "MilieuStage",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResponsableTitreID",
                table: "MilieuStage",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VillResponsable",
                table: "MilieuStage",
                type: "nvarchar(45)",
                maxLength: 45,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Province",
                schema: "dbo",
                table: "Province",
                column: "PolitesseId");

            migrationBuilder.CreateIndex(
                name: "IX_ResponsableAdmin_RegionAdministrativeId",
                table: "ResponsableAdmin",
                column: "RegionAdministrativeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResponsableAdmin_Province_ProvinceId",
                table: "ResponsableAdmin",
                column: "ProvinceId",
                principalSchema: "dbo",
                principalTable: "Province",
                principalColumn: "PolitesseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResponsableAdmin_RegionAdministratives_RegionAdministrativeId",
                table: "ResponsableAdmin",
                column: "RegionAdministrativeId",
                principalTable: "RegionAdministratives",
                principalColumn: "RegionAdministrativeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
