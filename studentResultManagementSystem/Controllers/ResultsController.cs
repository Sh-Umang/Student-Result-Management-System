using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentResultManagementSystem.Models;
using studentResultManagementSystem.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using StudentResultManagementSystem;
using studentResultManagementSystem.Models;

namespace studentResultManagementSystem.Controllers
{
    public class ResultsController : Controller
    {
        private readonly studentResultManagementSystemContext _context;
        private readonly string? _conn;
        private readonly SqlConnection conn;

        
        public ResultsController(studentResultManagementSystemContext context, IConfiguration configuration)
        {
            _context = context;
            _conn = configuration.GetConnectionString("studentResultManagementSystemContext");
            conn = new SqlConnection(_conn);
        }
        
        
        // GET: Results
        public IActionResult Index()
        {
            List<Record> r = new List<Record>();
            var tb1 = conn.Query<Student>("select * from Student");
            var tb2 = conn.Query<Subject>("select * from Subject");
            foreach (var c in tb1)
            {
                Record record = new Record();
                record.id = c.symbol_no;
                record.name = c.first_name + " " + c.last_name;
                showResultandPercent(c, ref record, tb2);
                r.Add(record);
            }
            return View(r);
        }

        public IActionResult Index1(string id)
        {
            var r = _context.Results.Where(c => c.std_id == id).ToList();
            if (r.Count() == _context.Subject.Count())
            {
                ViewBag.Count = 1;
            }
            var context = _context.Results.Where(r => r.std_id == id).ToList();
            ViewBag.id = id;
            return View(context);
        }
       

            private void showResultandPercent(Student c, ref Record record, IEnumerable<Subject> s)
        {
            int percentage = 0;
            var tb3 = conn.Query<Result>("select * from Results where std_id = @id", new { id = c.symbol_no });
            if (tb3.Count() != s.Count())
            {
                record.overall_result = "No Data";
                record.percent = "*";
            }
            else
            {

                var tb2 = conn.Query<Result>("select * from Results where std_id = @id and result_obt='Fail'", new { id = c.symbol_no });
                if (tb2.Count() == 0)
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
        }

        // GET: Results/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Results == null)
            {
                return NotFound();
            }

            var result = await _context.Results
                .FirstOrDefaultAsync(m => m.std_id == id);
            if (result == null)
            {
                return NotFound();
            }

            return View(result);
        }

        // GET: Results/Create
        public IActionResult Create(string id)
        {
            ViewBag.std_id3 = "";
            var studentData = _context.Student.FirstOrDefault(s => s.symbol_no == id);
            if (studentData != null)
            {
                ViewBag.std_id3 = studentData.first_name + " " + studentData.last_name;
            }
            ViewData["sub_id"] = new SelectList(_context.Subject, "subject_id", "subject_name");
            ViewBag.ErrorMessage = "";
            TempData["std_id"] = id;
            ViewBag.id2 = id;
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("std_id,sub_id,theory_marks,assignment_marks,practical_marks,total,result_obt")] Result result)
        {
            string? id2 = TempData["std_id"] as string;
            TempData["std_id"] = id2;
            ViewBag.id2 = id2;
            if (id2 != result.std_id)
            {
                return NotFound();
            }
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(result);
                    await _context.SaveChangesAsync();
                    var dp = conn.Query<Result>("updateresult", commandType: System.Data.CommandType.StoredProcedure);
                    return RedirectToAction("Index1", new {id = id2});
                }
                return View();
            }
            catch (Exception ex)
            {
                ViewData["std_id"] = new SelectList(_context.Student, "symbol_no", "first_name", result.std_id);
                ViewData["sub_id"] = new SelectList(_context.Subject, "subject_id", "subject_name", result.sub_id);
                ViewBag.ErrorMessage = ex.Message;
                ViewBag.std_id3 = "";
                var studentData = _context.Student.FirstOrDefault(s => s.symbol_no == result.std_id);
                if (studentData != null)
                {
                    ViewBag.std_id3 = studentData.first_name + " " + studentData.last_name;
                }
                return View();
            }
        }


        public async Task<IActionResult> Edit(string id, string id1)
        {
            if (id == null || id1 == null || _context.Results == null)
            {
                return NotFound();
            }

            TempData["uniid"] = id;
            TempData["uniid1"] = id1;
            var result = await _context.Results.FirstOrDefaultAsync(m => m.sub_id == id1 && m.std_id == id);
            var subject = _context.Subject.FirstOrDefault(s => s.subject_id == id1);
            var student = _context.Student.FirstOrDefault(s => s.symbol_no == id);
            if (subject != null)
            {
                ViewBag.sub_name = subject.subject_name;
            }
            if (student != null)
            {
                ViewBag.std_name = student.first_name + " " + student.last_name;
            }
            if (result == null)
            {
                return NotFound();
            }
            return View(result);
        }

        // POST: Results/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(/*string id,*/ [Bind("std_id,sub_id,theory_marks,assignment_marks,practical_marks,total,result_obt")] Result result)
        {
            string? uniid = TempData["uniid"] as string;
            string? uniid1 = TempData["uniid1"] as string;
            if (uniid != result.std_id || uniid1 != result.sub_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(result);
                    await _context.SaveChangesAsync();
                    var dp = conn.Query<Result>("updateresult", commandType: System.Data.CommandType.StoredProcedure);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ResultExists(result.sub_id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index1", new {id=uniid});
            }
            return View(result);
        }

        // GET: Results/Delete/5
        public async Task<IActionResult> Delete(string id, string id1)
        {
            if (id == null || id1 == null || _context.Results == null)
            {
                return NotFound();
            }

            var result = await _context.Results
                .FirstOrDefaultAsync(m => m.std_id == id && m.sub_id == id1);
            if (result == null)
            {
                return NotFound();
            }
            TempData["uniid"] = id;
            TempData["uniid1"] = id1;
            return View(result);
        }

        // POST: Results/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed()
        {
            string? uniid = TempData["uniid"] as string;
            string? uniid1 = TempData["uniid1"] as string;
            if (_context.Results == null)
            {
                return Problem("Entity set 'studentResultManagementSystemContext.Results'  is null.");
            }
            var result = await _context.Results.FindAsync(uniid, uniid1);
            if (result != null)
            {
                _context.Results.Remove(result);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction("Index1", new { id = uniid });
        }

        private bool ResultExists(string id)
        {
          return (_context.Results?.Any(e => e.std_id == id)).GetValueOrDefault();
        }
    }
}
