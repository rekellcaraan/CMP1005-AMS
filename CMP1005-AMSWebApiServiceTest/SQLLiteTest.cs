using System;
using Microsoft.Data.Sqlite;
using AMSLibrary.Models;
using CMP1005_AMSApiService.Data;
using Microsoft.EntityFrameworkCore;

namespace CMP1005_AMSWebApiServiceTest;
public class AMSSQLLite : IDisposable
{
    private const string InMemoryConnectionString = "DataSource=:memory:";
    private readonly SqliteConnection _connection;

    public AMSDBContext Context { get; set; }

    public AMSSQLLite()
    {
        _connection = new SqliteConnection(InMemoryConnectionString);
        _connection.Open();
        var options = new DbContextOptionsBuilder<AMSDBContext>()
        .UseSqlite(_connection)
        .Options;
        Context = new AMSDBContext(options);
        Context.Database.EnsureCreated();
    }

    public void Dispose()
    {
        _connection.Close();
    }
}

