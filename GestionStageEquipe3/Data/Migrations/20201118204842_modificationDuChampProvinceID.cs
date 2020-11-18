﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionStageEquipe3.Data.Migrations
{
    public partial class modificationDuChampProvinceID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MilieuStage_Province_ProvinceId",
                table: "MilieuStage");

            migrationBuilder.AlterColumn<int>(
                name: "ProvinceId",
                table: "MilieuStage",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ProvinceEntrepriseId",
                table: "MilieuStage",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_MilieuStage_Province_ProvinceId",
                table: "MilieuStage",
                column: "ProvinceId",
                principalSchema: "dbo",
                principalTable: "Province",
                principalColumn: "ProvinceId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MilieuStage_Province_ProvinceId",
                table: "MilieuStage");

            migrationBuilder.DropColumn(
                name: "ProvinceEntrepriseId",
                table: "MilieuStage");

            migrationBuilder.AlterColumn<int>(
                name: "ProvinceId",
                table: "MilieuStage",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MilieuStage_Province_ProvinceId",
                table: "MilieuStage",
                column: "ProvinceId",
                principalSchema: "dbo",
                principalTable: "Province",
                principalColumn: "ProvinceId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
