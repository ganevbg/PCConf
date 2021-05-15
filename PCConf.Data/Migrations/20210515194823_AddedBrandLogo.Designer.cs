﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PCConf.Data;

namespace PCConf.Data.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20210515194823_AddedBrandLogo")]
    partial class AddedBrandLogo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PCConf.Models.Parts.Brand", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("PCConf.Models.Parts.Certificate", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Certificate");
                });

            modelBuilder.Entity("PCConf.Models.Parts.CpuSocket", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CpuSocket");
                });

            modelBuilder.Entity("PCConf.Models.Parts.Format", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Format");
                });

            modelBuilder.Entity("PCConf.Models.Parts.Interface", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Interface");
                });

            modelBuilder.Entity("PCConf.Models.Parts.MotherBoard", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BrandId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Chipset")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CpuSocketId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("DualChannelSupport")
                        .HasColumnType("bit");

                    b.Property<Guid?>("FormatId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxRamCapacity")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("RamSlotsCount")
                        .HasColumnType("int");

                    b.Property<Guid?>("RamTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("WarrantyPeriod")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CpuSocketId");

                    b.HasIndex("FormatId");

                    b.HasIndex("RamTypeId");

                    b.ToTable("MotherBoards");
                });

            modelBuilder.Entity("PCConf.Models.Parts.PcCase", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BrandId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxCoolerSize")
                        .HasColumnType("int");

                    b.Property<int>("MaxVideoCardSize")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("SidePanel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WarrantyPeriod")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("PcCases");
                });

            modelBuilder.Entity("PCConf.Models.Parts.PcCaseFormat", b =>
                {
                    b.Property<Guid>("PcCaseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FormatId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PcCaseId", "FormatId");

                    b.HasIndex("FormatId");

                    b.ToTable("PcCaseFormat");
                });

            modelBuilder.Entity("PCConf.Models.Parts.PowerSuply", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BrandId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CertificateId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Output")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CertificateId");

                    b.ToTable("PowerSuplies");
                });

            modelBuilder.Entity("PCConf.Models.Parts.Processor", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BrandId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Cache")
                        .HasColumnType("int");

                    b.Property<Guid?>("CpuSocketId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Frequency")
                        .HasColumnType("float");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IntegratedGraphics")
                        .HasColumnType("bit");

                    b.Property<int>("LogicalCores")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhysicalCores")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid?>("RamTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("TurboBoostFrequency")
                        .HasColumnType("float");

                    b.Property<int>("WarrantyPeriod")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CpuSocketId");

                    b.HasIndex("RamTypeId");

                    b.ToTable("Processors");
                });

            modelBuilder.Entity("PCConf.Models.Parts.Ram", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BrandId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Frequency")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ModulesCount")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("SingleModuleSize")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<Guid?>("TypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("WarrantyPeriod")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("TypeId");

                    b.ToTable("Rams");
                });

            modelBuilder.Entity("PCConf.Models.Parts.RamType", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RamType");
                });

            modelBuilder.Entity("PCConf.Models.Parts.StorageDrive", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BrandId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("ReadSpeed")
                        .HasColumnType("int");

                    b.Property<Guid?>("TypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("WriteSpeed")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("TypeId");

                    b.ToTable("StorageDrives");
                });

            modelBuilder.Entity("PCConf.Models.Parts.StorageDriveType", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StorageDriveTypes");
                });

            modelBuilder.Entity("PCConf.Models.Parts.VideoCard", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BrandId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BusWidth")
                        .HasColumnType("int");

                    b.Property<string>("Chipset")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GraphicsProcessor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("InterfaceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("VideoRam")
                        .HasColumnType("int");

                    b.Property<Guid?>("VideoRamTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("WarrantyPeriod")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("InterfaceId");

                    b.HasIndex("VideoRamTypeId");

                    b.ToTable("VideoCards");
                });

            modelBuilder.Entity("PCConf.Models.Parts.VideoRamType", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VideoRamType");
                });

            modelBuilder.Entity("PCConf.Models.Parts.MotherBoard", b =>
                {
                    b.HasOne("PCConf.Models.Parts.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId");

                    b.HasOne("PCConf.Models.Parts.CpuSocket", "CpuSocket")
                        .WithMany()
                        .HasForeignKey("CpuSocketId");

                    b.HasOne("PCConf.Models.Parts.Format", "Format")
                        .WithMany()
                        .HasForeignKey("FormatId");

                    b.HasOne("PCConf.Models.Parts.RamType", "RamType")
                        .WithMany()
                        .HasForeignKey("RamTypeId");

                    b.Navigation("Brand");

                    b.Navigation("CpuSocket");

                    b.Navigation("Format");

                    b.Navigation("RamType");
                });

            modelBuilder.Entity("PCConf.Models.Parts.PcCase", b =>
                {
                    b.HasOne("PCConf.Models.Parts.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId");

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("PCConf.Models.Parts.PcCaseFormat", b =>
                {
                    b.HasOne("PCConf.Models.Parts.Format", "Format")
                        .WithMany()
                        .HasForeignKey("FormatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PCConf.Models.Parts.PcCase", "PcCase")
                        .WithMany("Formats")
                        .HasForeignKey("PcCaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Format");

                    b.Navigation("PcCase");
                });

            modelBuilder.Entity("PCConf.Models.Parts.PowerSuply", b =>
                {
                    b.HasOne("PCConf.Models.Parts.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId");

                    b.HasOne("PCConf.Models.Parts.Certificate", "Certificate")
                        .WithMany()
                        .HasForeignKey("CertificateId");

                    b.Navigation("Brand");

                    b.Navigation("Certificate");
                });

            modelBuilder.Entity("PCConf.Models.Parts.Processor", b =>
                {
                    b.HasOne("PCConf.Models.Parts.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId");

                    b.HasOne("PCConf.Models.Parts.CpuSocket", "CpuSocket")
                        .WithMany()
                        .HasForeignKey("CpuSocketId");

                    b.HasOne("PCConf.Models.Parts.RamType", "RamType")
                        .WithMany()
                        .HasForeignKey("RamTypeId");

                    b.Navigation("Brand");

                    b.Navigation("CpuSocket");

                    b.Navigation("RamType");
                });

            modelBuilder.Entity("PCConf.Models.Parts.Ram", b =>
                {
                    b.HasOne("PCConf.Models.Parts.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId");

                    b.HasOne("PCConf.Models.Parts.RamType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId");

                    b.Navigation("Brand");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("PCConf.Models.Parts.StorageDrive", b =>
                {
                    b.HasOne("PCConf.Models.Parts.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId");

                    b.HasOne("PCConf.Models.Parts.StorageDriveType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId");

                    b.Navigation("Brand");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("PCConf.Models.Parts.VideoCard", b =>
                {
                    b.HasOne("PCConf.Models.Parts.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId");

                    b.HasOne("PCConf.Models.Parts.Interface", "Interface")
                        .WithMany()
                        .HasForeignKey("InterfaceId");

                    b.HasOne("PCConf.Models.Parts.VideoRamType", "VideoRamType")
                        .WithMany()
                        .HasForeignKey("VideoRamTypeId");

                    b.Navigation("Brand");

                    b.Navigation("Interface");

                    b.Navigation("VideoRamType");
                });

            modelBuilder.Entity("PCConf.Models.Parts.PcCase", b =>
                {
                    b.Navigation("Formats");
                });
#pragma warning restore 612, 618
        }
    }
}
