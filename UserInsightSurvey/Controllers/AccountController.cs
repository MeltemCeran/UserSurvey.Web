using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UserInsightSurvey.Models.Concrete;
using UserInsightSurvey.Data.Concrete;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;
using UserInsightSurvey.Common;
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
    }
}
