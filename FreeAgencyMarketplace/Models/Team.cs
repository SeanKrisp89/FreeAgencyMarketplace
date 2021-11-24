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
		[Required]
		public string Name { get; set; }
		[Required]
		public string Division { get; set; }
		[Required]
		public string Conference { get; set; }
		[Required]
		public string Stadium { get; set; }
		[Required]
		public string City { get; set; }

		public byte? ActiveRosterCount { get; set; }

	}
}
