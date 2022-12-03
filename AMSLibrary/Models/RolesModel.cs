using System;
namespace AMSLibrary.Models;

public class Roles
{
	// Role Type enumeration
	public enum RoleType
	{
		All, 
		Member,
		ElevatedMember,
		NonAdminMemberGroup,
		AdminMember
	}

	// The type of Role
	public RoleType Role { get; set; }
}

