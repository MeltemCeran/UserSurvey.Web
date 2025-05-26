using Microsoft.AspNetCore.Mvc;
using UserInsightSurvey.Managers.Abstract;
using UserInsightSurvey.Models.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using UserInsightSurvey.Data.Concrete;

namespace UserInsightSurvey.Controllers
{
    [Authorize]
    public class SurveyController : Controller
    {
        private readonly ISurveyManager _surveyManager;
        private readonly UserManager<User> _userManager;

        public SurveyController(ISurveyManager surveyManager, UserManager<User> userManager)
        {
            _surveyManager = surveyManager;
            _userManager = userManager;
        }

        // Anket sorularını ve seçeneklerini gösteren GET action
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            var questions = await _surveyManager.GetSurveyWithOptionsAndUserAnswersAsync(user.Id);
            return View(questions);
        }

        // Kullanıcı cevaplarını kaydeden POST action
        [HttpPost]
        public async Task<IActionResult> Index(List<SurveyQuestionViewModel> model)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
                return Unauthorized();
            try
            {
                await _surveyManager.SaveAnswersAsync(model, user.Id);
            }
            catch (System.InvalidOperationException ex)
            {
                ModelState.AddModelError("", ex.Message);
                var questions = await _surveyManager.GetSurveyWithOptionsAsync();
                return View(questions);
            }
            return RedirectToAction("Index", "Profile");
        }

        // Teşekkür sayfası
        public IActionResult Thanks()
        {
            return View();
        }
    }
} 