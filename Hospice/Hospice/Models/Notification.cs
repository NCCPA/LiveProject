using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospice.Models
{
    public class Notification
    {
        public Notification()
            {
                // this.Users = new HashSet<Users>();
            }

            public int ID { get; set; }

        [Display(Name = "UserID")]
        [Required(ErrorMessage = "You cannot leave the UserID blank.")]
        [Range(1, 9999, ErrorMessage = "The number is not valid.")]
        public int UserID { get; set; }

        [Display(Name = "viewedNotification")]
        public bool viewedNotification { get; set; }

        [Display(Name = "isAttending")]
        public bool isAttending { get; set; }

        [Display(Name = "Date")]
        public DateTime Date { get; set; }

       /*
        * We can figure dis sh1t out later
        * 
        [Display(Name = "Notification Type (Announce/Meeting/Schedule)")]
        [Required(ErrorMessage = "You cannot leave the Notification Type blank.")]
        [Range(1, 9999, ErrorMessage = "The number is not valid.")]
        public string Type { get; set; }

        [Display(Name = "Type ID")]
        [Required(ErrorMessage = "You cannot leave the TypeID blank.")]
        [Range(1, 9999, ErrorMessage = "The number is not valid.")]
        public int TypeID { get; set; }
        */
        //public virtual ICollection<Users> Users { get; set; }
    }
}