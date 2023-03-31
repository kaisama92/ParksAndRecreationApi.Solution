﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParksAndRecreationApi.Models;

#nullable disable

namespace ParksAndRecreationApi.Migrations
{
    [DbContext(typeof(ParksAndRecreationApiContext))]
    partial class ParksAndRecreationApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ParksAndRecreationApi.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("County")
                        .HasColumnType("longtext");

                    b.Property<bool>("HasBathrooms")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("HasFamilyFriendlyBathrooms")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("HasPlayStructure")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsNationalPark")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsStatePark")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Latitude")
                        .HasColumnType("longtext");

                    b.Property<string>("Longitude")
                        .HasColumnType("longtext");

                    b.Property<string>("ParkName")
                        .HasColumnType("longtext");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            HasBathrooms = false,
                            HasFamilyFriendlyBathrooms = false,
                            HasPlayStructure = false,
                            IsNationalPark = false,
                            IsStatePark = true,
                            Latitude = "45.52075 N",
                            Longitude = "122.74365 W",
                            ParkName = "Willamette Stone State Heritage Site"
                        },
                        new
                        {
                            ParkId = 2,
                            HasBathrooms = false,
                            HasFamilyFriendlyBathrooms = false,
                            HasPlayStructure = false,
                            IsNationalPark = false,
                            IsStatePark = true,
                            Latitude = "45.66018 N",
                            Longitude = "122.83870 W",
                            ParkName = "Wapato Access Greenway State Park"
                        },
                        new
                        {
                            ParkId = 3,
                            HasBathrooms = false,
                            HasFamilyFriendlyBathrooms = true,
                            HasPlayStructure = false,
                            IsNationalPark = true,
                            IsStatePark = false,
                            Latitude = "45.62280 N",
                            Longitude = "122.66215 W",
                            ParkName = "Fort Vanouver National Historic Site"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
