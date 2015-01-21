using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospice.Models
{
    public class Meeting
    {
        
          public Meeting()
            {
                 this.User = new HashSet<User>();
            }

          public int ID { get; set; }

          [Display(Name = "Type")]
          //[Required(ErrorMessage = "You cannot leave the type blank.")]
          [StringLength(50, ErrorMessage = "The type cannot be more than 50 characters long.")]
          public string Type { get; set; }

          [Display(Name = "Name")]
          [Required(ErrorMessage = "You cannot leave the title blank.")]
          [StringLength(50, ErrorMessage = "The name cannot be more than 50 characters long.")]
          public string Name { get; set; }

          [Display(Name = "Description")]
          [StringLength(1000, ErrorMessage = "The description cannot be more than 1000 characters long.")]
          public string Description { get; set; }

            //maybe null?
          [Display(Name = "Date")]
          [DataType(DataType.Date)]
          [Required(ErrorMessage = "You cannot leave the date blank.")]
          [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
          public DateTime? Date { get; set; }

          [Display(Name = "Length")]
          //[Required(ErrorMessage = "You cannot leave the title blank.")]
          [StringLength(50, ErrorMessage = "The meeting length cannot be more than 50 characters long.")]
          public string Length { get; set; }

          [Display(Name = "Location")]
          //[Required(ErrorMessage = "You cannot leave the title blank.")]
          [StringLength(50, ErrorMessage = "The meeting length cannot be more than 50 characters long.")]
          public string Location { get; set; }

          [Display(Name = "Requirements")]
          //[Required(ErrorMessage = "You cannot leave the title blank.")]
          [StringLength(200, ErrorMessage = "The meeting requirements cannot be more than 200 characters long.")]
          public string Requirements { get; set; }

          [Display(Name = "isVisible")]
          public bool isVisible { get; set; }

          [Required(ErrorMessage = "You must select a Staff Lead.")]
          public int StaffLeadID { get; set; } 

          //id of person
          [Required(ErrorMessage = "You must select a User.")]
          public int CreatedByID { get; set; }

          public virtual ICollection<User> User { get; set; }

          public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
          {
              //Create a string array containing the one element-the field where our error message should show up.
              //then you pass this to the ValidaitonResult This is only so the mesasge displays beside the field
              //instead of just in the validaiton summary.
              //var field = new[] { "DOB" };

              if (Date.GetValueOrDefault() < DateTime.Now)
              {
                  yield return new ValidationResult("The Meeting Date cannot be in the past.", new[] { "Date" });
              }
          }
    }
}
