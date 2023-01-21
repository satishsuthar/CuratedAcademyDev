using System;
using Microsoft.AspNetCore.Mvc;  // via using the mvc

namespace CuratedAcademy.WebAPI.Controllers
{
	[ApiController]
	[Route("api/pakages")]
	public class PackageController : ControllerBase
	{
		//[HttpGet("api/Pakages")]
		[HttpGet]  // will get all the pakages
		public JsonResult Pakages()
		{
			return new JsonResult(PakagesData.Current.content_Qurators); 
		}


		[HttpGet("{id}")]
		// will get the pakages by id
		public JsonResult OnePakage(int id)
		{
			return new JsonResult(
				PakagesData.Current.content_Qurators.FirstOrDefault(c => c.id == id)
				);
		}
		
	}
}

