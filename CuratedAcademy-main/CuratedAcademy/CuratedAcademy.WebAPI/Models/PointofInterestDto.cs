using System;
namespace CuratedAcademy.WebAPI.Models
{
	public class PointofInterestDto
	{
        //post requests for pakages
        public class PointofinterestDto_Pakages
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public string? Description { get; set; }
        }
        // post request for curators{
        public class PointofInterest_Curators
        {
            public int id { get; set; }
            public string Name { get; set; } = string.Empty;
            public string UserName { get; set; } = string.Empty;
            public string PreferredName { get; set; } = string.Empty;
            public string Emailaddress { get; set; } = string.Empty;


        }
    }
}

