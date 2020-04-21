using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TDApi.Models;

namespace TDApiTesting
{
    public static class DbContextMocker
    {
        public static FilmsContext GetWideWorldImportersDbContext(string dbName)
        {
            // Create options for DbContext instance
            var options = new DbContextOptionsBuilder<FilmsContext>()
                .UseInMemoryDatabase(databaseName: dbName)
                .Options;

            // Create instance of DbContext
            var dbContext = new FilmsContext(options);

            // Add entities in memory
            dbContext.Seed();

            return dbContext;
        }
    }
}
