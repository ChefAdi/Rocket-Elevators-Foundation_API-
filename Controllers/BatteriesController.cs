using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RocketApi.Models;

namespace batteriesApi.Controllers;

[ApiController]
[Route("api/[controller]")]

public class batteriesController : ControllerBase
{  
    private readonly RocketElevatorContext _context;

    public batteriesController(RocketElevatorContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<batteries>>> GetbatteriesItems()
    {
        return await _context.batteries.ToListAsync();
    }

    private IActionResult View()
    {
        throw new NotImplementedException();
    }

    // GET: api/batteries/5
    [HttpGet("{id}")]
    public async Task<ActionResult<String>> GetBatteries(int id)
    {
        var batteries = await _context.batteries.FindAsync(id);

            if (batteries == null)
            {
                return NotFound();
            }else if (batteries.status == null)
            {
                return NotFound();
            }

            return batteries.status;
    }
         [HttpPut("{id}/{status}")]
        public async Task<ActionResult<batteries>> UpdateBatteryStatus([FromRoute] int id, [FromRoute] string status)
        {
            var batteries = await this._context.batteries.FindAsync(id);

            if (batteries == null)
            {
                return NotFound();
            } 
            
            batteries.status = status;

            this._context.batteries.Update(batteries);
            await this._context.SaveChangesAsync();

            return batteries;
        }
}

   