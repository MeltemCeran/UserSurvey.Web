using UserInsightSurvey.Models.Concrete;
using UserInsightSurvey.Repositories.Abstract;
using UserInsightSurvey.Managers.Abstract;

namespace UserInsightSurvey.Managers.Concrete
{
    public class DashboardManager : IDashboardManager
    {
        private readonly IUserRepository _userRepository;
        private readonly IAnswerRepository _answerRepository;
        private readonly IQuestionRepository _questionRepository;
        private readonly IOptionRepository _optionRepository;

        public DashboardManager(
            IUserRepository userRepository,
            IAnswerRepository answerRepository,
            IQuestionRepository questionRepository,
            IOptionRepository optionRepository)
        {
            _userRepository = userRepository;
            _answerRepository = answerRepository;
            _questionRepository = questionRepository;
            _optionRepository = optionRepository;
        }

        public async Task<DashboardStatsViewModel> GetSurveyStatsAsync()
        {
            var allUsers = _userRepository.GetAll().Where(u => u.UserType == Common.Enums.UserType.User).ToList();
            var totalUsers = allUsers.Count;
            var userIds = allUsers.Select(u => u.Id).ToList();
            var answers = _answerRepository.GetAllAnswers().Where(a => userIds.Contains(a.UserId)).ToList();
            var usersWithAnswers = answers.Select(a => a.UserId).Distinct().Count();
            var usersWithoutAnswers = totalUsers - usersWithAnswers;
            var totalQuestions = _questionRepository.GetActiveQuestionCount();
            var totalAnswers = answers.Count;
            return new DashboardStatsViewModel
            {
                TotalUsers = totalUsers,
                UsersWithAnswers = usersWithAnswers,
                UsersWithoutAnswers = usersWithoutAnswers,
                TotalQuestions = totalQuestions,
                TotalAnswers = totalAnswers
            };
        }

        public async Task<List<QuestionAnswerDistributionViewModel>> GetQuestionAnswerDistributionsAsync()
        {
            var allUsers = _userRepository.GetAll().Where(u => u.UserType == Common.Enums.UserType.User).ToList();
            var userIds = allUsers.Select(u => u.Id).ToList();
            var questions = _questionRepository.GetActiveQuestions();
            var answers = _answerRepository.GetAllAnswers().Where(a => userIds.Contains(a.UserId)).ToList();
            var result = new List<QuestionAnswerDistributionViewModel>();
            foreach (var question in questions)
            {
                var options = _optionRepository.GetOptionsByQuestionId(question.Id);
                var optionCounts = options
                    .Select(o => new OptionCount { OptionContent = o.Content, Count = answers.Count(a => a.OptionId == o.Id) })
                    .ToList();
                var textAnswers = new List<string>();
                if (question.QuestionType == Common.Enums.QuestionType.Text)
                {
                    textAnswers = answers.Where(a => a.QuestionId == question.Id && !string.IsNullOrEmpty(a.Content))
                                         .Select(a => a.Content)
                                         .ToList();
                }
                result.Add(new QuestionAnswerDistributionViewModel
                {
                    QuestionText = question.Content,
                    OptionCounts = optionCounts,
                    TextAnswers = textAnswers
                });
            }
            return result;
        }
    }
} 