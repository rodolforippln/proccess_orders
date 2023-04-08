using ApiCatalogo.Context;
using ApiCatalogo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiCatalogo.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CompanyController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Company model, [FromServices] AppDbContext db)
        {
            var company = await db.Companies.AddAsync(model);
            await db.SaveChangesAsync();

            if (company == null) return BadRequest("Erros não payload");

            return Created($"/companies/{model.CompanyId}", model);
        }

        [HttpGet]
        public async Task<IActionResult> GettAll([FromServices] AppDbContext db)
        {
            var companies = await db.Companies.ToListAsync();

            return Ok(companies);
        }          
    }
}
