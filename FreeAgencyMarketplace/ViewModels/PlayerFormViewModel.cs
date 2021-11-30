using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeAgencyMarketplace.Models;

namespace FreeAgencyMarketplace.ViewModels
{
	public class PlayerFormViewModel
	{
		public IEnumerable<Team> Teams { get; set; }
		public Player Player { get; set; }
	}
}
