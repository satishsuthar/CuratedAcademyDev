using System;
using System.ComponentModel.DataAnnotations;
namespace CuratedAcademy.WebAPI.Models
{
	// separate data store for getting the inputs
	public class PointofInterestForCreatingDto
	{
		// adding anotations
		[Required]
		[MaxLength(50)]
		public string Name { get; set; } = string.Empty;
		[MaxLength(50)]
		public string? Description { get; set; }
	}
}

