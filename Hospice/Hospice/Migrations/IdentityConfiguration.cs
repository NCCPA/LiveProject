namespace Hospice.Migrations
{
    using Hospice.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class IdentityConfiguration : DbMigrationsConfiguration<Hospice.Models.ApplicationDbContext>
    {
        public IdentityConfiguration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Hospice.Models.ApplicationDbContext context)
        {
            //Admin role
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            //create Role admin if it does not exist
            if (!context.Roles.Any(r => r.Name == "Admin"))
            {
                var roleresult = roleManager.Create(new IdentityRole("Admin"));
            }

            //create role Staff
            if (!context.Roles.Any(r => r.Name == "Staff"))
            {
                var roleresult = roleManager.Create(new IdentityRole("Staff"));
            }

            //create role volunteer
            if (!context.Roles.Any(r => r.Name == "Volunteer"))
            {
                var roleresult = roleManager.Create(new IdentityRole("Volunteer"));
            }


            //Create a generic user
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            //Create admin user
            var adminUser = new ApplicationUser
            {
                UserName = "admin@outlook.com",
                Email = "admin@outlook.com"
            };


            //Create Staff
            var staffUser = new ApplicationUser
            {
                UserName = "staff@outlook.com",
                Email = "staff@outlook.com"
            };

            //Create Volunteer
            var volunteerUser = new ApplicationUser
            {
                UserName = "volunteer@outlook.com",
                Email = "volunteer@outlook.com"
            };


            //Create admin account account and add to admin role
            if (!context.Users.Any(u => u.UserName == adminUser.UserName))
            {
                manager.Create(adminUser, "password");
                manager.AddToRole(adminUser.Id, "Admin");
            }

            //Create Staff account and add to staff role
            if (!context.Users.Any(u => u.UserName == staffUser.UserName))
            {
                manager.Create(staffUser, "password");
                manager.AddToRole(staffUser.Id, "Staff");
            }

            //create volunteer user and add to Vounteer role
            if (!context.Users.Any(u => u.UserName == volunteerUser.UserName))
            {
                manager.Create(volunteerUser, "password");
                manager.AddToRole(volunteerUser.Id, "Admin");
            }
        }
    }
}
