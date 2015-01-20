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
                new Role { roleName = "Staff"}, 
                new Role { roleName = "Board"}, 
                new Role { roleName = "Admin"}
            };

            roles.ForEach(d => context.Roles.AddOrUpdate(x => x.roleName, d));
            context.SaveChanges();

            var users = new List<Hospice.Models.User> 
            { 
                new Hospice.Models.User { FirstName = "Sam" , LastName = "Smith", DOB = DateTime.Parse("1955-09-01"), Phone = "2894079876" , PhoneExt = 2, Email = "test@test.com", RoleID = 2},
                new Hospice.Models.User { FirstName = "Sam" , LastName = "Smith", DOB = DateTime.Parse("1955-09-01"), Phone = "2894079876" , PhoneExt = 2, Email = "test@test.com", RoleID = 1},
                new Hospice.Models.User { FirstName = "Sam" , LastName = "Smith", DOB = DateTime.Parse("1955-09-01"), Phone = "2894079876" , PhoneExt = 2, Email = "test@test.com", RoleID = 2},
                new Hospice.Models.User { FirstName = "Sam" , LastName = "Smith", DOB = DateTime.Parse("1955-09-01"), Phone = "2894079876" , PhoneExt = 2, Email = "test@test.com", RoleID = 3}
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
