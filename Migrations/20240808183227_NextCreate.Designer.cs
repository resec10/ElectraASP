﻿// <auto-generated />
using System;
using ElectraASP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ElectraASP.Migrations
{
    [DbContext(typeof(ThisContext))]
    [Migration("20240808183227_NextCreate")]
    partial class NextCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ElectraASP.Models.CPU", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("ComputerID")
                        .HasColumnType("int");

                    b.Property<int>("CoreCount")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ImageHeight")
                        .HasColumnType("int");

                    b.Property<string>("ImageLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ImageWidth")
                        .HasColumnType("int");

                    b.Property<string>("IntegratedGraphics")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PerformanceBoostClock")
                        .HasColumnType("float");

                    b.Property<double>("PerformanceCoreBoost")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("TDP")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ComputerID");

                    b.ToTable("CPU_Table");
                });

            modelBuilder.Entity("ElectraASP.Models.Case", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ComputerID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ImageHeight")
                        .HasColumnType("int");

                    b.Property<string>("ImageLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ImageWidth")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PowerSupply")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("SidePanel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ComputerID");

                    b.ToTable("Cases");
                });

            modelBuilder.Entity("ElectraASP.Models.Computer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("ImageLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subtitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Computers");
                });

            modelBuilder.Entity("ElectraASP.Models.Cooler", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ComputerID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FanRPM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ImageHeight")
                        .HasColumnType("int");

                    b.Property<string>("ImageLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ImageWidth")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("NoiseLevel")
                        .HasColumnType("real");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("RadiatorSize")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ComputerID");

                    b.ToTable("Coolers");
                });

            modelBuilder.Entity("ElectraASP.Models.Motherboard", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ComputerID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FormFactor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ImageHeight")
                        .HasColumnType("int");

                    b.Property<string>("ImageLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ImageWidth")
                        .HasColumnType("int");

                    b.Property<int>("MaxMemory")
                        .HasColumnType("int");

                    b.Property<int>("MemorySlots")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Socket")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ComputerID");

                    b.ToTable("Motherboards");
                });

            modelBuilder.Entity("ElectraASP.Models.Power", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ComputerID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EfficiencyRating")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ImageHeight")
                        .HasColumnType("int");

                    b.Property<string>("ImageLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ImageWidth")
                        .HasColumnType("int");

                    b.Property<bool>("Modular")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Wattage")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ComputerID");

                    b.ToTable("Powers");
                });

            modelBuilder.Entity("ElectraASP.Models.RAM", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CASLatency")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ComputerID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FirstWordLatency")
                        .HasColumnType("int");

                    b.Property<int>("ImageHeight")
                        .HasColumnType("int");

                    b.Property<string>("ImageLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ImageWidth")
                        .HasColumnType("int");

                    b.Property<string>("Modules")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Speed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ComputerID");

                    b.ToTable("RAM_Table");
                });

            modelBuilder.Entity("ElectraASP.Models.SSD", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Cache")
                        .HasColumnType("int");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<int?>("ComputerID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FormFactor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ImageHeight")
                        .HasColumnType("int");

                    b.Property<string>("ImageLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ImageWidth")
                        .HasColumnType("int");

                    b.Property<string>("Interface")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ComputerID");

                    b.ToTable("SSD_Table");
                });

            modelBuilder.Entity("ElectraASP.Models.VideoCard", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("BoostClock")
                        .HasColumnType("int");

                    b.Property<string>("Chipset")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ComputerID")
                        .HasColumnType("int");

                    b.Property<int>("CoreClock")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ImageHeight")
                        .HasColumnType("int");

                    b.Property<string>("ImageLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ImageWidth")
                        .HasColumnType("int");

                    b.Property<int>("Memory")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("ComputerID");

                    b.ToTable("VideoCards");
                });

            modelBuilder.Entity("ElectraASP.Models.CPU", b =>
                {
                    b.HasOne("ElectraASP.Models.Computer", "Computer")
                        .WithMany()
                        .HasForeignKey("ComputerID");

                    b.Navigation("Computer");
                });

            modelBuilder.Entity("ElectraASP.Models.Case", b =>
                {
                    b.HasOne("ElectraASP.Models.Computer", "Computer")
                        .WithMany()
                        .HasForeignKey("ComputerID");

                    b.Navigation("Computer");
                });

            modelBuilder.Entity("ElectraASP.Models.Cooler", b =>
                {
                    b.HasOne("ElectraASP.Models.Computer", "Computer")
                        .WithMany()
                        .HasForeignKey("ComputerID");

                    b.Navigation("Computer");
                });

            modelBuilder.Entity("ElectraASP.Models.Motherboard", b =>
                {
                    b.HasOne("ElectraASP.Models.Computer", "Computer")
                        .WithMany()
                        .HasForeignKey("ComputerID");

                    b.Navigation("Computer");
                });

            modelBuilder.Entity("ElectraASP.Models.Power", b =>
                {
                    b.HasOne("ElectraASP.Models.Computer", "Computer")
                        .WithMany()
                        .HasForeignKey("ComputerID");

                    b.Navigation("Computer");
                });

            modelBuilder.Entity("ElectraASP.Models.RAM", b =>
                {
                    b.HasOne("ElectraASP.Models.Computer", "Computer")
                        .WithMany()
                        .HasForeignKey("ComputerID");

                    b.Navigation("Computer");
                });

            modelBuilder.Entity("ElectraASP.Models.SSD", b =>
                {
                    b.HasOne("ElectraASP.Models.Computer", "Computer")
                        .WithMany()
                        .HasForeignKey("ComputerID");

                    b.Navigation("Computer");
                });

            modelBuilder.Entity("ElectraASP.Models.VideoCard", b =>
                {
                    b.HasOne("ElectraASP.Models.Computer", "Computer")
                        .WithMany()
                        .HasForeignKey("ComputerID");

                    b.Navigation("Computer");
                });
#pragma warning restore 612, 618
        }
    }
}
