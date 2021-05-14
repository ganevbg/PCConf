using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PCConf.Data.Migrations
{
    public partial class DbCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Certificate",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CpuSocket",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CpuSocket", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Format",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Format", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Interface",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interface", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<int>(type: "int", nullable: false),
                    ModulesCount = table.Column<int>(type: "int", nullable: false),
                    SingleModuleSize = table.Column<int>(type: "int", nullable: false),
                    Frequency = table.Column<int>(type: "int", nullable: false),
                    WarrantyPeriod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RamType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RamType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VideoRamType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoRamType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cases",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BrandId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SidePanel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxCoolentSize = table.Column<int>(type: "int", nullable: false),
                    MaxVideoCardSize = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Depth = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    WarrantyPeriod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cases_Brand_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PowerSuplies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BrandId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Output = table.Column<int>(type: "int", nullable: false),
                    CertificateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PowerSuplies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PowerSuplies_Brand_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PowerSuplies_Certificate_CertificateId",
                        column: x => x.CertificateId,
                        principalTable: "Certificate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MotherBoards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BrandId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CpuSocketId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Chipset = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormatId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RamTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RamSlotsCount = table.Column<int>(type: "int", nullable: false),
                    MaxRamCapacity = table.Column<int>(type: "int", nullable: false),
                    DualChannelSupport = table.Column<bool>(type: "bit", nullable: false),
                    WarrantyPeriod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotherBoards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MotherBoards_Brand_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MotherBoards_CpuSocket_CpuSocketId",
                        column: x => x.CpuSocketId,
                        principalTable: "CpuSocket",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MotherBoards_Format_FormatId",
                        column: x => x.FormatId,
                        principalTable: "Format",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MotherBoards_RamType_RamTypeId",
                        column: x => x.RamTypeId,
                        principalTable: "RamType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Processors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BrandId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CpuSocketId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PhysicalCores = table.Column<int>(type: "int", nullable: false),
                    LogicalCores = table.Column<int>(type: "int", nullable: false),
                    Frequency = table.Column<double>(type: "float", nullable: false),
                    TurboBoostFrequency = table.Column<double>(type: "float", nullable: false),
                    Cache = table.Column<int>(type: "int", nullable: false),
                    RamTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InterfaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IntegratedGraphics = table.Column<bool>(type: "bit", nullable: false),
                    WarrantyPeriod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Processors_Brand_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Processors_CpuSocket_CpuSocketId",
                        column: x => x.CpuSocketId,
                        principalTable: "CpuSocket",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Processors_Interface_InterfaceId",
                        column: x => x.InterfaceId,
                        principalTable: "Interface",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Processors_RamType_RamTypeId",
                        column: x => x.RamTypeId,
                        principalTable: "RamType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VideoCards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Chipset = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GraphicsProcessor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoRam = table.Column<int>(type: "int", nullable: false),
                    VideoRamTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BusWidth = table.Column<int>(type: "int", nullable: false),
                    InterfaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Length = table.Column<int>(type: "int", nullable: false),
                    WarrantyPeriod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VideoCards_Interface_InterfaceId",
                        column: x => x.InterfaceId,
                        principalTable: "Interface",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VideoCards_VideoRamType_VideoRamTypeId",
                        column: x => x.VideoRamTypeId,
                        principalTable: "VideoRamType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PcCaseFormat",
                columns: table => new
                {
                    PcCaseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FormatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PcCaseFormat", x => new { x.PcCaseId, x.FormatId });
                    table.ForeignKey(
                        name: "FK_PcCaseFormat_Cases_PcCaseId",
                        column: x => x.PcCaseId,
                        principalTable: "Cases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PcCaseFormat_Format_FormatId",
                        column: x => x.FormatId,
                        principalTable: "Format",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cases_BrandId",
                table: "Cases",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_MotherBoards_BrandId",
                table: "MotherBoards",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_MotherBoards_CpuSocketId",
                table: "MotherBoards",
                column: "CpuSocketId");

            migrationBuilder.CreateIndex(
                name: "IX_MotherBoards_FormatId",
                table: "MotherBoards",
                column: "FormatId");

            migrationBuilder.CreateIndex(
                name: "IX_MotherBoards_RamTypeId",
                table: "MotherBoards",
                column: "RamTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PcCaseFormat_FormatId",
                table: "PcCaseFormat",
                column: "FormatId");

            migrationBuilder.CreateIndex(
                name: "IX_PowerSuplies_BrandId",
                table: "PowerSuplies",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_PowerSuplies_CertificateId",
                table: "PowerSuplies",
                column: "CertificateId");

            migrationBuilder.CreateIndex(
                name: "IX_Processors_BrandId",
                table: "Processors",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Processors_CpuSocketId",
                table: "Processors",
                column: "CpuSocketId");

            migrationBuilder.CreateIndex(
                name: "IX_Processors_InterfaceId",
                table: "Processors",
                column: "InterfaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Processors_RamTypeId",
                table: "Processors",
                column: "RamTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoCards_InterfaceId",
                table: "VideoCards",
                column: "InterfaceId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoCards_VideoRamTypeId",
                table: "VideoCards",
                column: "VideoRamTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MotherBoards");

            migrationBuilder.DropTable(
                name: "PcCaseFormat");

            migrationBuilder.DropTable(
                name: "PowerSuplies");

            migrationBuilder.DropTable(
                name: "Processors");

            migrationBuilder.DropTable(
                name: "Rams");

            migrationBuilder.DropTable(
                name: "VideoCards");

            migrationBuilder.DropTable(
                name: "Cases");

            migrationBuilder.DropTable(
                name: "Format");

            migrationBuilder.DropTable(
                name: "Certificate");

            migrationBuilder.DropTable(
                name: "CpuSocket");

            migrationBuilder.DropTable(
                name: "RamType");

            migrationBuilder.DropTable(
                name: "Interface");

            migrationBuilder.DropTable(
                name: "VideoRamType");

            migrationBuilder.DropTable(
                name: "Brand");
        }
    }
}
