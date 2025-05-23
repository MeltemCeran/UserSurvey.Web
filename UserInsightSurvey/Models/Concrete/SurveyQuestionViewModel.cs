using UserInsightSurvey.Common;

namespace UserInsightSurvey.Models.Concrete
{
	public class SurveyQuestionViewModel
	{
		public int QuestionId { get; set; }
		public string Content { get; set; }
		public QuestionType QuestionType { get; set; }
		public List<OptionViewModel> Options { get; set; } = new List<OptionViewModel>();

		// Kullanıcının verdiği cevaplar:
		public List<int> SelectedOptionIds { get; set; } = new List<int>(); // Çoklu seçim için
		public int? SelectedOptionId { get; set; } // Tekli seçim için
		public string? AnswerText { get; set; } // Açık uçlu için
	}
}
