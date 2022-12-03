using Microsoft.AspNetCore.Mvc;
using AMSLibrary.Models;
using CMP1005_AMSApiService.Data;
using Microsoft.EntityFrameworkCore;

namespace CMP1005_AMSApiService.Controllers;

[ApiController]
[Route("[controller]")]
public class AttendanceController : ControllerBase
{
    private readonly AttendanceDBContext dbContext;

    public AttendanceController(AttendanceDBContext dbContext)
    {
        this.dbContext = dbContext;
    }

    [HttpGet("AllAttendance")]
    public async Task<ActionResult<IEnumerable<Attendance>>> GetAllAttendance()
    {
        var list = await dbContext.Attendances.ToListAsync();

        if (list.Count > 0)
            return list;

        return NotFound();
    }
}

