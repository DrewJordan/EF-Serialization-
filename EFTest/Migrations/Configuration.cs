using System.Collections.Generic;
using System.Text;

namespace EFTest.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EFTest.Entities.EFContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "EFTest.Entities.EFContext";
        }

        protected override void Seed(EFTest.Entities.EFContext context)
        {
            context.Entities.AddOrUpdate(e => e.ID, new MyDBEntity
            {
                Name = "Drew",
                SerializedData = (new MyEntity
                {
                    Name = "Drew",
                    Age = 32,
                    OtherData = "awesome",
                    BlaBlaList = new List<int> { 1,2,3}
                }).Serialize()
            });
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
