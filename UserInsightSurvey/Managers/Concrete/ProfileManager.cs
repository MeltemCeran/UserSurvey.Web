using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UserInsightSurvey.Context;
using UserInsightSurvey.Managers.Abstract;
using UserInsightSurvey.Models.Concrete;
using Microsoft.AspNetCore.Http;
using System.IO;
using UserInsightSurvey.Repositories.Abstract;
using Microsoft.AspNetCore.Identity;

namespace UserInsightSurvey.Managers.Concrete
{
    public class ProfileManager : IProfileManager
    {
        private readonly UserSurveyDbContext _context;
        private readonly IUserRepository _userRepository;
        private readonly UserManager<User> _userManager;

        public ProfileManager(UserSurveyDbContext context, IUserRepository userRepository, UserManager<User> userManager)
        {
            _context = context;
            _userRepository = userRepository;
            _userManager = userManager;
        }

        public async Task<ProfileViewModel> GetProfileWithAnswersAsync(string email)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
            if (user == null) return null;

            var answers = await _context.Answers
                .Where(a => a.UserId == user.Id)
                .Include(a => a.Question)
                .Select(a => new UserAnswerViewModel
                {
                    QuestionText = a.Question.Content,
                    AnswerText = a.Content
                })
                .ToListAsync();

            return new ProfileViewModel
            {
                Name = user.Name,
                Surname = user.Surname,
                Email = user.Email,
                CvFilePath = user.CvFilePath,
                Answers = answers
            };
        }

        public async Task<bool> UpdateProfileAsync(ProfileViewModel model)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == model.Email);
            if (user == null) return false;

            user.Name = model.Name;
            user.Surname = model.Surname;
            user.Email = model.Email;
            user.UserName = model.Email;

            if (!string.IsNullOrEmpty(model.Password))
            {
                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                var result = await _userManager.ResetPasswordAsync(user, token, model.Password);
                if (!result.Succeeded) return false;
            }

            if (model.CvFile != null && model.CvFile.Length > 0)
            {
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");
                Directory.CreateDirectory(uploadsFolder);
                var uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(model.CvFile.FileName);
                var filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await model.CvFile.CopyToAsync(stream);
                }
                user.CvFilePath = "/uploads/" + uniqueFileName;
            }

            _userRepository.Update(user);
            return true;
        }
    }
} 