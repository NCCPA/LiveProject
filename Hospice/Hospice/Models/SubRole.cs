using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospice.Models
{
    public class SubRole
    {
        
          public SubRole()
            {
                 this.Role = new HashSet<Role>();
            }

            public int ID { get; set; }

        [Display(Name = "Sub Role Name")]
        [Required(ErrorMessage = "You cannot leave the Sub Role blank.")]
        [StringLength(40, ErrorMessage = "Sub Role cannot be more than 20 characters long.")]
        public string roleName { get; set; }

        [Required(ErrorMessage = "You must select a Role.")]
        public int RoleID { get; set; }

        public virtual ICollection<Role> Role { get; set; }
    }
}