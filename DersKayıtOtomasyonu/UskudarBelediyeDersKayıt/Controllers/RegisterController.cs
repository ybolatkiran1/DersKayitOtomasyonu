using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;

public class RegisterController : Controller
{
    StudentManager sm = new StudentManager(new EFStudentRepository());

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(STUDENT s)
    {
        s.StudentPassword = HashPassword(s.StudentPassword);
        sm.StudentAdd(s);
        return RedirectToAction("Index", "Login");
    }

    private string HashPassword(string password)
    {
        using (SHA256 sha256Hash = SHA256.Create())
        {
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

            StringBuilder builder = new StringBuilder();
            foreach (byte b in bytes)
            {
                builder.Append(b.ToString("x2"));
            }
            return builder.ToString();
        }
    }
}