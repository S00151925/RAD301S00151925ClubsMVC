namespace RAD301S00151925Clubs.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RAD301S00151925Clubs.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RAD301S00151925Clubs.Models.ApplicationDbContext context)
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

            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            roleManager.Create(new IdentityRole { Name = "Admin" });
            roleManager.Create(new IdentityRole { Name = "ClubAdmin" });
            roleManager.Create(new IdentityRole { Name = "Member" });

            //manager.Create(new ApplicationUser
            context.Users.AddOrUpdate(u => u.Email, new ApplicationUser
            {
                StudentID = "s1234567",
                Email = "rad301S00151925@outlook.com",
                joinDate = DateTime.Now,
                UserName = "rad301S00151925@outlook.com",
                PasswordHash = new PasswordHasher().HashPassword("Ss-RAD301"),
                SecurityStamp = Guid.NewGuid().ToString()
            });

            context.Users.AddOrUpdate(u => u.Email, new ApplicationUser
            {
                StudentID = "s00151925",
                Email = "dazza-king@hotmail.com",
                joinDate = DateTime.Now,
                UserName = "dazza-king@hotmail.com",
                PasswordHash = new PasswordHasher().HashPassword("Ss-00151925"),
                SecurityStamp = Guid.NewGuid().ToString()
            });

            context.Users.AddOrUpdate(u => u.Email, new ApplicationUser
            {
                StudentID = "s00123456",
                Email = "s00123456@mail.itsligo.ie",
                joinDate = DateTime.Now,
                UserName = "s00123456@mail.itsligo.ie",
                PasswordHash = new PasswordHasher().HashPassword("Ss-00123456"),
                SecurityStamp = Guid.NewGuid().ToString()
            });

            ApplicationUser admin = manager.FindByEmail("dazza-king@hotmail.com");
            if (admin != null)
                manager.AddToRoles(admin.Id, new string[] { "Admin", "ClubAdmin", "Member" });

            ApplicationUser member = manager.FindByEmail("dazza-king@hotmail.com");
            if (manager.FindByEmail("dazza-king@hotmail.com") != null)
                manager.AddToRoles(member.Id, new string[] { "Member" });

            ApplicationUser clubAdmin = manager.FindByEmail("dazza-king@hotmail.com");
            if (manager.FindByEmail("dazza-king@hotmail.com") != null)
                manager.AddToRoles(clubAdmin.Id, new string[] { "ClubAdmin" });
        }
    }
}
