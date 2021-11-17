using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FreeAgencyMarketplace.Models
{
	public class Player
	{
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string Position { get; set; }
		[Required]
		public int Age { get; set; }
		public bool IsFreeAgent { get; set; }
	}
}
