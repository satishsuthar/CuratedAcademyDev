using System;
// model
namespace CuratedAcademy.WebAPI.Models
{
	//pakages
	public class Pakages
	{
		public int id { get; set; }
		public string name { get; set; } = string.Empty;
		public string? description { get; set; }
		
	}
	// curators
	public class Curators
	{
		public int id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string UserName { get; set; } = string.Empty;
		public string PreferredName { get; set; } = string.Empty;
		public string Emailaddress { get; set; } = string.Empty;

	}
	// resources
	public class Resources
	{
		public int id { get; set; }
		public string BlogVedios { get; set; } = string.Empty;
		public string Vediolinks { get; set; } = string.Empty;
	}
}

