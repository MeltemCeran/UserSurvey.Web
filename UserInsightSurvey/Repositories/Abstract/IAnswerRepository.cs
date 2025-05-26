
using UserInsightSurvey.Data.Concrete;

namespace UserInsightSurvey.Repositories.Abstract
{
    public interface IAnswerRepository
    {
        Answer GetById(int id);
        IEnumerable<Answer> GetAll();
        IEnumerable<Answer> GetByUserId(string userId);
        void Add(Answer answer);
        void Update(Answer answer);
        void Delete(int id); // Soft delete
        int GetDistinctUserCount();
        List<Answer> GetAllAnswers();
        List<Answer> GetAnswersByUserId(string userId);
    }
} 