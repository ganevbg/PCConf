using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PCConf.Data.Migrations
{
    public partial class RenamingsAndRemoving : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cases_Brand_BrandId",
                table: "Cases");

            migrationBuilder.DropForeignKey(
                name: "FK_CpuSocket_Brand_BrandId",
                table: "CpuSocket");

            migrationBuilder.DropForeignKey(
                name: "FK_PcCaseFormat_Cases_PcCaseId",
                table: "PcCaseFormat");

            migrationBuilder.DropIndex(
                name: "IX_CpuSocket_BrandId",
                table: "CpuSocket");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cases",
                table: "Cases");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "CpuSocket");

            migrationBuilder.DropColumn(
                name: "Depth",
                table: "Cases");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Cases");

            migrationBuilder.DropColumn(
                name: "MaxCoolentSize",
                table: "Cases");

            migrationBuilder.RenameTable(
                name: "Cases",
                newName: "PcCases");

            migrationBuilder.RenameColumn(
                name: "Width",
                table: "PcCases",
                newName: "MaxCoolerSize");

            migrationBuilder.RenameIndex(
                name: "IX_Cases_BrandId",
                table: "PcCases",
                newName: "IX_PcCases_BrandId");

            migrationBuilder.AddColumn<Guid>(
                name: "PcCaseId",
                table: "Format",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PcCases",
                table: "PcCases",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Format_PcCaseId",
                table: "Format",
                column: "PcCaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Format_PcCases_PcCaseId",
                table: "Format",
                column: "PcCaseId",
                principalTable: "PcCases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PcCaseFormat_PcCases_PcCaseId",
                table: "PcCaseFormat",
                column: "PcCaseId",
                principalTable: "PcCases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PcCases_Brand_BrandId",
                table: "PcCases",
                column: "BrandId",
                principalTable: "Brand",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Format_PcCases_PcCaseId",
                table: "Format");

            migrationBuilder.DropForeignKey(
                name: "FK_PcCaseFormat_PcCases_PcCaseId",
                table: "PcCaseFormat");

            migrationBuilder.DropForeignKey(
                name: "FK_PcCases_Brand_BrandId",
                table: "PcCases");

            migrationBuilder.DropIndex(
                name: "IX_Format_PcCaseId",
                table: "Format");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PcCases",
                table: "PcCases");

            migrationBuilder.DropColumn(
                name: "PcCaseId",
                table: "Format");

            migrationBuilder.RenameTable(
                name: "PcCases",
                newName: "Cases");

            migrationBuilder.RenameColumn(
                name: "MaxCoolerSize",
                table: "Cases",
                newName: "Width");

            migrationBuilder.RenameIndex(
                name: "IX_PcCases_BrandId",
                table: "Cases",
                newName: "IX_Cases_BrandId");

            migrationBuilder.AddColumn<Guid>(
                name: "BrandId",
                table: "CpuSocket",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Depth",
                table: "Cases",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Height",
                table: "Cases",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaxCoolentSize",
                table: "Cases",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cases",
                table: "Cases",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_CpuSocket_BrandId",
                table: "CpuSocket",
                column: "BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_Brand_BrandId",
                table: "Cases",
                column: "BrandId",
                principalTable: "Brand",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CpuSocket_Brand_BrandId",
                table: "CpuSocket",
                column: "BrandId",
                principalTable: "Brand",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PcCaseFormat_Cases_PcCaseId",
                table: "PcCaseFormat",
                column: "PcCaseId",
                principalTable: "Cases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
