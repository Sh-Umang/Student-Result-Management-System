using Microsoft.Identity.Client;
using StudentResultManagementSystem.Models;
namespace studentResultManagementSystem.ViewModels
{
    public class StudentAndResult
    {
        public Student student = new Student();
        public List<Subject> subject = new List<Subject>();
        public List<Result> result = new List<Result>();
        /*public StudentAndResult()
        {
            // Add any default initialization logic here if needed.
        }
        public StudentAndResult(Student s, List<Result> sr)
        {
            student.symbol_no = s.symbol_no;
            student.first_name = s.first_name;
            student.last_name = s.last_name;
            student.email = s.email;
            student.address = s.address;
            student.phone_no = s.phone_no;
            student.gender = s.gender;
            foreach (var item in sr)
            {
                result.Add(item);
            }
        }*/
    }

}
