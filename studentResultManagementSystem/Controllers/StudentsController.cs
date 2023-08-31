using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentResultManagementSystem.Models;
using studentResultManagementSystem.Data;

namespace studentResultManagementSystem.Controllers
{
    public class StudentsController : Controller
    {
        private readonly studentResultManagementSystemContext _context;

        public StudentsController(studentResultManagementSystemContext context)
        {
            _context = context;
        }

        // GET: Students
        public async Task<IActionResult> Index()
        {
              return _context.Student != null ? 
                          View(await _context.Student.ToListAsync()) :
                          Problem("Entity set 'studentResultManagementSystemContext.Student'  is null.");
        }


        // GET: Students/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Student == null)
            {
                return NotFound();
            }

            var student = await _context.Student
                .FirstOrDefaultAsync(m => m.symbol_no == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("symbol_no,first_name,last_name,email,address,phone_no,gender,DOB")] Student student)
        {
            DateTime date = DateTime.Now.AddYears(100);
            DateTime date2 = DateTime.Now.AddYears(-3);
            if (ModelState.IsValid)
            {
                ViewBag.ErrorMsg = "";
                /*ViewBag.ErrorMsg = 0;*/
                try
                {
                    if (student.DOB > date2 && student.DOB < date)
                    {
                        ViewBag.Errormsg = "Invalid date. Student must be atleast 3 years old.";
                        return View();
                    }
                    _context.Add(student);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    ViewBag.ErrorMsg = checkViolation(student);
                    return View();
                }
            }
            return View(student);
        }

        public string checkViolation(Student s)
        {
            if (_context.Student.Any(c => c.symbol_no == s.symbol_no) && _context.Student.Any(c => c.email == s.email))
            {
                return "Symbol Number already exists. Email already taken";
            }
            else if (_context.Student.Any(c => c.symbol_no == s.symbol_no))
            {
                return "Symbol Number already exists";
            }
            else return "Email already taken";
        }

        /*public int checkViolation(Student s)
        {
            if (_context.Student.Any(c => c.symbol_no == s.symbol_no))
            {
                return 1;
            }
            else if (_context.Student.Any(c => c.email == s.email))
            {
                return 2;
            }
            else return 0;
        }*/

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Student == null)
            {
                return NotFound();
            }

            var student = await _context.Student.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("symbol_no,first_name,last_name,email,address,phone_no,gender")] Student student)
        {
            if (id != student.symbol_no)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.symbol_no))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Student == null)
            {
                return NotFound();
            }

            var student = await _context.Student
                .FirstOrDefaultAsync(m => m.symbol_no == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Student == null)
            {
                return Problem("Entity set 'studentResultManagementSystemContext.Student'  is null.");
            }
            var student = await _context.Student.FindAsync(id);
            if (student != null)
            {
                _context.Student.Remove(student);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentExists(string id)
        {
          return (_context.Student?.Any(e => e.symbol_no == id)).GetValueOrDefault();
        }
    }
}
