using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospice.Models
{
    public class AnounceFile
    {
        
          public AnounceFile()
            {
                 this.File = new HashSet<File>();
                 this.Anouncement = new HashSet<Anouncement>();
            }

            public int ID { get; set; }

            [Display(Name = "AnnounceID")]
            [Required(ErrorMessage = "You cannot leave the AnnounceID blank.")]
            [Range(1, 9999, ErrorMessage = "The number is not valid.")]
            public int AnnounceID { get; set; }

            [Display(Name = "FileID")]
            [Required(ErrorMessage = "You cannot leave the FileID blank.")]
            [Range(1, 9999, ErrorMessage = "The number is not valid.")]
            public int FileID { get; set; }

            public virtual ICollection<File> File { get; set; }
            public virtual ICollection<Anouncement> Anouncement { get; set; }
    }
}