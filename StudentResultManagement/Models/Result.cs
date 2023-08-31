using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentResultManagementSystem.Models
{
    public class Result
    {
        public int std_id { get; set; }

        public int sub_id { get; set; }

        public int theory_marks { get; set; }

        public int assignment_marks { get; set; }

        public int practical_marks { get; set; }

        public string total { get; set; }
        public string result_obt { get; set; }
    }
}
