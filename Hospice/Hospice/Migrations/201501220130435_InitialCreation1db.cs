namespace Hospice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreation1db : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Files",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            Folder_ID = c.Int(),
            //            MeetingResource_ID = c.Int(),
            //        })
            //    .PrimaryKey(t => t.ID)
            //    .ForeignKey("dbo.Folders", t => t.Folder_ID)
            //    .ForeignKey("dbo.MeetingResources", t => t.MeetingResource_ID)
            //    .Index(t => t.Folder_ID)
            //    .Index(t => t.MeetingResource_ID);
            
            //CreateTable(
            //    "dbo.Folders",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            RoleID = c.Int(nullable: false),
            //            UserID = c.Int(nullable: false),
            //            SubRoleID = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ID);
            
            //CreateTable(
            //    "dbo.Roles",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            roleName = c.String(nullable: false, maxLength: 20),
            //            Folder_ID = c.Int(),
            //            SubRole_ID = c.Int(),
            //            LinkStaff_ID = c.Int(),
            //            MeetingPrivacy_ID = c.Int(),
            //            Notification_ID = c.Int(),
            //            SchedulePrivacy_ID = c.Int(),
            //        })
            //    .PrimaryKey(t => t.ID)
            //    .ForeignKey("dbo.Folders", t => t.Folder_ID)
            //    .ForeignKey("dbo.SubRoles", t => t.SubRole_ID)
            //    .ForeignKey("dbo.LinkStaffs", t => t.LinkStaff_ID)
            //    .ForeignKey("dbo.MeetingPrivacies", t => t.MeetingPrivacy_ID)
            //    .ForeignKey("dbo.Notifications", t => t.Notification_ID)
            //    .ForeignKey("dbo.SchedulePrivacies", t => t.SchedulePrivacy_ID)
            //    .Index(t => t.Folder_ID)
            //    .Index(t => t.SubRole_ID)
            //    .Index(t => t.LinkStaff_ID)
            //    .Index(t => t.MeetingPrivacy_ID)
            //    .Index(t => t.Notification_ID)
            //    .Index(t => t.SchedulePrivacy_ID);
            
            //CreateTable(
            //    "dbo.SubRoles",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            roleName = c.String(nullable: false, maxLength: 200),
            //            RoleID = c.Int(nullable: false),
            //            Folder_ID = c.Int(),
            //            MeetingPrivacy_ID = c.Int(),
            //            Notification_ID = c.Int(),
            //            SchedulePrivacy_ID = c.Int(),
            //            UserSubRole_ID = c.Int(),
            //        })
            //    .PrimaryKey(t => t.ID)
            //    .ForeignKey("dbo.Folders", t => t.Folder_ID)
            //    .ForeignKey("dbo.MeetingPrivacies", t => t.MeetingPrivacy_ID)
            //    .ForeignKey("dbo.Notifications", t => t.Notification_ID)
            //    .ForeignKey("dbo.SchedulePrivacies", t => t.SchedulePrivacy_ID)
            //    .ForeignKey("dbo.UserSubRoles", t => t.UserSubRole_ID)
            //    .Index(t => t.Folder_ID)
            //    .Index(t => t.MeetingPrivacy_ID)
            //    .Index(t => t.Notification_ID)
            //    .Index(t => t.SchedulePrivacy_ID)
            //    .Index(t => t.UserSubRole_ID);
            
            //CreateTable(
            //    "dbo.Users",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            FirstName = c.String(nullable: false, maxLength: 50),
            //            LastName = c.String(nullable: false, maxLength: 100),
            //            DOB = c.DateTime(),
            //            Phone = c.String(nullable: false),
            //            PhoneExt = c.Int(),
            //            Email = c.String(maxLength: 100),
            //            Address = c.String(maxLength: 150),
            //            isActive = c.Boolean(nullable: false),
            //            isContact = c.Boolean(nullable: false),
            //            canUploadFile = c.Boolean(nullable: false),
            //            canCreateMeeting = c.Boolean(nullable: false),
            //            Position = c.String(maxLength: 100),
            //            PositionDescription = c.String(maxLength: 1000),
            //            RoleID = c.Int(nullable: false),
            //            Folder_ID = c.Int(),
            //            Meeting_ID = c.Int(),
            //            MeetingPrivacy_ID = c.Int(),
            //            Notification_ID = c.Int(),
            //            RSVP_ID = c.Int(),
            //            SchedulePrivacy_ID = c.Int(),
            //            UserSubRole_ID = c.Int(),
            //        })
            //    .PrimaryKey(t => t.ID)
            //    .ForeignKey("dbo.Roles", t => t.RoleID, cascadeDelete: true)
            //    .ForeignKey("dbo.Folders", t => t.Folder_ID)
            //    .ForeignKey("dbo.Meetings", t => t.Meeting_ID)
            //    .ForeignKey("dbo.MeetingPrivacies", t => t.MeetingPrivacy_ID)
            //    .ForeignKey("dbo.Notifications", t => t.Notification_ID)
            //    .ForeignKey("dbo.RSVPs", t => t.RSVP_ID)
            //    .ForeignKey("dbo.SchedulePrivacies", t => t.SchedulePrivacy_ID)
            //    .ForeignKey("dbo.UserSubRoles", t => t.UserSubRole_ID)
            //    .Index(t => t.RoleID)
            //    .Index(t => t.Folder_ID)
            //    .Index(t => t.Meeting_ID)
            //    .Index(t => t.MeetingPrivacy_ID)
            //    .Index(t => t.Notification_ID)
            //    .Index(t => t.RSVP_ID)
            //    .Index(t => t.SchedulePrivacy_ID)
            //    .Index(t => t.UserSubRole_ID);
            
            //CreateTable(
            //    "dbo.LinkHomes",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 50),
            //            Link = c.String(nullable: false, maxLength: 1000),
            //            isVisible = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ID);
            
            //CreateTable(
            //    "dbo.LinkStaffs",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 50),
            //            Link = c.String(nullable: false, maxLength: 1000),
            //            isVisible = c.Boolean(nullable: false),
            //            RoleID = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ID);
            
            //CreateTable(
            //    "dbo.MeetingPrivacies",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            MeetingID = c.Int(nullable: false),
            //            RoleID = c.Int(nullable: false),
            //            UserID = c.Int(nullable: false),
            //            SubRoleID = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ID);
            
            //CreateTable(
            //    "dbo.Meetings",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            Type = c.String(maxLength: 50),
            //            Name = c.String(nullable: false, maxLength: 50),
            //            Description = c.String(maxLength: 1000),
            //            Date = c.DateTime(nullable: false),
            //            Length = c.String(maxLength: 50),
            //            Location = c.String(maxLength: 50),
            //            Requirements = c.String(maxLength: 200),
            //            isVisible = c.Boolean(nullable: false),
            //            StaffLeadID = c.Int(nullable: false),
            //            CreatedByID = c.Int(nullable: false),
            //            MeetingPrivacy_ID = c.Int(),
            //            MeetingResource_ID = c.Int(),
            //        })
            //    .PrimaryKey(t => t.ID)
            //    .ForeignKey("dbo.MeetingPrivacies", t => t.MeetingPrivacy_ID)
            //    .ForeignKey("dbo.MeetingResources", t => t.MeetingResource_ID)
            //    .Index(t => t.MeetingPrivacy_ID)
            //    .Index(t => t.MeetingResource_ID);
            
            //CreateTable(
            //    "dbo.MeetingResources",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            AnnounceID = c.Int(nullable: false),
            //            FileID = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ID);
            
            //CreateTable(
            //    "dbo.Notifications",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            UserID = c.Int(nullable: false),
            //            viewedNotification = c.Boolean(nullable: false),
            //            isAttending = c.Boolean(nullable: false),
            //            Date = c.DateTime(nullable: false),
            //            Type = c.String(nullable: false),
            //            TypeID = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ID);
            
            //CreateTable(
            //    "dbo.AspNetRoles",
            //    c => new
            //        {
            //            Id = c.String(nullable: false, maxLength: 128),
            //            Name = c.String(nullable: false, maxLength: 256),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            //CreateTable(
            //    "dbo.AspNetUserRoles",
            //    c => new
            //        {
            //            UserId = c.String(nullable: false, maxLength: 128),
            //            RoleId = c.String(nullable: false, maxLength: 128),
            //        })
            //    .PrimaryKey(t => new { t.UserId, t.RoleId })
            //    .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
            //    .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
            //    .Index(t => t.UserId)
            //    .Index(t => t.RoleId);
            
            //CreateTable(
            //    "dbo.RSVPs",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            UserID = c.Int(nullable: false),
            //            didRespond = c.Boolean(nullable: false),
            //            isAttending = c.Boolean(nullable: false),
            //            Note = c.String(maxLength: 1000),
            //        })
            //    .PrimaryKey(t => t.ID);
            
            //CreateTable(
            //    "dbo.SchedulePrivacies",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            RoleID = c.Int(nullable: false),
            //            UserID = c.Int(nullable: false),
            //            SubRoleID = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ID);
            
            //CreateTable(
            //    "dbo.Schedules",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            Name = c.String(maxLength: 100),
            //            isVisible = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ID);
            
            //CreateTable(
            //    "dbo.AspNetUsers",
            //    c => new
            //        {
            //            Id = c.String(nullable: false, maxLength: 128),
            //            Email = c.String(maxLength: 256),
            //            EmailConfirmed = c.Boolean(nullable: false),
            //            PasswordHash = c.String(),
            //            SecurityStamp = c.String(),
            //            PhoneNumber = c.String(),
            //            PhoneNumberConfirmed = c.Boolean(nullable: false),
            //            TwoFactorEnabled = c.Boolean(nullable: false),
            //            LockoutEndDateUtc = c.DateTime(),
            //            LockoutEnabled = c.Boolean(nullable: false),
            //            AccessFailedCount = c.Int(nullable: false),
            //            UserName = c.String(nullable: false, maxLength: 256),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            //CreateTable(
            //    "dbo.AspNetUserClaims",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            UserId = c.String(nullable: false, maxLength: 128),
            //            ClaimType = c.String(),
            //            ClaimValue = c.String(),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
            //    .Index(t => t.UserId);
            
            //CreateTable(
            //    "dbo.AspNetUserLogins",
            //    c => new
            //        {
            //            LoginProvider = c.String(nullable: false, maxLength: 128),
            //            ProviderKey = c.String(nullable: false, maxLength: 128),
            //            UserId = c.String(nullable: false, maxLength: 128),
            //        })
            //    .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
            //    .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
            //    .Index(t => t.UserId);
            
            //CreateTable(
            //    "dbo.UserSubRoles",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            UserID = c.Int(nullable: false),
            //            SubRoleID = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "UserSubRole_ID", "dbo.UserSubRoles");
            DropForeignKey("dbo.SubRoles", "UserSubRole_ID", "dbo.UserSubRoles");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Users", "SchedulePrivacy_ID", "dbo.SchedulePrivacies");
            DropForeignKey("dbo.SubRoles", "SchedulePrivacy_ID", "dbo.SchedulePrivacies");
            DropForeignKey("dbo.Roles", "SchedulePrivacy_ID", "dbo.SchedulePrivacies");
            DropForeignKey("dbo.Users", "RSVP_ID", "dbo.RSVPs");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Users", "Notification_ID", "dbo.Notifications");
            DropForeignKey("dbo.SubRoles", "Notification_ID", "dbo.Notifications");
            DropForeignKey("dbo.Roles", "Notification_ID", "dbo.Notifications");
            DropForeignKey("dbo.Meetings", "MeetingResource_ID", "dbo.MeetingResources");
            DropForeignKey("dbo.Files", "MeetingResource_ID", "dbo.MeetingResources");
            DropForeignKey("dbo.Users", "MeetingPrivacy_ID", "dbo.MeetingPrivacies");
            DropForeignKey("dbo.SubRoles", "MeetingPrivacy_ID", "dbo.MeetingPrivacies");
            DropForeignKey("dbo.Roles", "MeetingPrivacy_ID", "dbo.MeetingPrivacies");
            DropForeignKey("dbo.Meetings", "MeetingPrivacy_ID", "dbo.MeetingPrivacies");
            DropForeignKey("dbo.Users", "Meeting_ID", "dbo.Meetings");
            DropForeignKey("dbo.Roles", "LinkStaff_ID", "dbo.LinkStaffs");
            DropForeignKey("dbo.Users", "Folder_ID", "dbo.Folders");
            DropForeignKey("dbo.Users", "RoleID", "dbo.Roles");
            DropForeignKey("dbo.SubRoles", "Folder_ID", "dbo.Folders");
            DropForeignKey("dbo.Roles", "SubRole_ID", "dbo.SubRoles");
            DropForeignKey("dbo.Roles", "Folder_ID", "dbo.Folders");
            DropForeignKey("dbo.Files", "Folder_ID", "dbo.Folders");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Meetings", new[] { "MeetingResource_ID" });
            DropIndex("dbo.Meetings", new[] { "MeetingPrivacy_ID" });
            DropIndex("dbo.Users", new[] { "UserSubRole_ID" });
            DropIndex("dbo.Users", new[] { "SchedulePrivacy_ID" });
            DropIndex("dbo.Users", new[] { "RSVP_ID" });
            DropIndex("dbo.Users", new[] { "Notification_ID" });
            DropIndex("dbo.Users", new[] { "MeetingPrivacy_ID" });
            DropIndex("dbo.Users", new[] { "Meeting_ID" });
            DropIndex("dbo.Users", new[] { "Folder_ID" });
            DropIndex("dbo.Users", new[] { "RoleID" });
            DropIndex("dbo.SubRoles", new[] { "UserSubRole_ID" });
            DropIndex("dbo.SubRoles", new[] { "SchedulePrivacy_ID" });
            DropIndex("dbo.SubRoles", new[] { "Notification_ID" });
            DropIndex("dbo.SubRoles", new[] { "MeetingPrivacy_ID" });
            DropIndex("dbo.SubRoles", new[] { "Folder_ID" });
            DropIndex("dbo.Roles", new[] { "SchedulePrivacy_ID" });
            DropIndex("dbo.Roles", new[] { "Notification_ID" });
            DropIndex("dbo.Roles", new[] { "MeetingPrivacy_ID" });
            DropIndex("dbo.Roles", new[] { "LinkStaff_ID" });
            DropIndex("dbo.Roles", new[] { "SubRole_ID" });
            DropIndex("dbo.Roles", new[] { "Folder_ID" });
            DropIndex("dbo.Files", new[] { "MeetingResource_ID" });
            DropIndex("dbo.Files", new[] { "Folder_ID" });
            DropTable("dbo.UserSubRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Schedules");
            DropTable("dbo.SchedulePrivacies");
            DropTable("dbo.RSVPs");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Notifications");
            DropTable("dbo.MeetingResources");
            DropTable("dbo.Meetings");
            DropTable("dbo.MeetingPrivacies");
            DropTable("dbo.LinkStaffs");
            DropTable("dbo.LinkHomes");
            DropTable("dbo.Users");
            DropTable("dbo.SubRoles");
            DropTable("dbo.Roles");
            DropTable("dbo.Folders");
            DropTable("dbo.Files");
        }
    }
}
