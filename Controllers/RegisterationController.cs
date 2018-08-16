
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
    public class RegisterirationDataController : Controller
    {

        private RegisterirationContext _registerationDBConnection = new RegisterirationContext();
 
        private static uint regID {get; set;} = 0;

        [HttpGet("[action]")]
        public async Task<IEnumerable<Registeriration>> Registerirations(){

            var registerations = await _registerationDBConnection.Registerirations.ToListAsync();
            
            return registerations;

        }
        [HttpPost]
        [Route("CreateRegisteration")]
        public async Task<IActionResult> CreateRegisteration([FromBody] Registeriration insertion){


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