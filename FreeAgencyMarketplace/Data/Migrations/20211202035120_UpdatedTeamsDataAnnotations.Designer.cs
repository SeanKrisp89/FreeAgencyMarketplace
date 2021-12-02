﻿// <auto-generated />
using System;
using FreeAgencyMarketplace.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FreeAgencyMarketplace.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211202035120_UpdatedTeamsDataAnnotations")]
    partial class UpdatedTeamsDataAnnotations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FreeAgencyMarketplace.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("ImageData")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ImageTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("FreeAgencyMarketplace.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<bool>("IsFreeAgent")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PositionId")
                        .HasColumnType("int");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 22,
                            IsFreeAgent = false,
                            Name = "Justin Fields",
                            PositionId = 1,
                            TeamId = 1
                        },
                        new
                        {
                            Id = 2,
                            Age = 25,
                            IsFreeAgent = false,
                            Name = "Roquan Smith",
                            PositionId = 7,
                            TeamId = 1
                        },
                        new
                        {
                            Id = 3,
                            Age = 29,
                            IsFreeAgent = false,
                            Name = "Byron Murphy",
                            PositionId = 5,
                            TeamId = 2
                        },
                        new
                        {
                            Id = 4,
                            Age = 30,
                            IsFreeAgent = false,
                            Name = "Aaron Donald",
                            PositionId = 10,
                            TeamId = 7
                        },
                        new
                        {
                            Id = 5,
                            Age = 26,
                            IsFreeAgent = false,
                            Name = "Cooper Kupp",
                            PositionId = 3,
                            TeamId = 7
                        },
                        new
                        {
                            Id = 6,
                            Age = 27,
                            IsFreeAgent = false,
                            Name = "Austin Ekeler",
                            PositionId = 2,
                            TeamId = 3
                        },
                        new
                        {
                            Id = 7,
                            Age = 25,
                            IsFreeAgent = false,
                            Name = "Fred Warner",
                            PositionId = 7,
                            TeamId = 4
                        },
                        new
                        {
                            Id = 8,
                            Age = 27,
                            IsFreeAgent = false,
                            Name = "J.J. Watt",
                            PositionId = 6,
                            TeamId = 5
                        },
                        new
                        {
                            Id = 9,
                            Age = 28,
                            IsFreeAgent = false,
                            Name = "Nick Bosa",
                            PositionId = 8,
                            TeamId = 4
                        },
                        new
                        {
                            Id = 10,
                            Age = 28,
                            IsFreeAgent = false,
                            Name = "Jamaal Adams",
                            PositionId = 9,
                            TeamId = 6
                        },
                        new
                        {
                            Id = 11,
                            Age = 22,
                            IsFreeAgent = false,
                            Name = "Jalen Hurts",
                            PositionId = 1,
                            TeamId = 8
                        },
                        new
                        {
                            Id = 12,
                            Age = 24,
                            IsFreeAgent = false,
                            Name = "T.J. Hockenson",
                            PositionId = 4,
                            TeamId = 9
                        },
                        new
                        {
                            Id = 13,
                            Age = 28,
                            IsFreeAgent = false,
                            Name = "Alvin Kamara",
                            PositionId = 2,
                            TeamId = 10
                        });
                });

            modelBuilder.Entity("FreeAgencyMarketplace.Models.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Positions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Quarterback"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Running back"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Wide Receiver"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Tight End"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Cornerback"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Outside Linebacker"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Middle Linebacker"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Defenseive End"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Safety"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Defensive Tackel"
                        });
                });

            modelBuilder.Entity("FreeAgencyMarketplace.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte?>("ActiveRosterCount")
                        .HasColumnType("tinyint");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Conference")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Division")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stadium")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Chicago",
                            Conference = "NFC",
                            Division = "North",
                            Name = "Bears",
                            Stadium = "Soldier Field"
                        },
                        new
                        {
                            Id = 2,
                            City = "Miami",
                            Conference = "AFC",
                            Division = "East",
                            Name = "Dolphins",
                            Stadium = "Hard Rock Stadium"
                        },
                        new
                        {
                            Id = 3,
                            City = "Los Angeles",
                            Conference = "AFC",
                            Division = "West",
                            Name = "Chargers",
                            Stadium = "SoFi Stadium"
                        },
                        new
                        {
                            Id = 4,
                            City = "San Francisco",
                            Conference = "NFC",
                            Division = "West",
                            Name = "49ers",
                            Stadium = "Levi's Stadium"
                        },
                        new
                        {
                            Id = 5,
                            City = "Pittsburgh",
                            Conference = "AFC",
                            Division = "North",
                            Name = "Steelers",
                            Stadium = "Heinz Field"
                        },
                        new
                        {
                            Id = 6,
                            City = "Seattle",
                            Conference = "NFC",
                            Division = "West",
                            Name = "Seahawks",
                            Stadium = "Century Link Stadium"
                        },
                        new
                        {
                            Id = 7,
                            City = "Los Angeles",
                            Conference = "NFC",
                            Division = "West",
                            Name = "Rams",
                            Stadium = "SoFi Stadium"
                        },
                        new
                        {
                            Id = 8,
                            City = "Philadelphia",
                            Conference = "NFC",
                            Division = "East",
                            Name = "Eagles",
                            Stadium = "Lincoln Financial"
                        },
                        new
                        {
                            Id = 9,
                            City = "Detroit",
                            Conference = "NFC",
                            Division = "North",
                            Name = "Lions",
                            Stadium = "Ford Field"
                        },
                        new
                        {
                            Id = 10,
                            City = "New Orleans",
                            Conference = "NFC",
                            Division = "South",
                            Name = "Saints",
                            Stadium = "Cesars Superdome"
                        });
                });

            modelBuilder.Entity("FreeAgencyMarketplace.Models.Player", b =>
                {
                    b.HasOne("FreeAgencyMarketplace.Models.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FreeAgencyMarketplace.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
