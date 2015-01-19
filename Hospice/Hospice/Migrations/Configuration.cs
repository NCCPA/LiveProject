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

            var users = new List<Hospice.Models.User> 
            { 
                new Hospice.Models.User { FirstName = "Sam" , LastName = "Smith", DOB = DateTime.Parse("1955-09-01"), Phone = "2894079876" , Email = "test@test.com", RoleID = 0}
                new Hospice.Models.User { FirstName = "Sam" , LastName = "Smith", DOB = DateTime.Parse("1955-09-01"), Phone = "2894079876" , Email = "test@test.com", RoleID = 1}
                new Hospice.Models.User { FirstName = "Sam" , LastName = "Smith", DOB = DateTime.Parse("1955-09-01"), Phone = "2894079876" , Email = "test@test.com", RoleID = 2}
                new Hospice.Models.User { FirstName = "Sam" , LastName = "Smith", DOB = DateTime.Parse("1955-09-01"), Phone = "2894079876" , Email = "test@test.com", RoleID = 3}
            };

            users.ForEach(d => context.Users.AddOrUpdate(x => x.Phone, d));
            context.SaveChanges();

        }
    }
}
