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
		public DbSet<Contract> Contracts { get; set; }

		//So apparently this is how you seed your database with EF Core now. You need to override the OnModelCreating method and pass in an object of that entity type (as opposed to straight up Sql() statements/methods)
		protected override void OnModelCreating(ModelBuilder builder)//This method is called when the model for a derived context has been initialized, but before the model has been locked down and used to initialize the context. The default implementation of this method does nothing, but it can be overriden in a derived class such that the model can be further configured before it is locked down.
		{
			base.OnModelCreating(builder); //Not sure why that youtube tutorial had us remove the call to the base...

			builder.Entity<Player>().HasData(
					new Player()
					{
						Id = 1,
						Name = "Justin Fields",
						Position = "Quarterback",
						Age = 22,
						IsFreeAgent = false
					},
					new Player()
					{
						Id = 2,
						Name = "Roquan Smith",
						Position = "Middle Linebacker",
						Age = 25,
						IsFreeAgent = false
					},
					new Player()
					{
						Id = 3,
						Name = "Byron Murphy",
						Position = "Cornerback",
						Age = 29,
						IsFreeAgent = false
					},
					new Player()
					{
						Id = 4,
						Name = "Aaron Donald",
						Position = "Defensive Tackle",
						Age = 30,
						IsFreeAgent = false
					},
					new Player()
					{
						Id = 5,
						Name = "Cooper Kupp",
						Position = "Wide Receiver",
						Age = 26,
						IsFreeAgent = false
					},
					new Player()
					{
						Id = 6,
						Name = "Austin Ekeler",
						Position = "Runningback",
						Age = 27,
						IsFreeAgent = false
					},
					new Player()
					{
						Id = 7,
						Name = "Fred Warner",
						Position = "Middle Linebacker",
						Age = 25,
						IsFreeAgent = false
					},
					new Player()
					{
						Id = 8,
						Name = "J.J. Watt",
						Position = "Outside Linebacker",
						Age = 27,
						IsFreeAgent = false
					},
					new Player()
					{
						Id = 9,
						Name = "Nick Bosa",
						Position = "Defensive End",
						Age = 28,
						IsFreeAgent = false
					},
					new Player()
					{
						Id = 10,
						Name = "Jamaal Adams",
						Position = "Free Safety",
						Age = 28,
						IsFreeAgent = false
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
						Name = "Chiefs",
						Division = "West",
						Conference = "AFC",
						Stadium = "Arrowhead",
						City = "Kansas City"
					},
					new Team()
					{
						Id = 3,
						Name = "Buccaneers",
						Division = "South",
						Conference = "NFC",
						Stadium = "Raymond James",
						City = "Tampa Bay"
					},
					new Team()
					{
						Id = 4,
						Name = "Patriots",
						Division = "East",
						Conference = "AFC",
						Stadium = "Gillette Stadium",
						City = "Boston"
					},
					new Team()
					{
						Id = 5,
						Name = "Bengals",
						Division = "North",
						Conference = "AFC",
						Stadium = "Paul Brown Stadium",
						City = "Cincinnati"
					},
					new Team()
					{
						Id = 6,
						Name = "Titans",
						Division = "South",
						Conference = "AFC",
						Stadium = "Nissan Stadium",
						City = "Nashville"
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
		}
	}
}
