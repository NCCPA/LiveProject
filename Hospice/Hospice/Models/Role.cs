﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospice.Models
{
    public class Role
    {
        public Role()
        {
           // this.Users = new HashSet<Users>();
        }

        public int ID { get; set; }

       

        [Display(Name = "Role Name")]
        [Required(ErrorMessage = "You cannot leave the role blank.")]
        [StringLength(20, ErrorMessage = "First name cannot be more than 10 characters long.")]
        public string roleName { get; set; }

        //public virtual ICollection<Users> Users { get; set; }
    }
}