﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospice.Models
{
    public class LinkStaff
    {
        public LinkStaff()
            {
                 this.Role = new HashSet<Role>();
            }

            public int ID { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "You cannot leave the name blank.")]
        [StringLength(50, ErrorMessage = "Name cannot be more than 50 characters long.")]
        public string Name { get; set; }

        [Display(Name = "Link")]
        [Required(ErrorMessage = "You cannot leave the link blank.")]
        [StringLength(1000, ErrorMessage = "Link cannot be more than 1000 characters long.")]
        public string Link { get; set; }

        [Display(Name = "isVisible")]
        public bool isVisible { get; set; }
        
        //add role
        [Required(ErrorMessage = "You must select a Role.")]
        public int RoleID { get; set; }

        public virtual ICollection<Role> Role { get; set; }
    }
}