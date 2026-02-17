using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MOM.Models;

namespace MOM.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            // Accept any username and password for demo purposes
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                // Store user info in session for demo
                HttpContext.Session.SetString("Username", username);
                HttpContext.Session.SetString("IsLoggedIn", "true");
                
                return RedirectToAction("Dashboard");
            }
            
            // If login fails, show error message
            ViewBag.ErrorMessage = "Please enter both username and password.";
            return View();
        }

        public IActionResult Dashboard()
        {
            // Check if user is logged in
            var isLoggedIn = HttpContext.Session.GetString("IsLoggedIn");
            if (string.IsNullOrEmpty(isLoggedIn))
            {
                return RedirectToAction("Index");
            }
            
            return View();
        }

        public IActionResult Logout()
        {
            // Clear session
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
    