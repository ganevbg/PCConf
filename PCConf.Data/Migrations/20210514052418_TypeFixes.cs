using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PCConf.Data.Migrations
{
    public partial class TypeFixes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Format_PcCases_PcCaseId",
                table: "Format");

            migrationBuilder.DropIndex(
                name: "IX_Format_PcCaseId",
                table: "Format");

            migrationBuilder.DropColumn(
                name: "PcCaseId",
                table: "Format");

            migrationBuilder.AddColumn<Guid>(
                name: "BrandId",
                table: "VideoCards",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BrandId",
                table: "Rams",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TypeId",
                table: "Rams",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VideoCards_BrandId",
                table: "VideoCards",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Rams_BrandId",
                table: "Rams",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Rams_TypeId",
                table: "Rams",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rams_Brand_BrandId",
                table: "Rams",
                column: "BrandId",
                principalTable: "Brand",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rams_RamType_TypeId",
                table: "Rams",
                column: "TypeId",
                principalTable: "RamType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VideoCards_Brand_BrandId",
                table: "VideoCards",
                column: "BrandId",
                principalTable: "Brand",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rams_Brand_BrandId",
                table: "Rams");

            migrationBuilder.DropForeignKey(
                name: "FK_Rams_RamType_TypeId",
                table: "Rams");

            migrationBuilder.DropForeignKey(
                name: "FK_VideoCards_Brand_BrandId",
                table: "VideoCards");

            migrationBuilder.DropIndex(
                name: "IX_VideoCards_BrandId",
                table: "VideoCards");

            migrationBuilder.DropIndex(
                name: "IX_Rams_BrandId",
                table: "Rams");

            migrationBuilder.DropIndex(
                name: "IX_Rams_TypeId",
                table: "Rams");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "VideoCards");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "Rams");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Rams");

            migrationBuilder.AddColumn<Guid>(
                name: "PcCaseId",
                table: "Format",
                type: "uniqueidentifier",
                nullable: true);

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
        }
    }
}
