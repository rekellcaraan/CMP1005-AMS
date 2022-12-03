﻿using System;
using System.Data.Entity;
namespace AMSLibrary.Models;

public class Attendance
{
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

public interface IAttendance: IDisposable
{
	DbSet<Attendance>? Attendances { get; }
	int SaveChanges();
	void MarkAsModified(Attendance attendance);
}

public class AttendanceDBContext : DbContext, IAttendance
{
	public AttendanceDBContext() : base("name=AttendanceDBContext")
	{

	}

	public DbSet<Attendance>? Attendances { get; set; } = null;

    public void MarkAsModified(Attendance attendance)
    {
		Entry(attendance).State = EntityState.Modified;
    }
}
