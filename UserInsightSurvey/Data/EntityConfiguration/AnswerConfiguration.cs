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
                new Answer { Id = 1, UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c", QuestionId = 1, Content = "LINQ", CreatedDate = new DateTime(2025, 5, 25) },
                // Soru 2: MultipleChoice (ASP.NET Core, WPF)
                new Answer { Id = 2, UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c", QuestionId = 2, OptionId = 1, CreatedDate = new DateTime(2025, 5, 25) },
                new Answer { Id = 3, UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c", QuestionId = 2, OptionId = 3, CreatedDate = new DateTime(2025, 5, 25) },
                // Soru 3: SingleChoice (Visual Studio)
                new Answer { Id = 4, UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c", QuestionId = 3, OptionId = 5, CreatedDate = new DateTime(2025, 5, 25) },
                // Soru 4: Text
                new Answer { Id = 5, UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c", QuestionId = 4, Content = "Code First ile migration yönetimi deneyimim var.", CreatedDate = new DateTime(2025, 5, 25) },
                // Soru 5: MultipleChoice (MVC, Clean Architecture)
                new Answer { Id = 6, UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c", QuestionId = 5, OptionId = 9, CreatedDate = new DateTime(2025, 5, 25) },
                new Answer { Id = 7, UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c", QuestionId = 5, OptionId = 12, CreatedDate = new DateTime(2025, 5, 25) },
                // Soru 6: Text
                new Answer { Id = 8, UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c", QuestionId = 6, Content = ".NET Core platform bağımsızdır.", CreatedDate = new DateTime(2025, 5, 25) },
                // Soru 7: MultipleChoice (SQL Server, MongoDB)
                new Answer { Id = 9, UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c", QuestionId = 7, OptionId = 13, CreatedDate = new DateTime(2025, 5, 25) },
                new Answer { Id = 10, UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c", QuestionId = 7, OptionId = 16, CreatedDate = new DateTime(2025, 5, 25) },
                // Soru 8: Text
                new Answer { Id = 11, UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c", QuestionId = 8, Content = "JWT ile kimlik doğrulama kullanırım.", CreatedDate = new DateTime(2025, 5, 25) },
                // Soru 9: MultipleChoice (Azure)
                new Answer { Id = 12, UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c", QuestionId = 9, OptionId = 17, CreatedDate = new DateTime(2025, 5, 25) },
                // Soru 10: SingleChoice (Kodlama)
                new Answer { Id = 13, UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c", QuestionId = 10, OptionId = 23, CreatedDate = new DateTime(2025, 5, 25) },
                // Ali Vural'ın cevapları
                new Answer { Id = 101, UserId = "11111111-aaaa-bbbb-cccc-111111111111", QuestionId = 1, Content = "Delegates ve Events", CreatedDate = new DateTime(2025, 5, 25) },
                new Answer { Id = 102, UserId = "11111111-aaaa-bbbb-cccc-111111111111", QuestionId = 2, OptionId = 1, CreatedDate = new DateTime(2025, 5, 25) },
                new Answer { Id = 103, UserId = "11111111-aaaa-bbbb-cccc-111111111111", QuestionId = 2, OptionId = 3, CreatedDate = new DateTime(2025, 5, 25) },
                new Answer { Id = 104, UserId = "11111111-aaaa-bbbb-cccc-111111111111", QuestionId = 3, OptionId = 5, CreatedDate = new DateTime(2025, 5, 25) },
                new Answer { Id = 105, UserId = "11111111-aaaa-bbbb-cccc-111111111111", QuestionId = 4, Content = "Migration ve Code First tecrübem var.", CreatedDate = new DateTime(2025, 5, 25) },
                new Answer { Id = 106, UserId = "11111111-aaaa-bbbb-cccc-111111111111", QuestionId = 5, OptionId = 9, CreatedDate = new DateTime(2025, 5, 25) },
                new Answer { Id = 107, UserId = "11111111-aaaa-bbbb-cccc-111111111111", QuestionId = 5, OptionId = 12, CreatedDate = new DateTime(2025, 5, 25) },
                new Answer { Id = 108, UserId = "11111111-aaaa-bbbb-cccc-111111111111", QuestionId = 6, Content = ".NET Core platform bağımsızdır.", CreatedDate = new DateTime(2025, 5, 25) },
                new Answer { Id = 109, UserId = "11111111-aaaa-bbbb-cccc-111111111111", QuestionId = 7, OptionId = 13, CreatedDate = new DateTime(2025, 5, 25) },
                new Answer { Id = 110, UserId = "11111111-aaaa-bbbb-cccc-111111111111", QuestionId = 7, OptionId = 16, CreatedDate = new DateTime(2025, 5, 25) },
                new Answer { Id = 111, UserId = "11111111-aaaa-bbbb-cccc-111111111111", QuestionId = 8, Content = "JWT ile kimlik doğrulama kullanırım.", CreatedDate = new DateTime(2025, 5, 25) },
                new Answer { Id = 112, UserId = "11111111-aaaa-bbbb-cccc-111111111111", QuestionId = 9, OptionId = 17, CreatedDate = new DateTime(2025, 5, 25) },
                new Answer { Id = 113, UserId = "11111111-aaaa-bbbb-cccc-111111111111", QuestionId = 10, OptionId = 23, CreatedDate = new DateTime(2025, 5, 25) },
                // Zeynep Demir'in cevapları
                new Answer { Id = 201, UserId = "22222222-aaaa-bbbb-cccc-222222222222", QuestionId = 1, Content = "LINQ ve Lambda Expressions", CreatedDate = new DateTime(2025, 5, 25) },
                new Answer { Id = 202, UserId = "22222222-aaaa-bbbb-cccc-222222222222", QuestionId = 2, OptionId = 2, CreatedDate = new DateTime(2025, 5, 25) },
                new Answer { Id = 203, UserId = "22222222-aaaa-bbbb-cccc-222222222222", QuestionId = 2, OptionId = 4, CreatedDate = new DateTime(2025, 5, 25) },
                new Answer { Id = 204, UserId = "22222222-aaaa-bbbb-cccc-222222222222", QuestionId = 3, OptionId = 6, CreatedDate = new DateTime(2025, 5, 25) },
                new Answer { Id = 205, UserId = "22222222-aaaa-bbbb-cccc-222222222222", QuestionId = 4, Content = "Database First ile çalıştım.", CreatedDate = new DateTime(2025, 5, 25) },
                new Answer { Id = 206, UserId = "22222222-aaaa-bbbb-cccc-222222222222", QuestionId = 5, OptionId = 10, CreatedDate = new DateTime(2025, 5, 25) },
                new Answer { Id = 207, UserId = "22222222-aaaa-bbbb-cccc-222222222222", QuestionId = 5, OptionId = 11, CreatedDate = new DateTime(2025, 5, 25) },
                new Answer { Id = 208, UserId = "22222222-aaaa-bbbb-cccc-222222222222", QuestionId = 6, Content = ".NET Core açık kaynaklıdır.", CreatedDate = new DateTime(2025, 5, 25) },
                new Answer { Id = 209, UserId = "22222222-aaaa-bbbb-cccc-222222222222", QuestionId = 7, OptionId = 14, CreatedDate = new DateTime(2025, 5, 25) },
                new Answer { Id = 210, UserId = "22222222-aaaa-bbbb-cccc-222222222222", QuestionId = 7, OptionId = 15, CreatedDate = new DateTime(2025, 5, 25) },
                new Answer { Id = 211, UserId = "22222222-aaaa-bbbb-cccc-222222222222", QuestionId = 8, Content = "OAuth2 ile güvenlik sağlarım.", CreatedDate = new DateTime(2025, 5, 25) },
                new Answer { Id = 212, UserId = "22222222-aaaa-bbbb-cccc-222222222222", QuestionId = 9, OptionId = 18, CreatedDate = new DateTime(2025, 5, 25) },
                new Answer { Id = 213, UserId = "22222222-aaaa-bbbb-cccc-222222222222", QuestionId = 10, OptionId = 24, CreatedDate = new DateTime(2025, 5, 25) },
                // Mehmet Kaya'nın cevapları
                new Answer { Id = 301, UserId = "33333333-aaaa-bbbb-cccc-333333333333", QuestionId = 1, Content = "Async/Await kullanımı", CreatedDate = new DateTime(2025, 5, 25) },
                new Answer { Id = 302, UserId = "33333333-aaaa-bbbb-cccc-333333333333", QuestionId = 2, OptionId = 1, CreatedDate = new DateTime(2025, 5, 25) },
                new Answer { Id = 303, UserId = "33333333-aaaa-bbbb-cccc-333333333333", QuestionId = 2, OptionId = 2, CreatedDate = new DateTime(2025, 5, 25) },
                new Answer { Id = 304, UserId = "33333333-aaaa-bbbb-cccc-333333333333", QuestionId = 3, OptionId = 7, CreatedDate = new DateTime(2025, 5, 25) },
                new Answer { Id = 305, UserId = "33333333-aaaa-bbbb-cccc-333333333333", QuestionId = 4, Content = "EF Core ile performans optimizasyonu yaptım.", CreatedDate = new DateTime(2025, 5, 25) },
                new Answer { Id = 306, UserId = "33333333-aaaa-bbbb-cccc-333333333333", QuestionId = 5, OptionId = 9, CreatedDate = new DateTime(2025, 5, 25) },
                new Answer { Id = 307, UserId = "33333333-aaaa-bbbb-cccc-333333333333", QuestionId = 5, OptionId = 10, CreatedDate = new DateTime(2025, 5, 25) },
                new Answer { Id = 308, UserId = "33333333-aaaa-bbbb-cccc-333333333333", QuestionId = 6, Content = ".NET Core hızlıdır.", CreatedDate = new DateTime(2025, 5, 25) },
                new Answer { Id = 309, UserId = "33333333-aaaa-bbbb-cccc-333333333333", QuestionId = 7, OptionId = 13, CreatedDate = new DateTime(2025, 5, 25) },
                new Answer { Id = 310, UserId = "33333333-aaaa-bbbb-cccc-333333333333", QuestionId = 7, OptionId = 15, CreatedDate = new DateTime(2025, 5, 25) },
                new Answer { Id = 311, UserId = "33333333-aaaa-bbbb-cccc-333333333333", QuestionId = 8, Content = "HTTPS zorunlu kullanırım.", CreatedDate = new DateTime(2025, 5, 25) },
                new Answer { Id = 312, UserId = "33333333-aaaa-bbbb-cccc-333333333333", QuestionId = 9, OptionId = 19, CreatedDate = new DateTime(2025, 5, 25) },
                new Answer { Id = 313, UserId = "33333333-aaaa-bbbb-cccc-333333333333", QuestionId = 10, OptionId = 25, CreatedDate = new DateTime(2025, 5, 25) }
            );
        }
    }
} 