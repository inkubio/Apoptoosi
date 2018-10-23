
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using apoptoosi.models;
using System.IO;
using Microsoft.AspNetCore.Cors;

namespace apoptoosi.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowApoptoosiSite")]
    public class RegistrationDataController : Controller
    {

        private RegistrationContext _registrationDBConnection = new RegistrationContext();

        [HttpGet("[action]")]
        [EnableCors("AllowApoptoosiSite")]

        public async Task<IEnumerable< Registration>> Registrations(){

            var registrations = await _registrationDBConnection.Registrations.ToListAsync();
            
            return registrations;

        }
        [HttpPost]
        [Route("[action]")]
        [EnableCors("AllowApoptoosiSite")]
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