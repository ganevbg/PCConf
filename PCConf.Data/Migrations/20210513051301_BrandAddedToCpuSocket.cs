using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PCConf.Data.Migrations
{
    public partial class BrandAddedToCpuSocket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "BrandId",
                table: "CpuSocket",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CpuSocket_BrandId",
                table: "CpuSocket",
                column: "BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_CpuSocket_Brand_BrandId",
                table: "CpuSocket",
                column: "BrandId",
                principalTable: "Brand",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CpuSocket_Brand_BrandId",
                table: "CpuSocket");

            migrationBuilder.DropIndex(
                name: "IX_CpuSocket_BrandId",
                table: "CpuSocket");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "CpuSocket");
        }
    }
}
