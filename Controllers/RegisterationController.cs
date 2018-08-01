
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

        private RegisterirationContext _registerationDBConnection = new RegisterirationContext();

        [HttpGet("[action]")]
        public IEnumerable<Registeriration> Registerirations(){

            var registerations = _registerationDBConnection.Registerirations.ToList();
            
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
        public NoContentResult CreateRegisteration(){

            return NoContent();

        }
    }
}