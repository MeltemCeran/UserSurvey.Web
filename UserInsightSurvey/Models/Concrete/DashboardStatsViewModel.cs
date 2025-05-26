using System.Collections.Generic;

namespace UserInsightSurvey.Models.Concrete
{
    public class DashboardStatsViewModel
    {
        public int TotalUsers { get; set; }
        public int UsersWithAnswers { get; set; }
        public int UsersWithoutAnswers { get; set; }
        public int TotalQuestions { get; set; }
        public int TotalAnswers { get; set; }
        public List<QuestionAnswerDistributionViewModel> QuestionDistributions { get; set; } = new();
    }
} 