using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolokwium.Services;
using Microsoft.AspNetCore.Mvc;


namespace Kolokwium.Controllers
{
    [ApiController, Route("api/artists")]
    public class ArtistsController : ControllerBase
    {
        private readonly IArtistsDbService _service;
        public ArtistsController(IArtistsDbService service)
        {
            _service = service;
        }
        [HttpGet, Route("{id}")]
        public IActionResult GetArtist(int id)
        {
            var artRes = _service.GetArtist(id);
            if (artRes == null)
                return NotFound();
            return Ok(artRes);
        }
    }
}
