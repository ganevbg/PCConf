using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PCConf.Data.Migrations
{
    public partial class RemoveInterafaceFromCpu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Processors_Interface_InterfaceId",
                table: "Processors");

            migrationBuilder.DropIndex(
                name: "IX_Processors_InterfaceId",
                table: "Processors");

            migrationBuilder.DropColumn(
                name: "InterfaceId",
                table: "Processors");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "InterfaceId",
                table: "Processors",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Processors_InterfaceId",
                table: "Processors",
                column: "InterfaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Processors_Interface_InterfaceId",
                table: "Processors",
                column: "InterfaceId",
                principalTable: "Interface",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
