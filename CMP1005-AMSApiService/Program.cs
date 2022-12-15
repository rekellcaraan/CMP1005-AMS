using AMSLibrary.Models;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using CMP1005_AMSApiService.Data;
using Microsoft.Extensions.Options;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

//if (builder.Environment.IsDevelopment())
//{
var connectionString = builder.Configuration.GetConnectionString("AMSQLLiteDB") ?? "Data Source=AMSQLLiteDB.db";
builder.Services.AddSqlite<AMSDBContext>(connectionString);
//}
//else
//{
//builder.Services.AddDbContext<AMSDBContext>(options =>
//        options.UseSqlServer(builder.Configuration.GetConnectionString("AZURE_SQL_CONNECTIONSTRING")));

//builder.Services.AddDbContext<AMSDBContext>(options =>
//        options.UseSqlServer(builder.Configuration.GetConnectionString("SQLAMSDB")));
//options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection")));
//}

builder.Services.AddControllers();

builder.Services.AddSwaggerGen();

builder.Services.AddTransient<AMSDBContext>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

