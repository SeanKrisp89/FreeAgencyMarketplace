using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using FreeAgencyMarketplace.Models;
using Microsoft.Extensions.Configuration;


namespace FreeAgencyMarketplace.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		public ApplicationDbContext()
		{

		}

		//RESEARCH THIS: I had to add this in order to establish a valid connection to the database
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			IConfigurationRoot configuration = new ConfigurationBuilder()

				.SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
				.AddJsonFile("appsettings.json")
				.Build();
			optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
		}

		//So in .NET Core MVC, we need to add our models to the ApplicationDbContext.cs file in order to generate the DB (just like in our .NET Framework tutorial)
		public DbSet<Player> Players { get; set; }
		public DbSet<Team> Teams { get; set; }
		public DbSet<Image> Images { get; set; }

		public DbSet<Position> Positions { get; set; }
		//public DbSet<Contract> Contracts { get; set; }

		//So apparently this is how you seed your database with EF Core now. You need to override the OnModelCreating method and pass in an object of that entity type (as opposed to straight up Sql() statements/methods)
		protected override void OnModelCreating(ModelBuilder builder)//This method is called when the model for a derived context has been initialized, but before the model has been locked down and used to initialize the context. The default implementation of this method does nothing, but it can be overriden in a derived class such that the model can be further configured before it is locked down.
		{

			base.OnModelCreating(builder); //Not sure why that youtube tutorial had us remove the call to the base...

			builder.Entity<Player>().HasData(
					new Player()
					{
						Id = 1,
						Name = "Justin Fields",
						PositionId = 1,
						Age = 22,
						IsFreeAgent = false,
						TeamId = 1
					},
					new Player()
					{
						Id = 2,
						Name = "Roquan Smith",
						PositionId = 7,
						Age = 25,
						IsFreeAgent = false,
						TeamId = 1
					},
					new Player()
					{
						Id = 3,
						Name = "Byron Murphy",
						PositionId = 5,
						Age = 29,
						IsFreeAgent = false,
						TeamId = 2
					},
					new Player()
					{
						Id = 4,
						Name = "Aaron Donald",
						PositionId = 10,
						Age = 30,
						IsFreeAgent = false,
						TeamId = 7
					},
					new Player()
					{
						Id = 5,
						Name = "Cooper Kupp",
						PositionId = 3,
						Age = 26,
						IsFreeAgent = false,
						TeamId = 7
					},
					new Player()
					{
						Id = 6,
						Name = "Austin Ekeler",
						PositionId = 2,
						Age = 27,
						IsFreeAgent = false,
						TeamId = 3
					},
					new Player()
					{
						Id = 7,
						Name = "Fred Warner",
						PositionId = 7,
						Age = 25,
						IsFreeAgent = false,
						TeamId = 4
					},
					new Player()
					{
						Id = 8,
						Name = "J.J. Watt",
						PositionId = 6,
						Age = 27,
						IsFreeAgent = false,
						TeamId = 5
					},
					new Player()
					{
						Id = 9,
						Name = "Nick Bosa",
						PositionId = 8,
						Age = 28,
						IsFreeAgent = false,
						TeamId = 4
					},
					new Player()
					{
						Id = 10,
						Name = "Jamaal Adams",
						PositionId = 9,
						Age = 28,
						IsFreeAgent = false,
						TeamId = 6
					},
					new Player()
					{
						Id = 11,
						Name = "Jalen Hurts",
						PositionId = 1,
						Age = 22,
						IsFreeAgent = false,
						TeamId = 8
					},
					new Player()
					{
						Id = 12,
						Name = "T.J. Hockenson",
						PositionId = 4,
						Age = 24,
						IsFreeAgent = false,
						TeamId = 9
					},
					new Player()
					{
						Id = 13,
						Name = "Alvin Kamara",
						PositionId = 2,
						Age = 28,
						IsFreeAgent = false,
						TeamId = 10
					}
				);

			builder.Entity<Team>().HasData(
					new Team()
					{
						Id = 1,
						Name = "Bears",
						Division = "North",
						Conference = "NFC",
						Stadium = "Soldier Field",
						City = "Chicago"
					},
					new Team()
					{
						Id = 2,
						Name = "Dolphins",
						Division = "East",
						Conference = "AFC",
						Stadium = "Hard Rock Stadium",
						City = "Miami"
					},
					new Team()
					{
						Id = 3,
						Name = "Chargers",
						Division = "West",
						Conference = "AFC",
						Stadium = "SoFi Stadium",
						City = "Los Angeles"
					},
					new Team()
					{
						Id = 4,
						Name = "49ers",
						Division = "West",
						Conference = "NFC",
						Stadium = "Levi's Stadium",
						City = "San Francisco"
					},
					new Team()
					{
						Id = 5,
						Name = "Steelers",
						Division = "North",
						Conference = "AFC",
						Stadium = "Heinz Field",
						City = "Pittsburgh"
					},
					new Team()
					{
						Id = 6,
						Name = "Seahawks",
						Division = "West",
						Conference = "NFC",
						Stadium = "Century Link Stadium",
						City = "Seattle"
					},
					new Team()
					{
						Id = 7,
						Name = "Rams",
						Division = "West",
						Conference = "NFC",
						Stadium = "SoFi Stadium",
						City = "Los Angeles"
					},
					new Team()
					{
						Id = 8,
						Name = "Eagles",
						Division = "East",
						Conference = "NFC",
						Stadium = "Lincoln Financial",
						City = "Philadelphia"
					},
					new Team()
					{
						Id = 9,
						Name = "Lions",
						Division = "North",
						Conference = "NFC",
						Stadium = "Ford Field",
						City = "Detroit"
					},
					new Team()
					{
						Id = 10,
						Name = "Saints",
						Division = "South",
						Conference = "NFC",
						Stadium = "Cesars Superdome",
						City = "New Orleans"
					}
				);

			builder.Entity<Position>().HasData(
					new Position()
					{
						Id = 1,
						Name = "Quarterback"
					},
					new Position()
					{
						Id = 2,
						Name = "Running back"
					},
					new Position()
					{
						Id = 3, 
						Name = "Wide Receiver"
					},
					new Position()
					{
						Id = 4,
						Name = "Tight End"
					},
					new Position()
					{
						Id = 5,
						Name = "Cornerback"
					},
					new Position()
					{
						Id = 6,
						Name = "Outside Linebacker"
					},
					new Position()
					{
						Id = 7,
						Name = "Middle Linebacker"
					},
					new Position()
					{
						Id = 8,
						Name = "Defenseive End"
					},
					new Position()
					{
						Id = 9,
						Name = "Safety"
					},
					new Position()
					{
						Id = 10,
						Name = "Defensive Tackel"
					}
				);
		}
	}
}
