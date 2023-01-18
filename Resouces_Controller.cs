using System;
using Microsoft.AspNetCore.Mvc; // using Mvc


namespace CuratedAcademy.WebAPI.Controllers
{
    [ApiController]
    [Route("api/Resources")]
    public class Resources_Controller : ControllerBase
    {
        [HttpGet]
        public JsonResult Resource()
		{
			return new JsonResult(ResourcesData.Current.resources);
		}


        public JsonResult oneResources(int id)
        {
            return new JsonResult(ResourcesData.Current.resources.FirstOrDefault(c => c.id == id));
        }
        
    }
}

