using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RocketApi.Models;
namespace RocketApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly RocketElevatorContext _context;
        public CustomerController(RocketElevatorContext context) => _context = context;

        // gets all the customers.
        [HttpGet]
        public async Task<IActionResult> GetCustomers()
        {
            var customers = await _context.Customers.ToListAsync();
            return Ok(customers);
        }

        [HttpGet("/customerobj/{email}")]
        public IActionResult GetCustomerObject(string email)
        {
            var customers = _context.Customers.Where(c => c.Email == email);
            return Ok(customers);
        }

        //gives building address
        [HttpGet("/buildingaddress/{id}")]// customer id
        public IActionResult GetCustomerBuildingAddress(long id)
        {
            var customerBuildings = _context.Buildings.Where(b => b.CustomerId == id);
            List<string> customerBuildingAddress = new List<string>();
            foreach (var item in customerBuildings)
            {
                customerBuildingAddress.Add(item.AddressOfBuilding);
            }
            return Ok(customerBuildingAddress);
        }
    }
}