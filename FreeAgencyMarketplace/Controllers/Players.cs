using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeAgencyMarketplace.Models;
using FreeAgencyMarketplace.Data;
using FreeAgencyMarketplace.ViewModels;

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
			////Hardcoded prior to use of DB
			//var players = new List<Player>
			//{
			//	new Player{ Id = 1, Age = 25, IsFreeAgent = false, Name = "Roquan Smith", Position = "Middle Linebacker"},
			//	new Player{ Id = 2, Age = 23, IsFreeAgent = false, Name = "Darnell Mooney", Position = "Wide Receiver"},
			//	new Player{ Id = 3, Age = 22, IsFreeAgent = false, Name = "Justin Fields", Position = "Quarterback"}
			//};

			var players = _context.Players.Include(p => p.Team).ToList();

			ViewBag.title = "Players";

			return View(players);
		}

		public IActionResult Details(int id)
		{
			//Get player from Db along with Team data
			var player = _context.Players.Include(p => p.Team).SingleOrDefault(p => p.Id == id);

			return View(player);
		}

		public IActionResult Create()
		{
			//Need to load all the teams from Db in order to populate dropdown list
			var teams = _context.Teams.ToList();

			//Pass in empty viewModel object for the form to populate and return (in the save method)
			var viewModel = new PlayerFormViewModel
			{
				Player = new Player(),
				Teams = teams
			};

			ViewBag.title = "Add Player";

			return View("Create", viewModel);
		}
	}
}
