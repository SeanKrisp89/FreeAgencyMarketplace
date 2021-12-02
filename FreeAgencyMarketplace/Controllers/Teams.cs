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
			var teams = _context.Teams.ToList();

			ViewBag.title = "Teams";

			return View(teams);
		}

		public IActionResult Details(int id)
		{
			var team = _context.Teams.SingleOrDefault(t => t.Id == id);

			return View(team);
		}

		public IActionResult Create()
		{
			var viewModel = new Team();

			ViewBag.title = "Add New Team";

			return View("Create", viewModel);
		}

		public IActionResult Save(Team team)
		{
			if (!ModelState.IsValid)
			{
				return RedirectToAction("Create", team);
			}

			if(team.Id == 0)
			{
				_context.Teams.Add(team);
			}

			_context.SaveChanges();

			return RedirectToAction("Index", "Teams");
		}
	}
}
