using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserInsightSurvey.Common.Enums;
using UserInsightSurvey.Data.Concrete;

namespace UserInsightSurvey.Data.EntityConfiguration
{
	public class QuestionConfiguration : IEntityTypeConfiguration<Question>
	{
		public void Configure(EntityTypeBuilder<Question> builder)
		{
			builder.HasData(
				new Question { Id = 1, Content = "C# dilinde en çok kullandığınız özellik nedir?", MultipleChoice = false, QuestionType = QuestionType.Text, CreatedDate = new DateTime(2025, 5, 25) },
				new Question { Id = 2, Content = ".NET teknolojilerinden hangileriyle çalıştınız?", MultipleChoice = true, QuestionType = QuestionType.MultipleChoice, CreatedDate = new DateTime(2025, 5, 25) },
				new Question { Id = 3, Content = "En çok kullandığınız IDE hangisidir?", MultipleChoice = true, QuestionType = QuestionType.SingleChoice, CreatedDate = new DateTime(2025, 5, 25) },
				new Question { Id = 4, Content = "Entity Framework ile ilgili deneyiminizi kısaca anlatır mısınız?", MultipleChoice = false, QuestionType = QuestionType.Text, CreatedDate = new DateTime(2025, 5, 25) },
				new Question { Id = 5, Content = "Aşağıdaki mimari desenlerden hangilerini projelerinizde kullandınız?", MultipleChoice = true, QuestionType = QuestionType.MultipleChoice, CreatedDate = new DateTime(2025, 5, 25) },
				new Question { Id = 6, Content = ".NET Core ile .NET Framework arasındaki temel fark nedir?", MultipleChoice = false, QuestionType = QuestionType.Text, CreatedDate = new DateTime(2025, 5, 25) },
				new Question { Id = 7, Content = "Hangi veritabanı sistemleriyle çalıştınız?", MultipleChoice = true, QuestionType = QuestionType.MultipleChoice, CreatedDate = new DateTime(2025, 5, 25) },
				new Question { Id = 8, Content = "Bir web API projesinde en önemli gördüğünüz güvenlik önlemi nedir?", MultipleChoice = false, QuestionType = QuestionType.Text, CreatedDate = new DateTime(2025, 5, 25) },
				new Question { Id = 9, Content = "Aşağıdaki bulut servislerinden hangilerini kullandınız?", MultipleChoice = true, QuestionType = QuestionType.MultipleChoice, CreatedDate = new DateTime(2025, 5, 25) },
				new Question { Id = 10, Content = "Yazılım geliştirme sürecinde en çok hangi aşamada zorlanıyorsunuz?", MultipleChoice = true, QuestionType = QuestionType.SingleChoice, CreatedDate = new DateTime(2025, 5, 25) }
			);
		}
	}
}
