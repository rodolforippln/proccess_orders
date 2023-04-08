using ApiCatalogo.Context;
using ApiCatalogo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiCatalogo.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class OrderController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Order order, [FromServices] AppDbContext db)
        {
            await db.Orders.AddAsync(order);
            await db.SaveChangesAsync();

            return Created($"/orders/{order.OrderId}", order);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromServices] AppDbContext db)
        {
            var orders = await db.Orders.ToListAsync();

            return Ok(orders);
        }
        
    }
}
