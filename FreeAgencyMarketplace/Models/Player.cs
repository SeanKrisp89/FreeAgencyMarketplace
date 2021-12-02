using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FreeAgencyMarketplace.Models
{
	public class Player
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "Please enter the player's name")]
		public string Name { get; set; }
		[Required(ErrorMessage = "Please select a position for this player")]
		[Display(Name = "Position")]
		public int PositionId { get; set; }
		public Position Position { get; set; }
		[Required(ErrorMessage = "Age must be between 21 and 44")]
		[Range(21, 44)]
		public int Age { get; set; }
		public bool IsFreeAgent { get; set; }
		[Required(ErrorMessage = "Please select a team for this player")]
		[Display(Name="Team")]
		public int TeamId { get; set; }
		public Team Team { get; set; }

	}
}
