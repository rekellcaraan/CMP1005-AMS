using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AMSLibrary.Models;
using CMP1005_AMSApiService.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Microsoft.EntityFrameworkCore;

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

        // GET: ams/Gathering
        [HttpGet]
        public List<Gathering> GetAllAvailableGatherings()
        {
            return amsdb.Gatherings.ToList();
        }


        // POST: ams/Gathering
        [HttpPost]
        public void Post([FromBody] Gathering gathering)
        {
            amsdb.Gatherings.Add(gathering);
            amsdb.SaveChanges();
        }

        // PUT: ams/Gathering/11
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Gathering gathering)
        {
            if (id == gathering.Id)
            {
                try
                {
                    amsdb.SaveChanges();
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateConcurrencyException)
                {
                    // TODO: return NotFound or throw
                }
            }
        }

        // DELETE: api/Gathering/2
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var gathering = amsdb.Gatherings.Find(id);
            if (gathering != null)
            {
                amsdb.Gatherings.Remove(gathering);
                amsdb.SaveChanges();
            }
        }
    }
}
