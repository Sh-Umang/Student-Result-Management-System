using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentResultManagementSystem.Models
{
    public class Subject
    {
        [Key]
        [RegularExpression(@"^CSC\d+", ErrorMessage = "Course ID should be in the format CSC###"), DisplayName("Subject ID")]
        public string subject_id { get; set; }

        [Required, DisplayName("Subject Name")]
        public string subject_name { get; set; }
    }
}
