using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UserInsightSurvey.Managers.Abstract;
using UserInsightSurvey.Models.Concrete;

namespace UserInsightSurvey.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        private readonly IProfileManager _profileManager;

        public ProfileController(IProfileManager profileManager)
        {
            _profileManager = profileManager;
        }

        public async Task<IActionResult> Index()
        {
            // Giriş yapan kullanıcının profil ve cevap bilgilerini getir
            var model = await _profileManager.GetProfileWithAnswersAsync(User.Identity.Name);
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit()
        {
            var model = await _profileManager.GetProfileWithAnswersAsync(User.Identity.Name);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ProfileViewModel model)
        {
            // Şifre alanlarından biri doluysa, ikisi de dolu ve eşit olmalı
            if (!string.IsNullOrEmpty(model.Password) || !string.IsNullOrEmpty(model.ConfirmPassword))
            {
                if (model.Password != model.ConfirmPassword)
                {
                    ModelState.AddModelError("ConfirmPassword", "Şifreler uyuşmuyor.");
                }
            }
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var (success, errorMessage) = await _profileManager.UpdateProfileAsync(model);
            if (success)
                return RedirectToAction("Index");
            ModelState.AddModelError("", errorMessage ?? "Güncelleme sırasında bir hata oluştu.");
            return View(model);
        }
    }
} 