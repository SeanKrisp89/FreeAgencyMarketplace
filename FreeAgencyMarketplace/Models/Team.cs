using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FreeAgencyMarketplace.Models
{
	public class Team
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "Please enter a team name")]
		public string Name { get; set; }
		[Required(ErrorMessage = "Please enter the team division")]
		public string Division { get; set; }
		[Required(ErrorMessage = "Please enter the team conference")]
		public string Conference { get; set; }
		[Required(ErrorMessage = "Please enter the team stadium")]
		public string Stadium { get; set; }
		[Required(ErrorMessage = "Please enter the team city")]
		public string City { get; set; }
		[Range(42, 53)]
		public byte? ActiveRosterCount { get; set; }

	}
}
