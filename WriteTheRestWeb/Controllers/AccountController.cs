using Microsoft.AspNetCore.Mvc;

namespace WriteTheRestWeb.Controllers
{
    public class AccountController : Controller
    {

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
        public IActionResult ResetPassword()
        {
            return View();
        }

        public IActionResult test()
        {
            return View();
        }
        public IActionResult EmailVerification()
        {
            return View();
        }
        public IActionResult SplashScreen()
        {
            return View();
        }
    }
}