using System.Collections.Generic;

namespace UserInsightSurvey.Models.Concrete
{
    public class QuestionAnswerDistributionViewModel
    {
        public string QuestionText { get; set; }
        public List<OptionCount> OptionCounts { get; set; } = new();
        public List<string> TextAnswers { get; set; } = new();
    }
} 