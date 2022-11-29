using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RocketApi.Models;

namespace ColumnApi.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ColumnController : ControllerBase
{
    private readonly RocketElevatorContext _context;

    public ColumnController(RocketElevatorContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Column>>> GetColumnItems()
    {
        return await _context.columns.ToListAsync();
    }

    private IActionResult View()
    {
        throw new NotImplementedException();
    }

    //GET: api/Column/5
    [HttpGet("{id}")]
    public async Task<ActionResult<string>> GetColumnStatus(int id)
    {
        var column = await _context.columns.FindAsync(id);
            if(column == null) 
            { 
                return NotFound(); 
            }else if (column.status == null)
            {
                return NotFound();
            }
            return column.status;
    }

     [HttpPut("{id}/{status}")]
        public async Task<ActionResult<Column>> UpdateColumnStatus([FromRoute] int id, [FromRoute] string status)
        {
            var column = await this._context.columns.FindAsync(id);

            if (column == null)
            {
                return NotFound();
            } 
            
            column.status = status;

            this._context.columns.Update(column);
            await this._context.SaveChangesAsync();

            return column;
        }
}


