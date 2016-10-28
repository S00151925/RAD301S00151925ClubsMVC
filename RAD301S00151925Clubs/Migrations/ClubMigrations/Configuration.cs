namespace RAD301S00151925Clubs.Migrations.ClubMigrations
{
    using Models.ClubModel;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RAD301S00151925Clubs.Models.ClubModel.ClubModeldbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\ClubMigrations";
        }

        protected override void Seed(RAD301S00151925Clubs.Models.ClubModel.ClubModeldbContext context)
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

            context.Clubs.AddOrUpdate(c => c.ClubName, new Club { ClubName = "Football" });
            context.Clubs.AddOrUpdate(c => c.ClubName, new Club { ClubName = "Games" });
        }
    }
}
