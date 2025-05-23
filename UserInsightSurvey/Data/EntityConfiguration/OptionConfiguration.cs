using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserInsightSurvey.Data.Concrete;

namespace UserInsightSurvey.Data.EntityConfiguration
{
	public class OptionConfiguration : IEntityTypeConfiguration<Option>
	{
		public void Configure(EntityTypeBuilder<Option> builder)
		{
			builder.HasData(
			// Soru 2: .NET teknolojilerinden hangileriyle çalıştınız? (MultipleChoice)
			new Option { Id = 1, Content = "ASP.NET Core", QuestionId = 2 },
			new Option { Id = 2, Content = "WinForms", QuestionId = 2 },
			new Option { Id = 3, Content = "WPF", QuestionId = 2 },
			new Option { Id = 4, Content = "Blazor", QuestionId = 2 },

			// Soru 3: En çok kullandığınız IDE hangisidir? (SingleChoice)
			new Option { Id = 5, Content = "Visual Studio", QuestionId = 3 },
			new Option { Id = 6, Content = "Rider", QuestionId = 3 },
			new Option { Id = 7, Content = "VS Code", QuestionId = 3 },
			new Option { Id = 8, Content = "Diğer", QuestionId = 3 },

			// Soru 5: Hangi mimari desenleri kullandınız? (MultipleChoice)
			new Option { Id = 9, Content = "MVC", QuestionId = 5 },
			new Option { Id = 10, Content = "MVVM", QuestionId = 5 },
			new Option { Id = 11, Content = "Onion Architecture", QuestionId = 5 },
			new Option { Id = 12, Content = "Clean Architecture", QuestionId = 5 },

			// Soru 7: Hangi veritabanı sistemleriyle çalıştınız? (MultipleChoice)
			new Option { Id = 13, Content = "SQL Server", QuestionId = 7 },
			new Option { Id = 14, Content = "PostgreSQL", QuestionId = 7 },
			new Option { Id = 15, Content = "MySQL", QuestionId = 7 },
			new Option { Id = 16, Content = "MongoDB", QuestionId = 7 },

			// Soru 9: Hangi bulut servislerini kullandınız? (MultipleChoice)
			new Option { Id = 17, Content = "Azure", QuestionId = 9 },
			new Option { Id = 18, Content = "AWS", QuestionId = 9 },
			new Option { Id = 19, Content = "Google Cloud", QuestionId = 9 },
			new Option { Id = 20, Content = "Hiçbiri", QuestionId = 9 },

			// Soru 10: Yazılım geliştirme sürecinde en çok hangi aşamada zorlanıyorsunuz? (SingleChoice)
			new Option { Id = 21, Content = "Analiz", QuestionId = 10 },
			new Option { Id = 22, Content = "Tasarım", QuestionId = 10 },
			new Option { Id = 23, Content = "Kodlama", QuestionId = 10 },
			new Option { Id = 24, Content = "Test", QuestionId = 10 },
			new Option { Id = 25, Content = "Bakım", QuestionId = 10 }
);
		}
	}
}
