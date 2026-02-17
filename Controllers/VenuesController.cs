using Microsoft.AspNetCore.Mvc;
using MOM.Models;

namespace MOM.Controllers
{
    public class VenuesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Venues()
        {
            return View();
        }

        public IActionResult AddNewVenue()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddNewVenue(MOM_MeetingVenue venue)
        {
            if (!ModelState.IsValid)
            {
                return View(venue);
            }
            // TODO: Add venue to database
            return RedirectToAction("Venues");
        }
    }
}
