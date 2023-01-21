using System;
using CuratedAcademy.WebAPI.Models; // data storage
using static CuratedAcademy.WebAPI.Models.PointofInterestDto;

namespace CuratedAcademy.WebAPI
{
	public class PakagesData
	{
		public List<Pakages> content_Qurators { get; set; }
		public static PakagesData Current { get; } = new PakagesData();  // new instance

		public PakagesData()
		{
			content_Qurators = new List<Pakages>()
			{
				new Pakages()
				{
					id = 1,
					name = "Vineet Rai",
					description = " I want to create the content on musical instruments",

                    PointofInterest_pakages = new List<PointofinterestDto_Pakages>()
					{
						new PointofinterestDto_Pakages()
						{
							Id = 1,
							Name = "Rama",
							Description = " I want to create the content on piano instrumets"
						},

                        new PointofinterestDto_Pakages()
                        {
                            Id = 2,
                            Name = "Kailash",
                            Description = " I want to create the content on voilen instrumets"
                        }

                    }
				},
				new Pakages
                {
					id = 2,
					name = " Satish",
					description = " I want to create the content on the .net courses",

                    PointofInterest_pakages = new List<PointofinterestDto_Pakages>()
                    {
                        new PointofinterestDto_Pakages()
                        {
                            Id = 3,
                            Name = "Raju",
                            Description = " I want to create the content on guitar instrumets"
                        },

                        new PointofinterestDto_Pakages()
                        {
                            Id = 4,
                            Name = "Rajesh",
                            Description = " I want to create the content on other instrumets"
                        }

                    }

                },
				new Pakages
                {
					id = 3,
					name = " rajan",
					description = " I want to create the content for the java courses",

                    PointofInterest_pakages = new List<PointofinterestDto_Pakages>()
                    {
                        new PointofinterestDto_Pakages()
                        {
                            Id = 5,
                            Name = "sandeep",
                            Description = " I want to create the content on common instrumets"
                        },

                        new PointofinterestDto_Pakages()
                        {
                            Id = 6,
                            Name = "Tarun",
                            Description = " I want to create the content on non-silence instrumets"
                        }

                    }
                }

			};
		}
	}
	public class CuratorData
	{
		public List<Curators> curators { get; set; }
        public static CuratorData Current { get; } = new CuratorData();  // new instance


        public CuratorData()
		{
			curators = new List<Curators>()
			{
				new Curators()
				{
					id = 1,
					Name = " Vineet Rai",
					UserName = " RaiVineet",
					PreferredName = " Vinny",
					Emailaddress = " Vineetrai826@gmail.com"


				},
				new Curators
				{
                    id = 2,
                    Name = " Raja",
                    UserName = " raja Raj",
                    PreferredName = " rajesh",
                    Emailaddress = " Rajeshrai826@gmail.com"
                }

			};
		}
	}
	public class ResourcesData
	{
		public List<Resources> resources { get; set; }
        public static ResourcesData Current { get; } = new ResourcesData();  // new instance

        public ResourcesData()
		{
			resources = new List<Resources>()
			{
				 new Resources()
				 {
					id = 1,
					BlogVedios = "",
					Vediolinks = ""

				 },
				 new Resources
				 {
					 id = 2,
					 BlogVedios = "",
					 Vediolinks = ""
				 }
			};
		}
	}
}

