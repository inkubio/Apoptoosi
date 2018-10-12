
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


using apoptoosi.models;
using System.IO;

namespace apoptoosi.Controllers
{
    [Route("api/[controller]")]
    [EnadleCors(origins: "")]
    public class RegistrationDataController : Controller
    {

        private RegistrationContext _registerationDBConnection = new RegistrationContext();

        [HttpGet("[action]")]
        public async Task<IEnumerable< Registration>> Registerations(){

            var registrations = await _registerationDBConnection.Registerirations.ToListAsync();
            
            return registrations;

        }
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateRegisteration([FromBody]  Registration insertion){


            if (insertion.validate()) {
                
                try
                {
                    var result = await _registerationDBConnection.Registerirations.AddAsync(insertion);
                    var ret = await _registerationDBConnection.SaveChangesAsync();
                    return Ok();
                }
                catch (Exception e)
                {
                    return BadRequest();
                }
            }
            return BadRequest();
        }
    }
}