namespace studentResultManagementSystem.Models
{
    public class ResultViewModel
    {
        public IEnumerable<StudentResultManagementSystem.Models.Result> Results { get; set; }
        public StudentResultManagementSystem.Models.Result? SingleResult { get; set; }
    }
}
