using Microsoft.AspNetCore.Mvc;

namespace MOM.Controllers
{
    public class AllMeetingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllMeeting()
        {
            return View();
        }
    }
}
