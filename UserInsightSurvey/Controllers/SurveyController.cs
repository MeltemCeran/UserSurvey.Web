using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UserInsightSurvey.Managers.Abstract;
using UserInsightSurvey.Models.Concrete;
using System.Collections.Generic;
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
            var questions = await _surveyManager.GetSurveyWithOptionsAsync();
            return View(questions);
        }

        // Kullanıcı cevaplarını kaydeden POST action
        [HttpPost]
        public async Task<IActionResult> Index(List<SurveyQuestionViewModel> model)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
                return Unauthorized();

            await _surveyManager.SaveAnswersAsync(model, user.Id);
            return RedirectToAction("Thanks");
        }

        // Teşekkür sayfası
        public IActionResult Thanks()
        {
            return View();
        }
    }
} 