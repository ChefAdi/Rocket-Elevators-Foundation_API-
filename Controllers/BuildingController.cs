// using Microsoft.AspNetCore.Mvc;
// using RocketApi;
// using Microsoft.EntityFrameworkCore;
// using RocketApi.Models;

// namespace RocketApi.Controllers{
//     [Route("api/[controller]")]
//     [ApiController]
//     public class BuildingController : ControllerBase{
//         private readonly RocketElevatorContext _context;
//         public BuildingController(RocketElevatorContext context) => _context = context;
//         [HttpGet]
//         public async Task<IActionResult> GetBuildingsWhoNeedIntervention() {
//             var buildings =  _context.Buildings.Where(b => b.Batteries.Any(bat => bat.Status == "Intervention" || bat.Columns
//             .Any(c => c.Status == "Intervention" || c.Elevators
//             .Any(e => e.Status == "Intervention"))));
//             return Ok(buildings);
//         }  
//     }
// }