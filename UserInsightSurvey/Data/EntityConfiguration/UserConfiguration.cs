using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserInsightSurvey.Data.Concrete;
using Microsoft.AspNetCore.Identity;
using UserInsightSurvey.Common;

namespace UserInsightSurvey.Data.EntityConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            var hasher = new PasswordHasher<User>();
            var user = new User
            {
                Id = "252d1809-cd07-4ebd-87d1-83cefac3b78c",
                Name = "Test",
                Surname = "Kullanıcı",
                Email = "test@demo.com",
                NormalizedEmail = "TEST@DEMO.COM",
                UserName = "test@demo.com",
                NormalizedUserName = "TEST@DEMO.COM",
                EmailConfirmed = true,
                UserType = UserType.User,
                CvFilePath = ""
            };
            user.PasswordHash = hasher.HashPassword(user, "Test123!");
            builder.HasData(user);
        }
    }
} 