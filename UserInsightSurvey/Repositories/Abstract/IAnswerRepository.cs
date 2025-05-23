using System.Collections.Generic;
using UserInsightSurvey.Data.Concrete;

namespace UserInsightSurvey.Repositories.Abstract
{
    public interface IAnswerRepository
    {
        Answer GetById(int id);
        IEnumerable<Answer> GetAll();
        void Add(Answer answer);
        void Update(Answer answer);
        void Delete(int id); // Soft delete
    }
} 