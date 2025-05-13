using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using System.Security.Cryptography;
using System.Text;

namespace UskudarBelediyeDersKayıt.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Index(STUDENT s)
        {
            Context c = new Context();

            // Kullanıcının girdiği şifreyi hashleyelim
            string hashedPassword = HashPassword(s.StudentPassword);

            // Hashlenmiş şifreyi veri tabanındaki şifre ile karşılaştıralım
            var datavalue = c.STUDENTS.FirstOrDefault(x => x.StudentMail == s.StudentMail && x.StudentPassword == hashedPassword);

            if (datavalue != null)
            {
                HttpContext.Session.SetInt32("StudentId", datavalue.StudentID); // StudentId'yi session'da sakla
                HttpContext.Session.SetInt32("StudentPeriod", datavalue.StudentPeriod);
                HttpContext.Session.SetString("StudentName", datavalue.StudentName);
                HttpContext.Session.SetInt32("StudentStatus", datavalue.StudentStatus ? 1 : 0); // StudentStatus'u session'da sakla

                return Json(new { success = true });
            }
            else
            {
                return Json(new { success = false });
            }
        }

        // Şifreyi hashlemek için kullanılacak fonksiyon
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
}
