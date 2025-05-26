
using UserInsightSurvey.Data.Concrete;

namespace UserInsightSurvey.Repositories.Abstract
{
    public interface IOptionRepository
    {
        Option GetById(int id);
        IEnumerable<Option> GetAll();
        void Add(Option option);
        void Update(Option option);
        void Delete(int id); // Soft delete
        List<Option> GetOptionsByQuestionId(int questionId);
    }
} 