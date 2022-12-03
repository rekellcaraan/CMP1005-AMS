using System;
namespace AMSLibrary.Models;

public class Attendee
{
	// Last name of the Attendee
	public string? LastName { get; set; }

	// First name of the Attendee
	public string? FirstName { get; set; }

	// Role of the Attendee
	public Roles.RoleType Role { get; set; }

	// Email (e.g. Gmail)
	public string? Email { get; set; }

	// Phonenumber of the Attendee
	public string? PhoneNumber { get; set; }

	// Address of the Attendee
	public string? Address { get; set; }

	// Time of entry of the Attendee in the gathering/meeting
	public string? TimeOfEntry { get; set; }
}

