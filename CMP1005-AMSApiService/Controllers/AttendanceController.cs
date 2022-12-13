using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AMSLibrary.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CMP1005_AMSApiService.Controllers;

[Route("[controller]")]
public class AttendanceController : ControllerBase
{
    private readonly IAttendanceDBContext attendanceDBContext = new AttendanceDBContext();

    public AttendanceController()
    {

    }

    public AttendanceController(IAttendanceDBContext dbContext)
    {
        attendanceDBContext = dbContext;
    }

    // GET: api/values
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/values
    [HttpPost]
    public void Post([FromBody]Attendance attendance)
    {
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody]Attendance attendance)
    {
        attendanceDBContext.MarkAsModified(attendance);
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}

