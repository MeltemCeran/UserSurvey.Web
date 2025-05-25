using Microsoft.AspNetCore.Mvc;
using UserInsightSurvey.Models.Concrete;

namespace UserInsightSurvey.Controllers
{
    public class AdminController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(AdminLoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewData["ErrorMessage"] = "Lütfen tüm alanları doldurun.";
                return View(model);
            }
            // Giriş işlemleri burada yapılacak
            ViewData["ErrorMessage"] = "Geçersiz giriş.";
            return View(model);
        }
    }
} 