using AMSLibrary.Models;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using CMP1005_AMSApiService.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//var connectionString = builder.Configuration.GetConnectionString("AZURE_SQL_CONNECTIONSTRING");
//builder.Services.AddDbContext<AMSDBContext>(option => option.UseSqlServer(connectionString));

var connectionString = builder.Configuration.GetConnectionString("AMSQLLiteDB") ?? "Data Source=AMSQLLiteDB.db";
builder.Services.AddSqlite<AMSDBContext>(connectionString);

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

//AMSDBContext dbcontext = app.Services.GetRequiredService<AMSDBContext>();
//dbcontext.Database.EnsureCreated();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

