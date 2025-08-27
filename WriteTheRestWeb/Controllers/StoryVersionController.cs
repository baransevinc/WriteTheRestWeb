using Microsoft.AspNetCore.Mvc;

namespace WriteTheRestWeb.Controllers
{
    public class StoryVersionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
