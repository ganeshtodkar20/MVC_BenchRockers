namespace BenchRockers.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using BenchRockers.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<BenchRockers.Models.BenchRockersDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BenchRockers.Models.BenchRockersDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //


            var employees = new List<Employee>
            {
                new Employee { FirstName = "Carson",   LastName = "Alexander",Location="Pune",Role="Developer",TotalExp=5,Account="A"},
                    new Employee { FirstName = "Meredith",   LastName = "Alonso",Location="Pune",Role="DBA",TotalExp=5,Account="A"},
                    new Employee { FirstName = "Arturo",   LastName = "Anand",Location="Pune",Role="Developer",TotalExp=5,Account="A"},
                    new Employee { FirstName = "Gytis",   LastName = "Barzdukas",Location="Pune",Role="Designer",TotalExp=5,Account="A"},
                    new Employee { FirstName = "Ganesh",   LastName = "Todkar",Location="Pune",Role="Developer",TotalExp=5,Account="A"},
                    new Employee { FirstName = "James",   LastName = "Anderson",Location="Pune",Role="Admin",TotalExp=5,Account="A"},
            };
            employees.ForEach(s => context.Employees.AddOrUpdate(p => p.LastName, s));
            context.SaveChanges();


            var persons = new List<Person>
            {
                new Person { Name = "Ganesh",   EmailAddress="ganesh.todkar@gmail.com",Gender="Male"},
                new Person { Name = "Vinay",   EmailAddress="Vinay.todkar@gmail.com",Gender="Male"},
                new Person { Name = "Sushant",   EmailAddress="Sushant.todkar@gmail.com",Gender="Male"},
                new Person { Name = "Ashish",   EmailAddress="Ashish.todkar@gmail.com",Gender="Male"},
                new Person { Name = "Tushar",   EmailAddress="Tushar.todkar@gmail.com",Gender="Male"}
            };
            persons.ForEach(s => context.Persons.AddOrUpdate(p => p.Name, s));
            context.SaveChanges();
        }
    }
}
