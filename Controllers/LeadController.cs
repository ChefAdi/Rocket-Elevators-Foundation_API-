using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RocketApi;
using RocketApi.Models;
using System;
using System.Collections.Generic;

namespace RocketApi.Controllers{
    [Route("api/[controller]")]
    [ApiController]
    public class LeadController : ControllerBase{
        private readonly RocketElevatorContext _context;

        public LeadController(RocketElevatorContext context) => _context = context;
        
       
        
           [HttpGet]
            public async Task<IActionResult> GetLeads()
            // public String GetLeads()
        {
            DateTime days = DateTime.Now.AddDays(-30);
            DateTime today = DateTime.Now;
            bool bol = true;
            var customer = await _context.Customers.ToListAsync();
            List<string> customerEmail = new List<string>();
            for( int i = 0 ; i <customer.Count; i++ )
            {
                customerEmail.Add(customer[i].Email);
            }
            var lead = _context.Lead.Where(l =>  (bol != customerEmail.Contains(l.Email)));
            if (lead == null)
            {
                return NotFound();
            }
            return  Ok(lead);
            //return "hello world";
        }
     }
}