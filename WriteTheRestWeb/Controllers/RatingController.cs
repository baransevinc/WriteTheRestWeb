using Microsoft.AspNetCore.Mvc;

namespace WriteTheRestWeb.Controllers
{
    public class RatingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
