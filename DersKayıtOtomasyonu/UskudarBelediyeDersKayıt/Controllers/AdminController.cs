using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;

namespace UskudarBelediyeDersKayıt.Controllers
{
    public class AdminController : Controller
    {
        private readonly StudentManager _studentManager;

       
        public AdminController()
        {
            _studentManager = new StudentManager(new EFStudentRepository());
        }

        public IActionResult Index()
        {
           
            if (HttpContext.Session.GetString("Admin") == "true")
            {
                
                var students = _studentManager.GetList();
                return View(students);
            }
            else
            {
               
                return RedirectToAction("Index", "AdminLogin");
            }
        }
    }
}
