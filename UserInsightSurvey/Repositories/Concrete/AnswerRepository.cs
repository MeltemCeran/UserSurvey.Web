using System;
using System.Collections.Generic;
using System.Linq;
using UserInsightSurvey.Data.Concrete;
using UserInsightSurvey.Context;
using UserInsightSurvey.Repositories.Abstract;

namespace UserInsightSurvey.Repositories.Concrete
{
    public class AnswerRepository : IAnswerRepository
    {
        private readonly UserSurveyDbContext _context;

        public AnswerRepository(UserSurveyDbContext context)
        {
            _context = context;
        }

        public Answer GetById(int id) => _context.Answers.FirstOrDefault(a => a.Id == id && a.DeletedDate == null);

        public IEnumerable<Answer> GetAll() => _context.Answers.Where(a => a.DeletedDate == null).ToList();

        public void Add(Answer answer)
        {
            _context.Answers.Add(answer);
            _context.SaveChanges();
        }

        public void Update(Answer answer)
        {
            _context.Answers.Update(answer);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var answer = _context.Answers.Find(id);
            if (answer != null)
            {
                answer.DeletedDate = DateTime.Now;
                _context.Answers.Update(answer);
                _context.SaveChanges();
            }
        }
    }
} 