using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using apoptoosi.Models;
using Microsoft.AspNetCore.Cors;

namespace apoptoosi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowApoptoosiSite")]
    public class ShirtOrdersController : ControllerBase
    {
        private readonly ShirtOrderContext _context = new ShirtOrderContext();

        // GET: api/ShirtOrders
        [HttpGet]
        public IEnumerable<ShirtOrder> GetShirtOrders()
        {
            return _context.ShirtOrders;
        }

        // POST: api/ShirtOrders
        [HttpPost]
        public async Task<IActionResult> PostShirtOrder([FromBody] ShirtOrder shirtOrder)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ShirtOrders.Add(shirtOrder);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetShirtOrder", new { id = shirtOrder.ShirtOrderID }, shirtOrder);
        }

    }
}