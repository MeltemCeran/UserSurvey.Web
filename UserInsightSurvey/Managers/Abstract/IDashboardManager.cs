using UserInsightSurvey.Models.Concrete;

namespace UserInsightSurvey.Managers.Abstract
{
    public interface IDashboardManager
    {
        Task<DashboardStatsViewModel> GetSurveyStatsAsync();
        Task<List<QuestionAnswerDistributionViewModel>> GetQuestionAnswerDistributionsAsync();
    }
} 