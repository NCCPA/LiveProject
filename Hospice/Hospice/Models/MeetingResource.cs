using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospice.Models
{
    public class MeetingResource
    {

        public MeetingResource()
            {
                this.File = new HashSet<File>();
                this.Meeting = new HashSet<Meeting>();
            }

            public int ID { get; set; }

            [Display(Name = "MeetingID")]
            [Required(ErrorMessage = "You cannot leave the MeetingID blank.")]
            [Range(1, 9999, ErrorMessage = "The number is not valid.")]
            public int AnnounceID { get; set; }

            [Display(Name = "FileID")]
            [Required(ErrorMessage = "You cannot leave the FileID blank.")]
            [Range(1, 9999, ErrorMessage = "The number is not valid.")]
            public int FileID { get; set; }

            public virtual ICollection<File> File { get; set; }
            public virtual ICollection<Meeting> Meeting { get; set; }
    }
}