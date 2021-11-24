using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeAgencyMarketplace.Models;
using FreeAgencyMarketplace.Data;

namespace FreeAgencyMarketplace.Controllers
{
	public class Players : Controller
	{
		private ApplicationDbContext _context;

		public Players()
		{
			_context = new ApplicationDbContext();
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
			_context.Dispose();
		}

		public IActionResult Index()
		{
			//Get all players from DB
			//var players = _context.Players.ToList();

			var players = new List<Player>
			{
				new Player{ Id = 1, Age = 25, IsFreeAgent = false, Name = "Roquan Smith", Position = "Middle Linebacker"},
				new Player{ Id = 2, Age = 23, IsFreeAgent = false, Name = "Darnell Mooney", Position = "Wide Receiver"},
				new Player{ Id = 3, Age = 22, IsFreeAgent = false, Name = "Justin Fields", Position = "Quarterback"}
			};

			ViewBag.title = "Players";

			return View(players);
		}
	}
}
