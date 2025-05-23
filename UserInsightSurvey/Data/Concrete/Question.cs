using UserInsightSurvey.Common;
using UserInsightSurvey.Data.Abstract;

namespace UserInsightSurvey.Data.Concrete
{
	public class Question : BaseEntity
	{
		public string Content { get; set; }
		public bool MultipleChoice { get; set; }
		public ICollection<Answer>? Answers { get; set; } = new List<Answer>();
		public QuestionType QuestionType { get; set; }
		public ICollection<Option>? Options { get; set; } = new List<Option>();
	}
}
