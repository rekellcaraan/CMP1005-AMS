using System;
using Microsoft.EntityFrameworkCore;
using AMSLibrary.Models;

namespace CMP1005_AMSApiService.Data;

public class AttendanceDBContext: DbContext
{
	public AttendanceDBContext(DbContextOptions<AttendanceDBContext> options)
		: base(options) { }

	public DbSet<Attendance> Attendances { get; set; } = null!;
}

