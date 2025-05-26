using System.Collections.Generic;
using System.Threading.Tasks;
using UserInsightSurvey.Models.Concrete;

namespace UserInsightSurvey.Managers.Abstract
{
    public interface ISurveyManager
    {
        Task SaveAnswersAsync(List<SurveyQuestionViewModel> questions, string userId);
        Task<List<SurveyQuestionViewModel>> GetSurveyWithOptionsAsync();
        Task<List<SurveyQuestionViewModel>> GetSurveyWithOptionsAndUserAnswersAsync(string userId);
    }
} 