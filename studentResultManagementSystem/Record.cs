using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentResultManagementSystem
{
    public class Record
    {
        [DisplayName("Symbol Number")]
        public string id { get; set; }

        [DisplayName("Name")]
        public string name { get; set; }
        [DisplayName("Result")]
        public string overall_result { get; set; }

        [DisplayName("Percentage")]
        public string percent { get; set; }
    }
}
