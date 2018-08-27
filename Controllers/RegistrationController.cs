
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
    public class RegistrationDataController : Controller
    {

        private RegistrationContext _registrationDBConnection = new RegistrationContext();

        [HttpGet("[action]")]
        public async Task<IEnumerable< Registration>> Registrations(){

            var registrations = await _registrationDBConnection.Registrations.ToListAsync();
            
            return registrations;

        }
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateRegistration([FromBody]  Registration insertion){


            if (insertion.Validate()) {
                
                try
                {
                    var result = await _registrationDBConnection.Registrations.AddAsync(insertion);
                    var ret = await _registrationDBConnection.SaveChangesAsync();
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