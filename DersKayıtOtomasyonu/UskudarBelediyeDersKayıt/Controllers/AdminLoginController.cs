using Microsoft.AspNetCore.Mvc;

namespace UskudarBelediyeDersKayıt.Controllers
{
    public class AdminLoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            // Admin kullanıcı adı ve şifresi için sabit değerler 
            string adminUsername = "admin";
            string adminPassword = "admin123";

            if (username == adminUsername && password == adminPassword)
            {
                HttpContext.Session.SetString("Admin", "true");
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                ViewBag.ErrorMessage = "Geçersiz kullanıcı adı veya şifre!";
                return View();
            }
        }

    }
}
