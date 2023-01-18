using System;
using Microsoft.AspNetCore.Mvc; // controller

namespace CuratedAcademy.WebAPI.Controllers
{
	[ApiController]
    [Route("api/Curator")]  // using the curator
    public class Curator_Controller : ControllerBase
	{
        [HttpGet]
        public JsonResult Curators()
        {
            return new JsonResult(CuratorData.Current.curators);
        }
        // get by the id
        [HttpGet("{id}")]
        public JsonResult OneCurators(int id)
        {
            return new JsonResult(CuratorData.Current.curators.FirstOrDefault(c => c.id == id));
        }

    }
}

