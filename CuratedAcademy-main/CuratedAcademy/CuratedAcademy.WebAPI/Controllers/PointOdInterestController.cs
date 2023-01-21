using System;
using CuratedAcademy.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using static CuratedAcademy.WebAPI.Models.PointofInterestDto;

namespace CuratedAcademy.WebAPI.Controllers
{
	[Route("api/pakages/{id}/pointofinterest_pakages")]
	[ApiController]

	public class PointOdInterestController : ControllerBase
	{ 

		[HttpGet]
		public ActionResult<IEnumerable<PointofInterestDto>> GetPointsOfInterest(int pakageId)
		{
			// IN CASE THE city id not exsits
			var Pakages = PakagesData.Current.content_Qurators.FirstOrDefault(c => c.id == pakageId);
			if( Pakages == null)
			{
				return NotFound();
			}

			return Ok(Pakages.PointofInterest_pakages);

			
		}
		[HttpGet("{pointofinterest_Pakage_id}" , Name = "GetPointofInterest")]
		public ActionResult<PointofInterestDto> GetPointsofinterest(int pakageId, int Pointofinterest_pakages)
		{
			var Pakages = PakagesData.Current.content_Qurators.FirstOrDefault(c => c.id == pakageId);
			// if unable to fing the id return error
			if( Pakages == null)
			{
				return NotFound();
			}

			// find the pakages
			var pointofinterest_pakages =
				Pakages.PointofInterest_pakages.FirstOrDefault
				(c => c.Id == Pointofinterest_pakages);
			if(pointofinterest_pakages == null)
			{
				return NotFound();
			}
			return Ok(pointofinterest_pakages);

        }

		//Post Request

		[HttpPost]
		public ActionResult<PointofInterestDto> CreatepointofInterest
			(int Pakageid, PointofInterestForCreatingDto pointofcreation)
		{
			var pakage = PakagesData.Current.content_Qurators.FirstOrDefault
				(c => c.id == Pakageid);
			if(pakage == null)
			{
				return NotFound();

			}

			// its a temporary -- needed to be changes - just for the demo
			var maxPointofinterestId =
				PakagesData.Current.content_Qurators.SelectMany
				(c => c.PointofInterest_pakages).Max(p => p.Id);

			var finalPointofinterest = new PointofinterestDto_Pakages()
			{
				Id = ++maxPointofinterestId,
				Name = pointofcreation.Name,
				Description = pointofcreation.Description



            };
			pakage.PointofInterest_pakages.Add(finalPointofinterest);

			return CreatedAtRoute("GetPointofInterest" ,
				new
				{
					Pakageid = Pakageid,
                    pointofcreation = finalPointofinterest.Id

                },
				finalPointofinterest
				
				);
		}
		// Put request
		[HttpPut("pointofinterestid")]
		public ActionResult UpdatePointOfInterest
			( int PakageId, int pointofInterestId, PointofinterestForUpdateDto pointofinterest)
		{
            var pakage = PakagesData.Current.content_Qurators.FirstOrDefault
                (c => c.id == PakageId);
            if (pakage == null)
            {
                return NotFound();

            }
			// for put we need to change the whole thing
			pakage.name = pointofinterest.Name;
			pakage.description = pointofinterest.Description;

			return NoContent();

        }
		
		// delete point of interest
		[HttpDelete("{pointOfInterestId}")]
		
		public ActionResult DeletePointOfInterest( int PakageId ,
			int pointofinterestId)
		{
			//   to check whether the Pakages Id exits or not ( valid)
            var pakage = PakagesData.Current.content_Qurators.FirstOrDefault
                (c => c.id == PakageId);
            if (pakage == null)
            {
                return NotFound();

            }

			var pointofInterestfromstore = pakage.PointofInterest_pakages
				.FirstOrDefault(c => c.Id == pakage.id);
			if(pointofInterestfromstore == null)
			{

				return NotFound();
			}
			pakage.PointofInterest_pakages.Remove(pointofInterestfromstore);
			return NoContent();

        }
		
	}
}

