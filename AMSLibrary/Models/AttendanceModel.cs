using System;
using Microsoft.EntityFrameworkCore;
namespace AMSLibrary.Models;

public class Attendance
{
	public Guid Id { get; set; }

	// Gathering/Meeting Date and Time
	public DateTime GatheringDate { get; set; }

	// The label or title of the Gathering or Meeting
	public String? GatheringLabel { get; set; }

	// The schedule of the Gathering or Meeting
	public String? GatheringSchedule { get; set; }

	// The allowed roles that could enter this gathering/meeting
	public IEnumerable<Roles.RoleType>? AllowedRoles { get; set; }

	// The list of attendees
	public IEnumerable<Attendee>? Attendees { get; set; }
}

public class AttendanceDBContext : DbContext
{
	public AttendanceDBContext(DbContextOptions<AttendanceDBContext> options) : base(options) { }

	public DbSet<Attendance> Attendances { get; set; } = null!;
}

