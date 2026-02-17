using Microsoft.AspNetCore.Mvc;
using MOM.Models;

namespace MOM.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Department()
        {
            return View();
        }

        public IActionResult AddNewDepartment()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddNewDepartment(MOM_Department department)
        {
            if (!ModelState.IsValid)
            {
                return View(department);
            }
            // TODO: Save department to database
            return RedirectToAction("Department");
        }
    }
}