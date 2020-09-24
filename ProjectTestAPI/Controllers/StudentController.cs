using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjectTestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private List<string> names;

        public StudentController()
        {
            names = new List<string> { "BOb", "AA" };
        }


        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetStudents(int id)
        {  
            return Ok(names[id]);
        }

        [HttpPost("Create")]
        public async Task<ActionResult> Post( Student student) 
        { 
            // Oprettelse i Db
            // If fejl return bad request(....)
            //else OK
            return Ok(); 
        
        }
    }
}
