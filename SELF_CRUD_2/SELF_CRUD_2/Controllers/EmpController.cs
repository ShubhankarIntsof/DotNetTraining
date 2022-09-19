using Microsoft.AspNetCore.Mvc;
using SELF_CRUD_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SELF_CRUD_2.Controllers
{
    public class EmpController : Controller
    {
        private ApplicationDbContext _db;
        public EmpController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var displaydata = _db.EmployeeShuba.ToList();
            return View(displaydata);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _db.Add(employee);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");

            }return View(employee);
        }
    }
}
