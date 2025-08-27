using Microsoft.AspNetCore.Mvc;

namespace WriteTheRestWeb.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
