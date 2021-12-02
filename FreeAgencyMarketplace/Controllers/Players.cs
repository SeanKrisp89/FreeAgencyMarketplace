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

		public ActionResult Create()
		{
			//Need to load all the teams from Db in order to populate dropdown list
			var teams = _context.Teams.ToList();

			var positions = _context.Positions.ToList();

			//Pass in empty viewModel object for the form to populate and return (in the save method)
			var viewModel = new PlayerFormViewModel
			{
				Player = new Player(),
				Positions = positions,
				Teams = teams
			};

			ViewBag.title = "Add Player";

			return View("Create", viewModel);
		}

		[HttpPost]
		public ActionResult Save(Player player)
		{
			//check that model is valid
			if (!ModelState.IsValid)
			{
				//if not, instantiate new empty model and pass in to view
				var viewModel = new PlayerFormViewModel
				{
					Player = player,
					Teams = _context.Teams.ToList(),
					Positions = _context.Positions.ToList()
				};

				return View("Create", viewModel);
			}

			if(player.Id == 0) //New players will have an Id of zero since by default integers are initialized to zero (Player Id is an integer)
			{
				//So add to DbContext
				_context.Players.Add(player);
			}

			//eventually we'll need to add an else statement for an existing player. It'll be an existing player when we are EDITING a player.
			_context.SaveChanges();

			return RedirectToAction("Index", "Players");
		}
	}
}
