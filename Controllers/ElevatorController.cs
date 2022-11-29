using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RocketApi.Models;

namespace ElevatorApi.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ElevatorController : ControllerBase
{  
    private readonly RocketElevatorContext _context;

    public ElevatorController(RocketElevatorContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Elevator>>> GetElevatorItems()
    {
        return await _context.elevators.ToListAsync();
    }

    private IActionResult View()
    {
        throw new NotImplementedException();
    }

    // GET: api/Elevator/5
    [HttpGet("{id}")]
    public async Task<ActionResult<String>> GetElevator(int id)
    {
        var elevator = await _context.elevators.FindAsync(id);

            if (elevator == null)
            {
                return NotFound();
            }else if (elevator.status == null)
            {
                return NotFound();
            }

            return elevator.status;
    }

     [HttpPut("{id}/{status}")]
        public async Task<ActionResult<Elevator>> UpdateElevatorStatus([FromRoute] int id, [FromRoute] string status)
        {
            var elevator = await this._context.elevators.FindAsync(id);

            if (elevator == null)
            {
                return NotFound();
            } 
            
            elevator.status = status;

            this._context.elevators.Update(elevator);
            await this._context.SaveChangesAsync();
            return elevator;
        }
    

}