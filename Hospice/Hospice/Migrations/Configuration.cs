namespace Hospice.Migrations
{
    using Hospice.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.Linq;
    using System.Text;

    internal sealed class Configuration : DbMigrationsConfiguration<Hospice.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Hospice.Models.ApplicationDbContext context)
        {
            //var roles = new List<Role> 
            //{ 
            //    new Role { roleName = "Volunteer"}, 
            //    new Role { roleName = "Board"}, 
            //    new Role { roleName = "Staff"}, 
            //    new Role { roleName = "Admin"}
            //};

            //roles.ForEach(d => context.Roles.AddOrUpdate(x => x.roleName, d));
            //context.SaveChanges();

            //var users = new List<Hospice.Models.User> 
            //{ 
                
            //    new Hospice.Models.User { FirstName = "Sam" , LastName = "Smith", DOB = DateTime.Parse("1955-09-01"), Phone = "2894079876" , PhoneExt = 2, Email = "test@test.com", RoleID = 2},
            //    new Hospice.Models.User { FirstName = "Sam" , LastName = "Smith", DOB = DateTime.Parse("1955-09-01"), Phone = "2894079876" , PhoneExt = 2, Email = "test@test.com", RoleID = 1},
            //    new Hospice.Models.User { FirstName = "Sam" , LastName = "Smith", DOB = DateTime.Parse("1955-09-01"), Phone = "2894079876" , PhoneExt = 2, Email = "test@test.com", RoleID = 2},
            //    new Hospice.Models.User { FirstName = "Sam" , LastName = "Smith", DOB = DateTime.Parse("1955-09-01"), Phone = "2894079876" , PhoneExt = 2, Email = "test@test.com", RoleID = 3},
            //    new Hospice.Models.User { FirstName = "Admin" , LastName = "Astrator", DOB = DateTime.Parse("1900-01-01"), Phone = "101010101010" , PhoneExt = 2, Email = "Admin@hospice.ca", RoleID = 4}
            //};

            //users.ForEach(d => context.Users.AddOrUpdate(x => x.Phone, d));
            //SaveChanges(context);

            //var subroles = new List<Hospice.Models.SubRole> 
            //{ 
            //    new Hospice.Models.SubRole { roleName = "Bereavement", RoleID = 0},
            //    new Hospice.Models.SubRole { roleName = "Community", RoleID = 0},
            //    new Hospice.Models.SubRole { roleName = "Day Hospice", RoleID = 0},
            //    new Hospice.Models.SubRole { roleName = "Residential", RoleID = 0},
            //    new Hospice.Models.SubRole { roleName = "Welcome Desk", RoleID = 0},
            //    new Hospice.Models.SubRole { roleName = "Event (non client)", RoleID = 0},
            //    new Hospice.Models.SubRole { roleName = "Admin (non client)", RoleID = 0},
            //    new Hospice.Models.SubRole { roleName = "New Volunteers", RoleID = 0},
            //    new Hospice.Models.SubRole { roleName = "Audit & Finance Committee", RoleID = 1},
            //    new Hospice.Models.SubRole { roleName = "Community Relations Committee", RoleID = 1},
            //    new Hospice.Models.SubRole { roleName = "Governance Committee", RoleID = 1},
            //    new Hospice.Models.SubRole { roleName = "Operations and Quality Improvement Committee", RoleID = 1},
            //    new Hospice.Models.SubRole { roleName = "New Board Members", RoleID = 1},
            //    new Hospice.Models.SubRole { roleName = "Leadership", RoleID = 2},
            //    new Hospice.Models.SubRole { roleName = "Admin", RoleID = 2},
            //    new Hospice.Models.SubRole { roleName = "Community", RoleID = 2},
            //    new Hospice.Models.SubRole { roleName = "Outreach", RoleID = 2},
            //    new Hospice.Models.SubRole { roleName = "Residential", RoleID = 2},
            //    new Hospice.Models.SubRole { roleName = "New Staff", RoleID = 2}
            //};

            //subroles.ForEach(d => context.SubRoles.AddOrUpdate(x => x.roleName, d));
            //SaveChanges(context);

            //var usersubroles = new List<Hospice.Models.UserSubRole> 
            //{ 
            //    new Hospice.Models.UserSubRole {UserID = 2, SubRoleID = 1},
            //    new Hospice.Models.UserSubRole {UserID = 2, SubRoleID = 2},
            //    new Hospice.Models.UserSubRole {UserID = 1, SubRoleID = 10},
            //    new Hospice.Models.UserSubRole {UserID = 3, SubRoleID = 10},
            //    new Hospice.Models.UserSubRole {UserID = 1, SubRoleID = 11},
            //    new Hospice.Models.UserSubRole {UserID = 4, SubRoleID = 17},
            //    new Hospice.Models.UserSubRole {UserID = 4, SubRoleID = 18}
            //};

            //users.ForEach(d => context.Users.AddOrUpdate(x => x.Phone, d));
            //SaveChanges(context);

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            //create Role admin if it does not exist
            if (!context.Roles.Any(r => r.Name == "Admin"))
            {
                var roleresult = roleManager.Create(new IdentityRole("Admin"));
            }

            //create role Board
            if (!context.Roles.Any(r => r.Name == "Board"))
            {
                var roleresult = roleManager.Create(new IdentityRole("Board"));
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
                Email = "admin@outlook.com",
                FName = "Amanda",
                LName = "Cage",
                PhoneNumber = "905-341-3222",
                DOB = new DateTime(1989,04,22)
            };


            //Create Staff
            var staffUser = new ApplicationUser
            {
                UserName = "staff@outlook.com",
                Email = "staff@outlook.com",
                FName = "Jay",
                LName = "Swanson",
                PhoneNumber = "905-341-3222",
                DOB = new DateTime(1990,05,23)
            };

            //Create Volunteer
            var volunteerUser = new ApplicationUser
            {
                UserName = "volunteer@outlook.com",
                Email = "volunteer@outlook.com",
                FName = "Erika",
                LName = "Meele",
                PhoneNumber = "905-341-3222",
                DOB = DateTime.Today
            };


            //Create admin account account and add to admin role
            if (!context.Users.Any(u => u.Email == adminUser.UserName))
            {
                manager.Create(adminUser, "password");
                manager.AddToRole(adminUser.Id, "Admin");
            }

            //Create Staff account and add to staff role
            if (!context.Users.Any(u => u.Email == staffUser.UserName))
            {
                manager.Create(staffUser, "password");
                manager.AddToRole(staffUser.Id, "Staff");
            }

            //create volunteer user and add to Vounteer role
            if (!context.Users.Any(u => u.Email == volunteerUser.UserName))
            {
                manager.Create(volunteerUser, "password");
                manager.AddToRole(volunteerUser.Id, "Admin");
            }
        }

        //Added by Andrei leave this function it outputs any validation errors we have into the nuget output. just
        //cahnge context.SaveChanges() to SaveChanges(context) for debugging
        /// <summary>
        /// Wrapper for SaveChanges adding the Validation Messages to the generated exception
        /// </summary>
        /// <param name="context">The context.</param>
        private void SaveChanges(DbContext context)
        {
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                StringBuilder sb = new StringBuilder();

                foreach (var failure in ex.EntityValidationErrors)
                {
                    sb.AppendFormat("{0} failed validation\n", failure.Entry.Entity.GetType());
                    foreach (var error in failure.ValidationErrors)
                    {
                        sb.AppendFormat("- {0} : {1}", error.PropertyName, error.ErrorMessage);
                        sb.AppendLine();
                    }
                }

                throw new DbEntityValidationException(
                    "Entity Validation Failed - errors follow:\n" +
                    sb.ToString(), ex
                ); // Add the original exception as the innerException
            }
        }
    }
}
