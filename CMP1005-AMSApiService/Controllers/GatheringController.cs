using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AMSLibrary.Models;

namespace CMP1005_AMSApiService.Controllers
{
    [Route("ams/[controller]")]
    [ApiController]
    public class GatheringController : ControllerBase
    {
        // GET: ams/Attendance
        [HttpGet]
        public async Task<ActionResult<Gathering>> GetAllAvailableGatherings()
        {
            await Task.Delay(0);

            return NotFound();
        }

        // POST: ams/Attendance
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: ams/Attendance/11
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Attendance/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
