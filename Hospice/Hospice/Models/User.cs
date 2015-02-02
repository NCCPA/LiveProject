using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospice.Models
{
    public class User
    {

          public User()
            {
                // this.Users = new HashSet<Users>();
            }

            public int ID { get; set; }

            [Display(Name = "User")]
            public string FullName
            {
                get
                {
                    return FirstName +  " " + LastName;
                }
            }

       
        [Display(Name="First Name")]
        [Required(ErrorMessage = "You cannot leave the first name blank.")]
        [StringLength(50, ErrorMessage = "First Name cannot be more than 50 characters long.")]
        public string FirstName { get; set; }

     
        [Display(Name="Last Name")]
        [Required(ErrorMessage = "You cannot leave the last name blank.")]
        [StringLength(100, ErrorMessage = "Last Name cannot be more than 100 characters long.")]
        public string LastName { get; set; }

        [Display(Name="Date Of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DOB { get; set; }

        [Display(Name="Phone")]
        [Required(ErrorMessage = "You cannot leave the phone number blank.")]
        //[Range(1, 99999999999, ErrorMessage = "The number is not valid.")]
        public string Phone { get; set; }

        
        [Display(Name="Phone Ext")]
        [Range(1,   9999, ErrorMessage = "The number is not valid.")]
        public int? PhoneExt { get; set; }

        [Display(Name = "Email")]
        [StringLength(100, ErrorMessage = "Your email cannot be more than 100 characters long.")]
        public string Email { get; set; }

        [Display(Name = "Address")]
        [StringLength(150, ErrorMessage = "Your address cannot be more than 150 characters long.")]
        public string Address { get; set; }

        [Display(Name = "isActive")]
        public bool isActive { get; set; }

        [Display(Name="isContact")]
        public bool isContact{ get; set; }

        [Display(Name = "Can Upload File")]
        public bool canUploadFile { get; set; }

        [Display(Name = "Can Create Meeting")]
        public bool canCreateMeeting { get; set; }

        [Display(Name = "Position")]
        [StringLength(100, ErrorMessage = "Your position cannot be more than 150 characters long.")]
        public string Position { get; set; }


        [Display(Name = "Position Description")]
        [StringLength(1000, ErrorMessage = "Your position description cannot be more than 1000 characters long.")]
        public string PositionDescription { get; set; }


        [Required(ErrorMessage = "You must select a role")]
        public int RoleID { get; set; }

        public virtual Role Role { get; set; }

         public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //Create a string array containing the one element-the field where our error message should show up.
            //then you pass this to the ValidaitonResult This is only so the mesasge displays beside the field
            //instead of just in the validaiton summary.
            //var field = new[] { "DOB" };

            if (DOB.GetValueOrDefault() > DateTime.Now)
            {
                yield return new ValidationResult("Date of Birth cannot be in the future.", new[] { "DOB" });
            }
        }
    }
}