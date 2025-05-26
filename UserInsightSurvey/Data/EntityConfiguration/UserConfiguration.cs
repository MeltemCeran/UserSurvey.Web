using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserInsightSurvey.Data.Concrete;
using Microsoft.AspNetCore.Identity;
using UserInsightSurvey.Common.Enums;

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
                CvFilePath = "",
                PasswordHash = hasher.HashPassword(null, "Test123!")
            };
            builder.HasData(user);

            builder.HasData(new User
            {
                Id = "11111111-aaaa-bbbb-cccc-111111111111",
                Name = "Ali",
                Surname = "Vural",
                Email = "ali.vural@example.com",
                NormalizedEmail = "ALI.VURAL@EXAMPLE.COM",
                UserName = "ali.vural@example.com",
                NormalizedUserName = "ALI.VURAL@EXAMPLE.COM",
                EmailConfirmed = true,
                UserType = UserType.User,
                CvFilePath = "",
                PasswordHash = hasher.HashPassword(null, "Test123!")
            });
            builder.HasData(new User
            {
                Id = "22222222-aaaa-bbbb-cccc-222222222222",
                Name = "Zeynep",
                Surname = "Demir",
                Email = "zeynep.demir@example.com",
                NormalizedEmail = "ZEYNEP.DEMIR@EXAMPLE.COM",
                UserName = "zeynep.demir@example.com",
                NormalizedUserName = "ZEYNEP.DEMIR@EXAMPLE.COM",
                EmailConfirmed = true,
                UserType = UserType.User,
                CvFilePath = "",
                PasswordHash = hasher.HashPassword(null, "Test123!")
            });
            builder.HasData(new User
            {
                Id = "33333333-aaaa-bbbb-cccc-333333333333",
                Name = "Mehmet",
                Surname = "Kaya",
                Email = "mehmet.kaya@example.com",
                NormalizedEmail = "MEHMET.KAYA@EXAMPLE.COM",
                UserName = "mehmet.kaya@example.com",
                NormalizedUserName = "MEHMET.KAYA@EXAMPLE.COM",
                EmailConfirmed = true,
                UserType = UserType.User,
                CvFilePath = "",
                PasswordHash = hasher.HashPassword(null, "Test123!")
            });
            builder.HasData(new User
            {
                Id = "99999999-aaaa-bbbb-cccc-999999999999",
                Name = "Admin",
                Surname = "Yönetici",
                Email = "admin@demo.com",
                NormalizedEmail = "ADMIN@DEMO.COM",
                UserName = "admin@demo.com",
                NormalizedUserName = "ADMIN@DEMO.COM",
                EmailConfirmed = true,
                UserType = UserType.Admin,
                CvFilePath = "",
                PasswordHash = hasher.HashPassword(null, "Admin123!")
            });
        }
    }
} 