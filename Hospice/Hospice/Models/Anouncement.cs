using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospice.Models
{
    public class Anouncement
    {

        public Anouncement()
        {
            this.User = new HashSet<User>();
        }

        public int ID { get; set; }

        [Display(Name = "Title")]
        [Required(ErrorMessage = "You cannot leave the title blank.")]
        [StringLength(50, ErrorMessage = "The title cannot be more than 50 characters long.")]
        public string Title { get; set; }

        [Display(Name = "Description")]
        [StringLength(1000, ErrorMessage = "The description cannot be more than 1000 characters long.")]
        public string Description { get; set; }

        [Display(Name = "isVisible")]
        public bool isVisible { get; set; }

        [Display(Name = "isDeath")]
        public bool isDeath { get; set; }

        //id of person
       // [Required(ErrorMessage = "You must select a User.")]
        public int CreatedByID { get; set; }

        public virtual ICollection<User> User { get; set; }

    }
}