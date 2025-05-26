using UserInsightSurvey.Data.Concrete;
using UserInsightSurvey.Managers.Abstract;
using UserInsightSurvey.Repositories.Abstract;
using UserInsightSurvey.Models.Concrete;
using UserInsightSurvey.Common.Enums;

namespace UserInsightSurvey.Managers.Concrete
{
    public class SurveyManager : ISurveyManager
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly IAnswerRepository _answerRepository;

        public SurveyManager(IQuestionRepository questionRepository, IAnswerRepository answerRepository)
        {
            _questionRepository = questionRepository;
            _answerRepository = answerRepository;
        }

        // Kullanıcının verdiği cevapları veritabanına kaydeder
        public async Task SaveAnswersAsync(List<SurveyQuestionViewModel> questions, string userId)
        {
            // Kullanıcı daha önce cevapladıysa tekrar kaydetme
            var existingAnswers = _answerRepository.GetByUserId(userId);
            if (existingAnswers != null && existingAnswers.Any())
            {
                throw new System.InvalidOperationException("Bu anketi zaten cevapladınız. Birden fazla kez cevaplayamazsınız.");
            }

            var answers = new List<Answer>();
            foreach (var question in questions)
            {
                // Çoktan seçmeli
                if (question.SelectedOptionIds != null && question.SelectedOptionIds.Count > 0)
                {
                    foreach (var optionId in question.SelectedOptionIds)
                    {
                        answers.Add(new Answer
                        {
                            QuestionId = question.QuestionId,
                            OptionId = optionId,
                            Content = null,
                            UserId = userId
                        });
                    }
                }
                // Tekli seçim
                else if (question.SelectedOptionId.HasValue)
                {
                    answers.Add(new Answer
                    {
                        QuestionId = question.QuestionId,
                        OptionId = question.SelectedOptionId.Value,
                        Content = null,
                        UserId = userId
                    });
                }
                // Açık uçlu
                else if (!string.IsNullOrEmpty(question.AnswerText))
                {
                    answers.Add(new Answer
                    {
                        QuestionId = question.QuestionId,
                        OptionId = null,
                        Content = question.AnswerText,
                        UserId = userId
                    });
                }
            }
            foreach (var answer in answers)
            {
                _answerRepository.Add(answer);
            }
        }

        // Anket ekranında gösterilecek soruları ve seçenekleri getirir
        public async Task<List<SurveyQuestionViewModel>> GetSurveyWithOptionsAsync()
        {
            // Tüm aktif (silinmemiş) soruları çekiyoruz
            var questions = _questionRepository.GetAll().ToList();
            var result = new List<SurveyQuestionViewModel>();

            foreach (var question in questions)
            {
                // Her sorunun aktif (silinmemiş) seçeneklerini çekiyoruz
                var options = question.Options
                    .Where(o => o.DeletedDate == null)
                    .Select(o => new OptionViewModel
                    {
                        Id = o.Id,
                        Content = o.Content
                    }).ToList();

                // ViewModel'i dolduruyoruz (kullanıcıya gösterilecek veri)
                var viewModel = new SurveyQuestionViewModel
                {
                    QuestionId = question.Id,
                    Content = question.Content,
                    QuestionType = question.QuestionType,
                    Options = options
                };
                result.Add(viewModel);
            }
            // Tüm soruları ve seçenekleri içeren listeyi döndürüyoruz
            return result;
        }

        public async Task<List<SurveyQuestionViewModel>> GetSurveyWithOptionsAndUserAnswersAsync(string userId)
        {
            var questions = _questionRepository.GetAll().ToList();
            var userAnswers = _answerRepository.GetByUserId(userId).ToList();
            var result = new List<SurveyQuestionViewModel>();

            foreach (var question in questions)
            {
                var options = question.Options
                    .Where(o => o.DeletedDate == null)
                    .Select(o => new OptionViewModel
                    {
                        Id = o.Id,
                        Content = o.Content
                    }).ToList();

                var viewModel = new SurveyQuestionViewModel
                {
                    QuestionId = question.Id,
                    Content = question.Content,
                    QuestionType = question.QuestionType,
                    Options = options
                };

                // Cevapları doldur
                var answersForQuestion = userAnswers.Where(a => a.QuestionId == question.Id).ToList();
                if (question.QuestionType == QuestionType.SingleChoice)
                {
                    viewModel.SelectedOptionId = answersForQuestion.FirstOrDefault()?.OptionId;
                }
                else if (question.QuestionType == QuestionType.MultipleChoice)
                {
                    viewModel.SelectedOptionIds = answersForQuestion.Select(a => a.OptionId ?? 0).ToList();
                }
                else if (question.QuestionType == QuestionType.Text)
                {
                    viewModel.AnswerText = answersForQuestion.FirstOrDefault()?.Content;
                }

                result.Add(viewModel);
            }
            return result;
        }
    }
} 
