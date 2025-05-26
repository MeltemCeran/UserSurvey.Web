using Microsoft.AspNetCore.Mvc;
using UserInsightSurvey.Models.Concrete;
using Microsoft.AspNetCore.Identity;
using UserInsightSurvey.Data.Concrete;
using UserInsightSurvey.Common.Enums;
using UserInsightSurvey.Managers.Abstract;

namespace UserInsightSurvey.Controllers
{
    public class AdminController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly IDashboardManager _dashboardManager;

        public AdminController(SignInManager<User> signInManager, UserManager<User> userManager, IDashboardManager dashboardManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _dashboardManager = dashboardManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(AdminLoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewData["ErrorMessage"] = "Lütfen tüm alanları doldurun.";
                return View(model);
            }

            var user = await _userManager.FindByNameAsync(model.UserName);
            if (user == null || user.UserType != UserType.Admin)
            {
                ViewData["ErrorMessage"] = "Geçersiz giriş.";
                return View(model);
            }

            var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, false);
            if (result.Succeeded)
            {
                return RedirectToAction("Dashboard", "Admin");
            }

            ViewData["ErrorMessage"] = "Geçersiz giriş.";
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Admin");
        }

        public async Task<IActionResult> Dashboard()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null || user.UserType != UserType.Admin)
            {
                return Forbid();
            }

            var stats = await _dashboardManager.GetSurveyStatsAsync();
            stats.QuestionDistributions = await _dashboardManager.GetQuestionAnswerDistributionsAsync();
            return View(stats);
        }
    }
} 