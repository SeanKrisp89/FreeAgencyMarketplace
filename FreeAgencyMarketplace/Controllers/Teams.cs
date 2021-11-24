using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeAgencyMarketplace.Models;
using FreeAgencyMarketplace.Data;

namespace FreeAgencyMarketplace.Controllers
{
	public class Teams : Controller
	{
		private ApplicationDbContext _context;

		public Teams()
		{
			_context = new ApplicationDbContext();
		}

		protected override void Dispose(bool disposing)
		{
			//base.Dispose(disposing); -- remember to compare this to the player controller which does not comment out the base.
			_context.Dispose();
		}

		public IActionResult Index()
		{
			////Hardcoded prior to use of DB
			//var teams = new List<Team>
			//{
			//	new Team {Name = "Bears", City = "Chicago", Stadium = "Soldier Field", Division = "North", Conference = "NFC", Id = 1},
			//	new Team {Name = "Saints", City = "New Orleans", Stadium = "Cesar Superdome", Division = "South", Conference = "NFC", Id = 2},
			//	new Team {Name = "Rams", City = "Los Angeles", Stadium = "SoFi Stadium", Division = "Wes3", Conference = "NFC", Id = 1},
			//	new Team {Name = "Eagles", City = "Philadelphia", Stadium = "Lincoln Financial", Division = "East", Conference = "NFC", Id = 4},
			//};

			var teams = _context.Teams.ToList();

			ViewBag.title = "Teams";

			return View(teams);
		}
	}
}
