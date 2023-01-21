using System;
using static CuratedAcademy.WebAPI.Models.PointofInterestDto;
// model
namespace CuratedAcademy.WebAPI.Models
{
	//pakages
	public class Pakages
	{
		public int id { get; set; }
		public string name { get; set; } = string.Empty;
        public string? description { get; set; }

		public int NumberofPointOfInterest_Pakages
		{
			get
			{
				return PointofInterest_pakages.Count;
			}
		}

        public ICollection<PointofinterestDto_Pakages> PointofInterest_pakages { get; set; } =
        new List<PointofinterestDto_Pakages>(); // creating the instance of Pakages 

    }
	// curators
	public class Curators
	{
        public int id { get; set; }
        public string Name { get; set; } = string.Empty;
		public string UserName { get; set; } = string.Empty;
		public string PreferredName { get; set; } = string.Empty;
		public string Emailaddress { get; set; } = string.Empty;

		public int NumberofPointOfInterest_curators
		{
			get
			{
				return PointofInterest_curators.Count;
			}
		}

        public ICollection<PointofInterest_Curators> PointofInterest_curators { get; set; } =
        new List<PointofInterest_Curators>(); // creating the instance of curators


    }
	// resources
	public class Resources
	{
		public int id { get; set; }
		public string BlogVedios { get; set; } = string.Empty;
		public string Vediolinks { get; set; } = string.Empty;
	}

	
	

}

