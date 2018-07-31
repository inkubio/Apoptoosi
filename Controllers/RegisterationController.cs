
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using apoptoosi.models;

namespace apoptoosi.Controllers
{
    [Route("api/[controller]")]
    public class RegisterirationDataController : Controller
    {

        [HttpGet("[action]")]
        public IEnumerable<Registeriration> Registerirations(){

            var registree = new Registeriration{
                name = "Hello", 
                group = "World", 
                alcohol = false, 
                text = "Apoptoosi"
            };

            return new Registeriration[] { registree };

        }
        [HttpPost]
        public IActionResult CreateRegisteration(){

            return NoContent();

        }
    }
}