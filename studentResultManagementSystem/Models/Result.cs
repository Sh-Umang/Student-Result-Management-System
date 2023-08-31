using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentResultManagementSystem.Models
{
    public class Result
    {
        [Column(Order = 0),ForeignKey("student"), DisplayName("Symbol Number")]
        [RegularExpression(@"^SN\d+",ErrorMessage ="Symbol Number should start with 'SN'")]
        public string std_id { get; set; }

        [Column(Order = 1),ForeignKey("subject"), DisplayName("Subject ID")]
        public string sub_id { get; set; }

        [Range(0, 60), DisplayName("Theory")]
        public int theory_marks { get; set; }

        [Range(0, 20), DisplayName("Internal")]
        public int assignment_marks { get; set; }

        [Range(0, 20), DisplayName("Practical")]
        public int practical_marks { get; set; }

        [DisplayName("Total")]
        public int total { get; set; } = 0;

        [DisplayName("Result")]
        public string result_obt { get; set; } = "";

        [BindNever]
        public virtual Student? student { get; set; }

        [BindNever]
        public virtual Subject? subject { get; set; }

    }
}
