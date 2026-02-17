using Microsoft.AspNetCore.Mvc;

namespace MOM.Controllers
{
    public class ScheduleMeetingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ScheduleMeeting()
        {
            return View();
        }
    }
}
