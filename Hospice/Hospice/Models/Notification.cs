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
                this.Role = new HashSet<Role>();
                this.User = new HashSet<User>();
                this.SubRole = new HashSet<SubRole>();
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
       
        //1 is Anounce | 2 is  Meeting | 3 is Schedule
        [Display(Name = "Notification Type (Announce/Meeting/Schedule)")]
        [Required(ErrorMessage = "You cannot leave the Notification Type blank.")]
        [Range(1, 3, ErrorMessage = "The number is not valid.")]
        public string Type { get; set; }

        [Display(Name = "Type ID")]
        [Required(ErrorMessage = "You cannot leave the TypeID blank.")]
        //[Range(1, 999999, ErrorMessage = "The number is not valid.")]
        public int TypeID { get; set; }

        public virtual ICollection<User> User { get; set; }
        public virtual ICollection<SubRole> SubRole { get; set; }
        public virtual ICollection<Role> Role { get; set; }
    }
}