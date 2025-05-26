using Microsoft.AspNetCore.Identity;
using UserInsightSurvey.Managers.Abstract;
using UserInsightSurvey.Models.Concrete;
using UserInsightSurvey.Repositories.Abstract;
using UserInsightSurvey.Data.Concrete;

namespace UserInsightSurvey.Managers.Concrete
{
    public class ProfileManager : IProfileManager
    {
        private readonly IUserRepository _userRepository;
        private readonly IQuestionRepository _questionRepository;
        private readonly IAnswerRepository _answerRepository;
        private readonly UserManager<User> _userManager;

        public ProfileManager(IUserRepository userRepository, IQuestionRepository questionRepository, IAnswerRepository answerRepository, UserManager<User> userManager)
        {
            _userRepository = userRepository;
            _questionRepository = questionRepository;
            _answerRepository = answerRepository;
            _userManager = userManager;
        }

        public async Task<ProfileViewModel> GetProfileWithAnswersAsync(string email)
        {
            var user = _userRepository.GetByEmail(email);
            if (user == null) return null;

            var allQuestions = _questionRepository.GetActiveQuestions();
            var answers = _answerRepository.GetAnswersByUserId(user.Id);

            var answerViewModels = new List<UserAnswerViewModel>();
            foreach (var question in allQuestions)
            {
                var userAnswers = answers.Where(a => a.QuestionId == question.Id).ToList();
                if (userAnswers.Any())
                {
                    foreach (var ans in userAnswers)
                    {
                        answerViewModels.Add(new UserAnswerViewModel
                        {
                            QuestionText = question.Content,
                            AnswerText = ans.Content,
                            OptionContent = ans.Option != null ? ans.Option.Content : null
                        });
                    }
                }
                else
                {
                    answerViewModels.Add(new UserAnswerViewModel
                    {
                        QuestionText = question.Content,
                        AnswerText = "-",
                        OptionContent = "-"
                    });
                }
            }

            return new ProfileViewModel
            {
                Name = user.Name,
                Surname = user.Surname,
                Email = user.Email,
                CvFilePath = user.CvFilePath,
                Answers = answerViewModels
            };
        }

        public async Task<(bool Success, string ErrorMessage)> UpdateProfileAsync(ProfileViewModel model)
        {
            var user = _userRepository.GetByEmail(model.Email);
            if (user == null) return (false, "Kullanıcı bulunamadı.");

            user.Name = model.Name;
            user.Surname = model.Surname;
            user.Email = model.Email;
            user.UserName = model.Email;

            if (!string.IsNullOrEmpty(model.Password))
            {
                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                var result = await _userManager.ResetPasswordAsync(user, token, model.Password);
                if (!result.Succeeded)
                {
                    var errorMsg = string.Join("; ", result.Errors.Select(e => e.Description));
                    return (false, errorMsg);
                }
            }

            if (model.CvFile != null && model.CvFile.Length > 0)
            {
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", "cv");
                Directory.CreateDirectory(uploadsFolder);
                var uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(model.CvFile.FileName);
                var filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await model.CvFile.CopyToAsync(stream);
                }
                user.CvFilePath = "/uploads/cv/" + uniqueFileName;
            }

            _userRepository.Update(user);
            return (true, null);
        }
    }
} 