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
    [Migration("20211125161053_SeedPlayersAndTeamsTables")]
    partial class SeedPlayersAndTeamsTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 22,
                            IsFreeAgent = false,
                            Name = "Justin Fields",
                            Position = "Quarterback",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 2,
                            Age = 25,
                            IsFreeAgent = false,
                            Name = "Roquan Smith",
                            Position = "Middle Linebacker",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 3,
                            Age = 29,
                            IsFreeAgent = false,
                            Name = "Byron Murphy",
                            Position = "Cornerback",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 4,
                            Age = 30,
                            IsFreeAgent = false,
                            Name = "Aaron Donald",
                            Position = "Defensive Tackle",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 5,
                            Age = 26,
                            IsFreeAgent = false,
                            Name = "Cooper Kupp",
                            Position = "Wide Receiver",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 6,
                            Age = 27,
                            IsFreeAgent = false,
                            Name = "Austin Ekeler",
                            Position = "Runningback",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 7,
                            Age = 25,
                            IsFreeAgent = false,
                            Name = "Fred Warner",
                            Position = "Middle Linebacker",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 8,
                            Age = 27,
                            IsFreeAgent = false,
                            Name = "J.J. Watt",
                            Position = "Outside Linebacker",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 9,
                            Age = 28,
                            IsFreeAgent = false,
                            Name = "Nick Bosa",
                            Position = "Defensive End",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 10,
                            Age = 28,
                            IsFreeAgent = false,
                            Name = "Jamaal Adams",
                            Position = "Free Safety",
                            TeamId = 1
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
                            City = "Kansas City",
                            Conference = "AFC",
                            Division = "West",
                            Name = "Chiefs",
                            Stadium = "Arrowhead"
                        },
                        new
                        {
                            Id = 3,
                            City = "Tampa Bay",
                            Conference = "NFC",
                            Division = "South",
                            Name = "Buccaneers",
                            Stadium = "Raymond James"
                        },
                        new
                        {
                            Id = 4,
                            City = "Boston",
                            Conference = "AFC",
                            Division = "East",
                            Name = "Patriots",
                            Stadium = "Gillette Stadium"
                        },
                        new
                        {
                            Id = 5,
                            City = "Cincinnati",
                            Conference = "AFC",
                            Division = "North",
                            Name = "Bengals",
                            Stadium = "Paul Brown Stadium"
                        },
                        new
                        {
                            Id = 6,
                            City = "Nashville",
                            Conference = "AFC",
                            Division = "South",
                            Name = "Titans",
                            Stadium = "Nissan Stadium"
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
