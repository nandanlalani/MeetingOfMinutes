using Microsoft.AspNetCore.Mvc;
using MOM.Models;

namespace MOM.Controllers
{
    public class StaffMemberController : Controller
    {
        public IActionResult StaffMember()
        {
            return View();
        }

        public IActionResult AddNewStaffMember()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddNewStaffMember(MOM_Staff staff)
        {
            if (!ModelState.IsValid)
            {
                return View(staff);
            }
            // TODO: Add staff member to database
            return RedirectToAction("StaffMember");
        }
    }
}
