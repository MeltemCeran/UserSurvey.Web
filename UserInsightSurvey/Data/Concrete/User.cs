using Microsoft.AspNetCore.Identity;
using UserInsightSurvey.Common.Enums;
using UserInsightSurvey.Data.Abstract;

namespace UserInsightSurvey.Data.Concrete
{
	public class User : IdentityUser
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public string CvFilePath { get; set; }
		public UserType UserType { get; set; }
		public ICollection<Answer>? Answers { get; set; } = new List<Answer>();
		public DateTime? Deleted { get; set; }
	}
}
