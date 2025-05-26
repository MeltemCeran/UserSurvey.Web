using UserInsightSurvey.Data.Abstract;

namespace UserInsightSurvey.Data.Concrete
{
	public class Answer : BaseEntity
	{
		public string UserId { get; set; }
		public int QuestionId { get; set; }
		public int? OptionId { get; set; }
		public string? Content { get; set; }
		public User User { get; set; }
		public Question Question { get; set; }
		public Option Option { get; set; }
	}
}
