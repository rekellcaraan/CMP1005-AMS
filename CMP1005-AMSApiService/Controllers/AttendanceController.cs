using Microsoft.AspNetCore.Mvc;
using AMSLibrary.Models;
using CMP1005_AMSApiService.Data;

namespace CMP1005_AMSApiService.Controllers;

[ApiController]
[Route("[controller]")]
public class AttendanceController : ControllerBase
{
    [HttpGet]
    public void GetAllAvailableAttendance()
    {

    }
}

