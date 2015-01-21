using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospice.Models
{
    public class UserSubRole
    {
        
          public UserSubRole()
            {
                this.User = new HashSet<User>();
                this.SubRole = new HashSet<SubRole>();
            }

            public int ID { get; set; }

            [Required(ErrorMessage = "You must select a User.")]
            public int UserID { get; set; }

            [Required(ErrorMessage = "You must select a Sub Role.")]
            public int SubRoleID { get; set; }

        public virtual ICollection<User> User { get; set; }
        public virtual ICollection<SubRole> SubRole { get; set; }
    }
}