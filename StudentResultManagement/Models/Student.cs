using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentResultManagementSystem.Models
{
    public class Student
    {
        public int symbol_no { get; set; }

        public string first_name { get; set; }

        public string last_name { get; set; }

        public string email { get; set; }

        public string address { get; set; }
        
        public long phone_no { get; set; }

        public string gender { get; set; }

    }
}
