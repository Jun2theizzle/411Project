namespace FreeTime.Migrations
{
    using FreeTime.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FreeTime.Models.ClassCloudContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(FreeTime.Models.ClassCloudContext context)
        {
            context.Courses.AddOrUpdate(new Course(30109, "CS 411"));
            context.Courses.AddOrUpdate(new Course(29942, "ECE 411"));
            context.Courses.AddOrUpdate(new Course(29937, "ECE 391"));
            context.SaveChanges();

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
        }
    }
}
