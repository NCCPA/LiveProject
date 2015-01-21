﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospice.Models
{
    public class Folder
    {
        
          public Folder()
            {
                this.Role = new HashSet<Role>();
                this.User = new HashSet<User>();
                this.SubRole = new HashSet<SubRole>();
                this.File = new HashSet<File>();
            }

            public int ID { get; set; }


            // [Required(ErrorMessage = "You must select a Sub Role.")]
            [Display(Name = "RoleID")]
            [Required(ErrorMessage = "You cannot leave the RoleID blank.")]
            [Range(1, 99999, ErrorMessage = "The number is not valid.")]
            public int RoleID { get; set; }

            // [Required(ErrorMessage = "You must select a User.")]
            [Display(Name = "UserID")]
            [Required(ErrorMessage = "You cannot leave the UserID blank.")]
            [Range(1, 99999, ErrorMessage = "The number is not valid.")]
            public int UserID { get; set; }

            // [Required(ErrorMessage = "You must select a Sub Role.")]
            [Display(Name = "SubRoleID")]
            [Required(ErrorMessage = "You cannot leave the SubRoleID blank.")]
            [Range(1, 99999, ErrorMessage = "The number is not valid.")]
            public int SubRoleID { get; set; }

            public virtual ICollection<User> User { get; set; }
            public virtual ICollection<SubRole> SubRole { get; set; }
            public virtual ICollection<Role> Role { get; set; }
            public virtual ICollection<File> File { get; set; }
    }
}