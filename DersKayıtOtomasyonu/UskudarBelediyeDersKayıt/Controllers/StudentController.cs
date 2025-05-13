using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UskudarBelediyeDersKayıt.Controllers
{
    public class StudentController : Controller
    {
        StudentManager sm = new StudentManager(new EFStudentRepository());

        public IActionResult Index()
        {
            int? studentPeriod = HttpContext.Session.GetInt32("StudentPeriod");
            string studentName = HttpContext.Session.GetString("StudentName");
            bool studentStatus = HttpContext.Session.GetInt32("StudentStatus") == 1; // StudentStatus kontrolü
            if (studentPeriod.HasValue)
            {
                ViewBag.StudentPeriod = studentPeriod.Value;
            }
            ViewBag.StudentName = studentName;
            ViewBag.StudentStatus = studentStatus;
            return View();
        }

        public IActionResult UpdateStatus()
        {
            int? studentId = HttpContext.Session.GetInt32("StudentId");

            if (studentId.HasValue)
            {
                var student = sm.GetById(studentId.Value); // Öğrenciyi ID'ye göre bul
                if (student != null)
                {
                    student.StudentStatus = true; // StudentStatus değerini true yap
                    sm.StudentUpdate(student); // Güncellenen öğrenciyi kaydet
                }
            }

            return RedirectToAction("Index", "Login"); // İşlemden sonra sayfayı yenile
        }
        public IActionResult LeaveTraining()
        {
            int? studentId = HttpContext.Session.GetInt32("StudentId");

            if (studentId.HasValue)
            {
                var student = sm.GetById(studentId.Value); // Öğrenciyi ID'ye göre bul
                if (student != null)
                {
                    student.StudentStatus = false; // StudentStatus değerini false yap
                    sm.StudentUpdate(student); // Güncellenen öğrenciyi kaydet
                }
            }

            return RedirectToAction("Index", "Login"); // İşlemden sonra sayfayı yenile
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var student = sm.GetById(id); // ID ile öğrenci bulma
            if (student != null)
            {
                sm.StudentDelete(student); // Öğrenciyi silme
                return RedirectToAction("Index","Admin"); // Silme işlemi sonrası liste sayfasına yönlendirme
            }
            return NotFound(); // Öğrenci bulunamazsa 404 döndürme
        }

    }
}
