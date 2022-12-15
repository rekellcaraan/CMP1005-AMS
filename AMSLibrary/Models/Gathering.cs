using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AMSLibrary.Models;

public class Gathering
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    [Required]
    public DateTime GatheringDate { get; set; }

    [Required]
    public String? GatheringLabel { get; set; }

    public int AttendeesCount { get; set; }
}


