﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Wappa.Infra.Data.Context;

namespace Wappa.Infra.Data.Migrations
{
    [DbContext(typeof(WappaContext))]
    partial class WappaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Wappa.Domain.Models.Driver", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnName("Address")
                        .HasColumnType("varchar(1000)");

                    b.Property<string>("CarBrand")
                        .IsRequired()
                        .HasColumnName("CarBrand")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("CarModel")
                        .IsRequired()
                        .HasColumnName("CarModel")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("CarPlate")
                        .IsRequired()
                        .HasColumnName("CarPlate")
                        .HasColumnType("varchar(7)");

                    b.Property<string>("Coordinates")
                        .IsRequired()
                        .HasColumnName("Coordinates")
                        .HasColumnType("varchar(500)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("LastName")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Zipcode")
                        .IsRequired()
                        .HasColumnName("ZipCode")
                        .HasColumnType("varchar(9)");

                    b.HasKey("Id");

                    b.ToTable("Drivers");
                });
#pragma warning restore 612, 618
        }
    }
}
