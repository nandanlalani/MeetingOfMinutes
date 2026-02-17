using Microsoft.AspNetCore.Mvc;
using MOM.Models;

namespace MOM.Controllers
{
    public class AttendanceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Attendance()
        {
            return View();
        }

        public IActionResult ViewAttendance(int meetingId)
        {
            // TODO: Get meeting and attendance data from database
            ViewBag.MeetingId = meetingId;
            return View();
        }
    }
}
