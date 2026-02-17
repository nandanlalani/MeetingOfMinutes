using Microsoft.AspNetCore.Mvc;
using MOM.Models;

namespace MOM.Controllers
{
    public class MeetingTypeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MeetingType()
        {
            return View();
        }

        public IActionResult AddNewMeetingType()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddNewMeetingType(MOM_MeetingType meetingType)
        {
            if (!ModelState.IsValid)
            {
                return View(meetingType);
            }
            // TODO: Add meeting type to database
            return RedirectToAction("MeetingType");
        }
    }
}
