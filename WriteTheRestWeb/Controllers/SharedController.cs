using Microsoft.AspNetCore.Mvc;

namespace WriteTheRestWeb.Controllers
{
    public class SharedController : Controller
    {
        public IActionResult _Layout()
        {
            return View();
        }
    }
}
