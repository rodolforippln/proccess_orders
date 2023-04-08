using ApiCatalogo.Context;
using ApiCatalogo.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiCatalogo.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class VolumeController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] Volume volume, [FromServices] AppDbContext db)
        {
            var result = await db.Volumes.AddAsync(volume);
            await db.SaveChangesAsync();            

            return Created($"/volumes/{volume.VolumeId}", volume);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromServices] AppDbContext db)
        {
            var volumes = await db.Volumes.ToListAsync();
            return Ok(volumes);
        }
    }
}
