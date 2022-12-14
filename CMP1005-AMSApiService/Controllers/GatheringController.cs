using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AMSLibrary.Models;
using CMP1005_AMSApiService.Data;

namespace CMP1005_AMSApiService.Controllers
{
    [Route("ams/[controller]")]
    [ApiController]
    public class GatheringController : ControllerBase
    {
        private readonly AMSDBContext amsdb;

        public GatheringController(AMSDBContext dbContext)
        {
            amsdb = dbContext;
        }

        // GET: ams/Attendance
        [HttpGet]
        public async Task<ActionResult<Gathering>> GetAllAvailableGatherings()
        {
            await Task.Delay(0);

            return NotFound();
        }

        // POST: ams/Attendance
        [HttpPost]
        public void Post([FromBody] Gathering gathering)
        {

        }

        // PUT: ams/Attendance/11
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Gathering gathering)
        {
        }

        // DELETE: api/Attendance/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
        }
    }
}
