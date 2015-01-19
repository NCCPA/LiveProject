using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospice.Models
{
    public class AnouncePrivacy
    {
            public AnouncePrivacy()
            {
                // this.Users = new HashSet<Users>();
            }

            public int ID { get; set; }

            [Display(Name = "UserID")]
            [Required(ErrorMessage = "You cannot leave the UserID blank.")]
            [Range(1, 9999, ErrorMessage = "The number is not valid.")]
            public int UserID { get; set; }
        //public virtual ICollection<Users> Users { get; set; }
    }
}