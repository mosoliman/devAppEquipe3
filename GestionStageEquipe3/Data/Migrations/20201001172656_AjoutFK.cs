using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionStageEquipe3.Data.Migrations
{
    public partial class AjoutFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Province",
                table: "ResponsableAdmin");

            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.RenameColumn(
                name: "TitreID",
                table: "ResponsableAdmin",
                newName: "TitreId");

            migrationBuilder.RenameColumn(
                name: "PolitesseID",
                table: "ResponsableAdmin",
                newName: "PolitesseId");

            migrationBuilder.AlterColumn<int>(
                name: "TitreId",
                table: "ResponsableAdmin",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PolitesseId",
                table: "ResponsableAdmin",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProvinceId",
                table: "ResponsableAdmin",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Politesse",
                schema: "dbo",
                columns: table => new
                {
                    PolitesseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescriptionPolitesse = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Politesse", x => x.PolitesseId);
                });

            migrationBuilder.CreateTable(
                name: "Province",
                schema: "dbo",
                columns: table => new
                {
                    PolitesseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescriptionProvince = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.PolitesseId);
                });

            migrationBuilder.CreateTable(
                name: "Titre",
                schema: "dbo",
                columns: table => new
                {
                    TitreId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescriptionRegionAdministrative = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titre", x => x.TitreId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ResponsableAdmin_PolitesseId",
                table: "ResponsableAdmin",
                column: "PolitesseId");

            migrationBuilder.CreateIndex(
                name: "IX_ResponsableAdmin_ProvinceId",
                table: "ResponsableAdmin",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_ResponsableAdmin_TitreId",
                table: "ResponsableAdmin",
                column: "TitreId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResponsableAdmin_Politesse_PolitesseId",
                table: "ResponsableAdmin",
                column: "PolitesseId",
                principalSchema: "dbo",
                principalTable: "Politesse",
                principalColumn: "PolitesseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResponsableAdmin_Province_ProvinceId",
                table: "ResponsableAdmin",
                column: "ProvinceId",
                principalSchema: "dbo",
                principalTable: "Province",
                principalColumn: "PolitesseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResponsableAdmin_Titre_TitreId",
                table: "ResponsableAdmin",
                column: "TitreId",
                principalSchema: "dbo",
                principalTable: "Titre",
                principalColumn: "TitreId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResponsableAdmin_Politesse_PolitesseId",
                table: "ResponsableAdmin");

            migrationBuilder.DropForeignKey(
                name: "FK_ResponsableAdmin_Province_ProvinceId",
                table: "ResponsableAdmin");

            migrationBuilder.DropForeignKey(
                name: "FK_ResponsableAdmin_Titre_TitreId",
                table: "ResponsableAdmin");

            migrationBuilder.DropTable(
                name: "Politesse",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Province",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Titre",
                schema: "dbo");

            migrationBuilder.DropIndex(
                name: "IX_ResponsableAdmin_PolitesseId",
                table: "ResponsableAdmin");

            migrationBuilder.DropIndex(
                name: "IX_ResponsableAdmin_ProvinceId",
                table: "ResponsableAdmin");

            migrationBuilder.DropIndex(
                name: "IX_ResponsableAdmin_TitreId",
                table: "ResponsableAdmin");

            migrationBuilder.DropColumn(
                name: "ProvinceId",
                table: "ResponsableAdmin");

            migrationBuilder.RenameColumn(
                name: "TitreId",
                table: "ResponsableAdmin",
                newName: "TitreID");

            migrationBuilder.RenameColumn(
                name: "PolitesseId",
                table: "ResponsableAdmin",
                newName: "PolitesseID");

            migrationBuilder.AlterColumn<string>(
                name: "TitreID",
                table: "ResponsableAdmin",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "PolitesseID",
                table: "ResponsableAdmin",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Province",
                table: "ResponsableAdmin",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);
        }
    }
}
