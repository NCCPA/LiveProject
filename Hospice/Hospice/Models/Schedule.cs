using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospice.Models
{
    public class Schedule
    {
        public Schedule()
            {
                // this.Users = new HashSet<Users>();
            }

            public int ID { get; set; }

        [Display(Name = "Name")]
        [StringLength(100, ErrorMessage = "The Name cannot be more than 100 characters long.")]
        public string Name { get; set; }

        [Display(Name = "isVisible")]
        public bool isVisible { get; set; }

        //add concurrency control
        //createdBy
        //createdOn


        //public virtual ICollection<Users> Users { get; set; }
    }
}