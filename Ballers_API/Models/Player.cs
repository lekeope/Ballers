using System;
namespace Ballers_API.Models
{
	public class Player
	{
		public int id { get; set; }
		public string? firstName { get; set; }
		public string? lastName { get; set; }
		public DateTime dateOfBirth { get; set; } 
	}
}