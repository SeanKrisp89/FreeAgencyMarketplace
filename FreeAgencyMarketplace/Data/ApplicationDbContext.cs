using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using FreeAgencyMarketplace.Models;

namespace FreeAgencyMarketplace.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		//So in .NET Core MVC, we need to add our models to the ApplicationDbContext.cs file in order to generate the DB (just like in our .NET Framework tutorial)
		public DbSet<Player> Players { get; set; }
		public DbSet<Team> Teams { get; set; }
		public DbSet<Contract> Contracts { get; set; }

		//So apparently this is how you seed your database with EF Core now. You need to override the OnModelCreating method and pass in an object of that entity type (as opposed to straight up Sql 
		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder.Entity<Player>().HasData(
					new Player()
					{
						Id = 1,
						Name = "Justin Fields",
						Position = "Quarterback",
						Age = 22,
						IsFreeAgent = false
					}
				);
		}
	}
}
