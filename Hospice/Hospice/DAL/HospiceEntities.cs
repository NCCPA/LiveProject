using Hospice.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Hospice.DAL
{
    public class HospiceEntities : DbContext
    {
        public DbSet<Role> Roles { get; set; }
        public DbSet<RSVP> RSVPs { get; set; }
        public DbSet<Schedule> Shedules { get; set; }
        public DbSet<SchedulePrivacy> SchedulePrivacys { get; set; }
        public DbSet<SubRole> SubRoles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserSubRole> UserSubRoles { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Folder> Folders { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<MeetingPrivacy> MeetingPrivacys { get; set; }
        public DbSet<MeetingResource> MeetingResources  { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        //public DbSet<>  { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //This option keeps table names in singular form, my personal preference.
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}

       
       /* public override int SaveChanges()
        {
            //Get Audit Values if not supplied
            string auditUser = "Anonymous";
            try //Need to try becuase HttpContext might not exist
            {
                if (HttpContext.Current.User.Identity.IsAuthenticated)
                    auditUser = HttpContext.Current.User.Identity.Name;
            }
            catch (Exception)
            { }

            DateTime auditDate = DateTime.UtcNow;
            foreach (DbEntityEntry<IAuditable> entry in ChangeTracker.Entries<IAuditable>())
            {
                if (entry.State == EntityState.Added || entry.State == EntityState.Modified)
                {
                    entry.Entity.UpdatedOn = auditDate;
                    entry.Entity.UpdatedBy = auditUser;
                }
            }
            return base.SaveChanges();
        }
    */