﻿using System;
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
		[Required(ErrorMessage = "Please enter the player's name.")]
		public string Name { get; set; }
		[Required]
		public int PositionId { get; set; }
		public Position Position { get; set; }
		[Required]
		[Range(21, 44)]
		public int Age { get; set; }
		public bool IsFreeAgent { get; set; }
		[Display(Name="Team")]
		public int TeamId { get; set; }
		public Team Team { get; set; }

	}
}
