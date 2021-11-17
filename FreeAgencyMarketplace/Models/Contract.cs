using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FreeAgencyMarketplace.Models
{
	public class Contract
	{
		public int Id { get; set; }
		public int Salary { get; set; }
		public int Years { get; set; }
		public int SigningBonus { get; set; }

	}
}
