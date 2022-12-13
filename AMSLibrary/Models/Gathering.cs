using System;
using System.ComponentModel.DataAnnotations;

namespace AMSLibrary.Models;

public class Gathering
{
    public Guid Id { get; set; }

    [Required]
    public DateTime GatheringDate { get; set; }

    [Required]
    public String? GatheringLabel { get; set; }

    public int AttendeesCount { get; set; }

    public Gathering()
    {
        Id = new Guid();
    }
}

