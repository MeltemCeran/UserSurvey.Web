using UserInsightSurvey.Data.Concrete;
using UserInsightSurvey.Context;
using UserInsightSurvey.Repositories.Abstract;

namespace UserInsightSurvey.Repositories.Concrete
{
    public class OptionRepository : IOptionRepository
    {
        private readonly UserSurveyDbContext _context;

        public OptionRepository(UserSurveyDbContext context)
        {
            _context = context;
        }

        public Option GetById(int id) => _context.Options.FirstOrDefault(o => o.Id == id && o.DeletedDate == null);

        public IEnumerable<Option> GetAll() => _context.Options.Where(o => o.DeletedDate == null).ToList();

        public void Add(Option option)
        {
            _context.Options.Add(option);
            _context.SaveChanges();
        }

        public void Update(Option option)
        {
            _context.Options.Update(option);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var option = _context.Options.Find(id);
            if (option != null)
            {
                option.DeletedDate = DateTime.Now;
                _context.Options.Update(option);
                _context.SaveChanges();
            }
        }

        public List<Option> GetOptionsByQuestionId(int questionId)
        {
            return _context.Options.Where(o => o.QuestionId == questionId && o.DeletedDate == null).ToList();
        }
    }
} 