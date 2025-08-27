using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WriteTheRestWeb.Models;

namespace WriteTheRestWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult AdminPanel()
        {
            return View();
        }
        public IActionResult AdminPanelEdit()
        {
            return View();
        }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WatchStory()
        {
            return View();
        }
        public IActionResult ContinueStory()
        {
            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }
        public IActionResult ProfileEdit()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult VersionsChapter()
        {
            return View();
        }
        public IActionResult AddChapter()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
