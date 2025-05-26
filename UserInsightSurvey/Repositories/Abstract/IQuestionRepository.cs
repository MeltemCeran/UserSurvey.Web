using System.Collections.Generic;
using UserInsightSurvey.Data.Concrete;

namespace UserInsightSurvey.Repositories.Abstract
{
    public interface IQuestionRepository
    {
        Question GetById(int id);
        IEnumerable<Question> GetAll();
        void Add(Question question);
        void Update(Question question);
        void Delete(int id);
        int GetActiveQuestionCount();
        List<Question> GetActiveQuestions();
    }
} 