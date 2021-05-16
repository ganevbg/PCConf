using Microsoft.EntityFrameworkCore.Migrations;

namespace PCConf.Data.Migrations
{
    public partial class MovedWarantyPeriod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WarrantyPeriod",
                table: "StorageDrives",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WarrantyPeriod",
                table: "PowerSuplies",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WarrantyPeriod",
                table: "StorageDrives");

            migrationBuilder.DropColumn(
                name: "WarrantyPeriod",
                table: "PowerSuplies");
        }
    }
}
