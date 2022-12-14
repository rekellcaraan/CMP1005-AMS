using System;
using AMSLibrary.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace CMP1005_AMSApiService.Data;


public class AMSDBContext : DbContext
{
    public AMSDBContext(DbContextOptions<AMSDBContext> options) : base(options) { }

    public DbSet<Gathering> Gatherings { get; set; } = null!;
}

