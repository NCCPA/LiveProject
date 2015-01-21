using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospice.Models
{
    public class RSVP
    {
        public RSVP()
            {
                // this.Users = new HashSet<Users>();
            }

            public int ID { get; set; }

            [Display(Name = "UserID")]
            [Required(ErrorMessage = "You cannot leave the UserID blank.")]
            [Range(1, 9999, ErrorMessage = "The number is not valid.")]
            public int UserID { get; set; }

            [Display(Name = "didRespond")]
            public bool didRespond { get; set; }

            [Display(Name = "isAttending")]
            public bool isAttending { get; set; }

            [Display(Name = "Note")]
            [StringLength(1000, ErrorMessage = "The note cannot be more than 1000 characters long.")]
            public string Note { get; set; }
        //public virtual ICollection<Users> Users { get; set; }
    }
}