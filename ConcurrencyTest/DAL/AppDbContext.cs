using ConcurrencyTest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ConcurrencyTest.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=MainConnectionString")
        {

        }

        public DbSet<City> Cities { get; set; }
        public DbSet<CityLog> CitiyLogs { get; set; }
    }
}