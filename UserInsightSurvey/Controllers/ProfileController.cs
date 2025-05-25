using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UserInsightSurvey.Managers.Abstract;
using UserInsightSurvey.Models.Concrete;
using Microsoft.AspNetCore.Http;

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

        [HttpPost]
        public async Task<IActionResult> Update(ProfileViewModel model)
        {
            if (!ModelState.IsValid)
            {
                var currentModel = await _profileManager.GetProfileWithAnswersAsync(User.Identity.Name);
                return View("Index", currentModel);
            }
            var result = await _profileManager.UpdateProfileAsync(model);
            if (result)
                return RedirectToAction("Index");
            ModelState.AddModelError("", "Güncelleme sırasında bir hata oluştu.");
            var modelWithAnswers = await _profileManager.GetProfileWithAnswersAsync(User.Identity.Name);
            return View("Index", modelWithAnswers);
        }
    }
} 