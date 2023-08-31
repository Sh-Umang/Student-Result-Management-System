using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using studentResultManagementSystem.Data;
using studentResultManagementSystem.ViewModels;
using StudentResultManagementSystem.Models;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;
using StudentResultManagementSystem;
using System.Configuration;
using System.Drawing;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Dapper;

namespace studentResultManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly studentResultManagementSystemContext _context;
        private readonly ILogger<HomeController> _logger;
        private readonly string? _conn;
        private readonly SqlConnection conn;

        public HomeController(ILogger<HomeController> logger, studentResultManagementSystemContext context, IConfiguration configuration)
        {
            _logger = logger;
            _context = context;
            _conn = configuration.GetConnectionString("studentResultManagementSystemContext");
            conn = new SqlConnection(_conn);
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Result result, string DOB)
        {
            if (DOB == null)
            {
                ViewBag.ErrorMesg = "Enter Date of Birth.";
                return View();
            }
            else if (ModelState.IsValid)
            {
                if(!_context.Student.Any(dt => dt.DOB.ToString() == DOB.ToString()) || !_context.Student.Any(dt => dt.symbol_no == result.std_id))
                {
                    ViewBag.ErrorMsg = "No Record Found.";
                    return View();
                }

                var tb2 = _context.Subject.ToList();

                Record record = new Record();
                record.id = result.std_id;
                record.name = "";
                int percentage = 0;
                var tb3 = conn.Query<Result>("select * from Results where std_id = @id", new { id = result.std_id });
                var tb4 = conn.Query<Result>("select * from Results where std_id = @id and result_obt='Fail'", new { id = result.std_id });
                if (tb3.Count() == tb2.Count())
                {
                    if(tb4.Count() == 0)
                    {
                        record.overall_result = "Pass";
                        foreach (var d in tb3)
                        {
                            percentage += d.total;
                        }
                        record.percent = Convert.ToString(percentage / tb3.Count()) + "%";
                    }
                    else
                    {
                        record.overall_result = "Fail";
                        record.percent = "-";
                    }
                }
                
                TempData["Total"]= record.overall_result;
                TempData["Percent"] = record.percent;


                var s = _context.Student.FirstOrDefault(r => r.symbol_no == result.std_id);
                var sub = _context.Subject.ToList();
                var sr = _context.Results.Where(r => r.std_id == result.std_id).ToList();
                StudentAndResult studentAndResult = new StudentAndResult();
                studentAndResult.student = s;
                studentAndResult.result = sr;
                studentAndResult.subject = sub;
                string jsonData = JsonConvert.SerializeObject(studentAndResult);
                TempData["ComData"] = jsonData;
                return RedirectToAction("Privacy");
            }

            return View();
        }



        public IActionResult Privacy()
        {
            string? data = TempData["ComData"] as string;
            ViewBag.Total = TempData["Total"] as string;
            ViewBag.Percent = TempData["Percent"] as string;
            TempData.Keep();
            StudentAndResult? result = JsonConvert.DeserializeObject<StudentAndResult>(data);
            return View(result);
        }


    }
}