namespace Hospice.Migrations
{
    using Hospice.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.Linq;
    using System.Text;

    internal sealed class Configuration : DbMigrationsConfiguration<Hospice.DAL.HospiceEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Hospice.DAL.HospiceEntities context)
        {

            var roles = new List<Role> 
            { 
                new Role { roleName = "Volunteer"}, 
                new Role { roleName = "Board"}, 
                new Role { roleName = "Staff"}, 
                new Role { roleName = "Admin"}
            };

            roles.ForEach(d => context.Roles.AddOrUpdate(x => x.roleName, d));
            context.SaveChanges();

            var users = new List<Hospice.Models.User> 
            { 
                
                new Hospice.Models.User { FirstName = "Sam" , LastName = "Smith", DOB = DateTime.Parse("1955-09-01"), Phone = "2894079876" , PhoneExt = 2, Email = "test@test.com", RoleID = 2},
                new Hospice.Models.User { FirstName = "Sam" , LastName = "Smith", DOB = DateTime.Parse("1955-09-01"), Phone = "2894079876" , PhoneExt = 2, Email = "test@test.com", RoleID = 1},
                new Hospice.Models.User { FirstName = "Sam" , LastName = "Smith", DOB = DateTime.Parse("1955-09-01"), Phone = "2894079876" , PhoneExt = 2, Email = "test@test.com", RoleID = 2},
                new Hospice.Models.User { FirstName = "Sam" , LastName = "Smith", DOB = DateTime.Parse("1955-09-01"), Phone = "2894079876" , PhoneExt = 2, Email = "test@test.com", RoleID = 3},
                new Hospice.Models.User { FirstName = "Admin" , LastName = "Astrator", DOB = DateTime.Parse("1900-01-01"), Phone = "101010101010" , PhoneExt = 0, Email = "Admin@hospice.ca", RoleID = 4}
            };

            users.ForEach(d => context.Users.AddOrUpdate(x => x.Phone, d));
            SaveChanges(context);

            var subroles = new List<Hospice.Models.SubRole> 
            { 
                new Hospice.Models.SubRole { roleName = "Bereavement", RoleID = 0},
                new Hospice.Models.SubRole { roleName = "Community", RoleID = 0},
                new Hospice.Models.SubRole { roleName = "Day Hospice", RoleID = 0},
                new Hospice.Models.SubRole { roleName = "Residential", RoleID = 0},
                new Hospice.Models.SubRole { roleName = "Welcome Desk", RoleID = 0},
                new Hospice.Models.SubRole { roleName = "Event (non client)", RoleID = 0},
                new Hospice.Models.SubRole { roleName = "Admin (non client)", RoleID = 0},
                new Hospice.Models.SubRole { roleName = "New Volunteers", RoleID = 0},
                new Hospice.Models.SubRole { roleName = "Audit & Finance Committee", RoleID = 1},
                new Hospice.Models.SubRole { roleName = "Community Relations Committee", RoleID = 1},
                new Hospice.Models.SubRole { roleName = "Governance Committee", RoleID = 1},
                new Hospice.Models.SubRole { roleName = "Operations and Quality Improvement Committee", RoleID = 1},
                new Hospice.Models.SubRole { roleName = "New Board Members", RoleID = 1},
                new Hospice.Models.SubRole { roleName = "Leadership", RoleID = 2},
                new Hospice.Models.SubRole { roleName = "Admin", RoleID = 2},
                new Hospice.Models.SubRole { roleName = "Community", RoleID = 2},
                new Hospice.Models.SubRole { roleName = "Outreach", RoleID = 2},
                new Hospice.Models.SubRole { roleName = "Residential", RoleID = 2},
                new Hospice.Models.SubRole { roleName = "New Staff", RoleID = 2}
            };

            subroles.ForEach(d => context.SubRoles.AddOrUpdate(x => x.roleName, d));
            SaveChanges(context);

            var usersubroles = new List<Hospice.Models.UserSubRole> 
            { 
                new Hospice.Models.UserSubRole {UserID = 2, SubRoleID = 1},
                new Hospice.Models.UserSubRole {UserID = 2, SubRoleID = 2},
                new Hospice.Models.UserSubRole {UserID = 1, SubRoleID = 10},
                new Hospice.Models.UserSubRole {UserID = 3, SubRoleID = 10},
                new Hospice.Models.UserSubRole {UserID = 1, SubRoleID = 11},
                new Hospice.Models.UserSubRole {UserID = 4, SubRoleID = 17},
                new Hospice.Models.UserSubRole {UserID = 4, SubRoleID = 18}
            };

            users.ForEach(d => context.Users.AddOrUpdate(x => x.Phone, d));
            SaveChanges(context);
        }

        //Added by Andre leave this function it outputs any validation errors we have into the nuget output. just
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
