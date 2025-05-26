using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UserInsightSurvey.Models.Concrete;
using UserInsightSurvey.Data.Concrete;
using UserInsightSurvey.Managers.Abstract;

namespace UserInsightSurvey.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IUserRegisterManager _userRegisterManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IUserRegisterManager userRegisterManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _userRegisterManager = userRegisterManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _userRegisterManager.RegisterUserAsync(model);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Survey");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewData["ErrorMessage"] = "Lütfen tüm alanları doldurun.";
                return View(model);
            }

            var result = await _signInManager.PasswordSignInAsync(
                model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Profile");
            }

            ViewData["ErrorMessage"] = "Geçersiz giriş.";
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
    }
}
