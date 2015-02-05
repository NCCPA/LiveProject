using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospice.Models
{
    public class ProfileViewModel
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "You cannot leave the first name blank.")]
        [StringLength(100, ErrorMessage = "First Name cannot be more than 50 characters long.")]
        public string FName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You cannot leave the last name blank.")]
        [StringLength(100, ErrorMessage = "Last Name cannot be more than 100 characters long.")]
        public string LName { get; set; }

        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DOB { get; set; }

        [Display(Name = "Phone Ext")]
        [Range(1, 9999, ErrorMessage = "The number is not valid.")]
        public int? UserPhoneExt { get; set; }

        [Display(Name = "isActive")]
        public bool isActive { get; set; }

        [Display(Name = "isContact")]
        public bool isContact { get; set; }

        [Display(Name = "Can Upload File")]
        public bool canUploadFile { get; set; }

        [Display(Name = "Can Create Meeting")]
        public bool canCreateMeeting { get; set; }

        [Display(Name = "Bio")]
        [StringLength(100, ErrorMessage = "Your position cannot be more than 150 characters long.")]
        public string Bio { get; set; }

        [Display(Name = "Position")]
        [StringLength(100, ErrorMessage = "Your position cannot be more than 150 characters long.")]
        public string Position { get; set; }

        [Display(Name = "Position Description")]
        [StringLength(1000, ErrorMessage = "Your position description cannot be more than 1000 characters long.")]
        public string PositionDescription { get; set; }

        [Required(ErrorMessage = "You must select a role")]
        public int RoleID { get; set; }
    }
}