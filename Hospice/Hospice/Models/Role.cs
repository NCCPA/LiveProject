using System;
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

       

        [Display(Name = "Name")]
        [Required(ErrorMessage = "You cannot leave the role blank.")]
        [StringLength(20, ErrorMessage = "The name of the role cannot be more than 20 characters long.")]
        public string Name { get; set; }

    }
}