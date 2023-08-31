using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentResultManagementSystem.Models
{
    public class Student
    {
        [Key]
        [Required]
        [RegularExpression(@"^SN\d+",ErrorMessage = "Symbol No invalid. Eg: SN200*")]
        [DisplayName("Symbol Number")]
        public string symbol_no { get; set; }

        [Required, DisplayName("First Name")]
        public string first_name { get; set; }

        [Required, DisplayName("Last Name")]
        public string last_name { get; set; }

        [Required]
        [EmailAddress, DisplayName("Email")]
        public string email { get; set; }

        [Required, DisplayName("Address")]
        public string address { get; set; }

        [RegularExpression(@"^\d+", ErrorMessage ="Phone Number should only include digits")]
        [StringLength(10, MinimumLength = 10), DisplayName("Phone Number")]
        public string phone_no { get; set; }

        [StringLength(6), DisplayName("Gender")]
        public string gender { get; set; }

        [DataType(DataType.Date)]
        [Required, DisplayName("DOB")]
        public DateTime DOB { get; set; }

    }
}
