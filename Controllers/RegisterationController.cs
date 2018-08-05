
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using apoptoosi.models;

namespace apoptoosi.Controllers
{
    [Route("api/[controller]")]
    public class RegisterirationDataController : Controller
    {

        private RegisterirationContext _registerationDBConnection = new RegisterirationContext();

        [HttpGet("[action]")]
        public async Task<IEnumerable<Registeriration>> Registerirations(){

            var registerations = await _registerationDBConnection.Registerirations.ToListAsync();
            
            return registerations;

            var registree = new Registeriration{
                name = "Hello", 
                group = "World", 
                alcohol = false, 
                text = "Apoptoosi"
            };

            return new Registeriration[] { registree };

        }
        [HttpPost]
        public async Task<IActionResult> CreateRegisteration(Registeriration insertion){



            var result = await _registerationDBConnection.Registerirations.AddAsync(insertion);
            var ret = await _registerationDBConnection.Registerirations.SaveChanges();

            return NoContent();

        }
    }
}