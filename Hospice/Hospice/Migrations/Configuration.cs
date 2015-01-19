namespace Hospice.Migrations
{
    using Hospice.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

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

            var users = new List<User> 
            { 
                new User { roleName = "Volunteer"  }, 
    
            };

            users.ForEach(d => context.Users.AddOrUpdate(x => x., d));
            context.SaveChanges();

        }
    }
}
