using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BenchRockers.Models
{
    public class BenchRockersDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Person> Persons { get; set; }
    } 
}