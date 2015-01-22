using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Hospice.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
       // public DbSet<Role> Roles { get; set; }
       // public DbSet<User> Users { get; set; }
        public DbSet<SubRole> SubRoles { get; set; }
        public DbSet<UserSubRole> UserSubRoles { get; set; }

        public DbSet<File> Files { get; set; }
        public DbSet<Folder> Folders { get; set; }

        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<MeetingPrivacy> MeetingPrivacys { get; set; }
        public DbSet<MeetingResource> MeetingResources { get; set; }

        public DbSet<RSVP> RSVPs { get; set; }
        public DbSet<Schedule> Shedules { get; set; }
        public DbSet<SchedulePrivacy> SchedulePrivacys { get; set; }

        public DbSet<Notification> Notifications { get; set; }
        public DbSet<LinkHome> LinkHomes { get; set; }
        public DbSet<LinkStaff> LinkStaffs { get; set; }

        /*
         *   protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //This option keeps table names in singular form, my personal preference.
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
         * 
         */
    }
}