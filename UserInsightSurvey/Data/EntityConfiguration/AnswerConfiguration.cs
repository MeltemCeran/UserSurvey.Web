using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserInsightSurvey.Data.Concrete;

namespace UserInsightSurvey.Data.EntityConfiguration
{
    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.HasData(
                // Soru 1: Text
                new Answer { Id = 1, UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c", QuestionId = 1, Content = "LINQ" },
                // Soru 2: MultipleChoice (ASP.NET Core, WPF)
                new Answer { Id = 2, UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c", QuestionId = 2, OptionId = 1 },
                new Answer { Id = 3, UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c", QuestionId = 2, OptionId = 3 },
                // Soru 3: SingleChoice (Visual Studio)
                new Answer { Id = 4, UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c", QuestionId = 3, OptionId = 5 },
                // Soru 4: Text
                new Answer { Id = 5, UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c", QuestionId = 4, Content = "Code First ile migration yönetimi deneyimim var." },
                // Soru 5: MultipleChoice (MVC, Clean Architecture)
                new Answer { Id = 6, UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c", QuestionId = 5, OptionId = 9 },
                new Answer { Id = 7, UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c", QuestionId = 5, OptionId = 12 },
                // Soru 6: Text
                new Answer { Id = 8, UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c", QuestionId = 6, Content = ".NET Core platform bağımsızdır." },
                // Soru 7: MultipleChoice (SQL Server, MongoDB)
                new Answer { Id = 9, UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c", QuestionId = 7, OptionId = 13 },
                new Answer { Id = 10, UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c", QuestionId = 7, OptionId = 16 },
                // Soru 8: Text
                new Answer { Id = 11, UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c", QuestionId = 8, Content = "JWT ile kimlik doğrulama kullanırım." },
                // Soru 9: MultipleChoice (Azure)
                new Answer { Id = 12, UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c", QuestionId = 9, OptionId = 17 },
                // Soru 10: SingleChoice (Kodlama)
                new Answer { Id = 13, UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c", QuestionId = 10, OptionId = 23 }
            );
        }
    }
} 