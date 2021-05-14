using Microsoft.EntityFrameworkCore.Migrations;

namespace PCConf.Data.Migrations
{
    public partial class AddedStorageDriveAndSellableItemModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "VideoCards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "VideoCards",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "VideoCards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Rams",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Rams",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Rams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Processors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Processors",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Processors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "PowerSuplies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "PowerSuplies",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "PowerSuplies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "PcCases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "PcCases",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "PcCases",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "MotherBoards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "MotherBoards",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "MotherBoards",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "VideoCards");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "VideoCards");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "VideoCards");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Rams");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Rams");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Rams");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Processors");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Processors");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Processors");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "PowerSuplies");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "PowerSuplies");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "PowerSuplies");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "PcCases");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "PcCases");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "PcCases");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "MotherBoards");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "MotherBoards");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "MotherBoards");
        }
    }
}
