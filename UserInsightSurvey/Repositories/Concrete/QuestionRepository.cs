using System;
using System.Collections.Generic;
using System.Linq;
using UserInsightSurvey.Data.Concrete;
using UserInsightSurvey.Context;
using UserInsightSurvey.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace UserInsightSurvey.Repositories.Concrete
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly UserSurveyDbContext _context;

        public QuestionRepository(UserSurveyDbContext context)
        {
            _context = context;
        }

        public Question GetById(int id) => _context.Questions.FirstOrDefault(q => q.Id == id && q.DeletedDate == null);

        public IEnumerable<Question> GetAll() =>
            _context.Questions
                .Include(q => q.Options)
                .Where(q => q.DeletedDate == null)
                .ToList();

        public void Add(Question question)
        {
            _context.Questions.Add(question);
            _context.SaveChanges();
        }

        public void Update(Question question)
        {
            _context.Questions.Update(question);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var question = _context.Questions.Find(id);
            if (question != null)
            {
                question.DeletedDate = DateTime.Now;
                _context.Questions.Update(question);
                _context.SaveChanges();
            }
        }

        public int GetActiveQuestionCount() => _context.Questions.Count(q => q.DeletedDate == null);
        public List<Question> GetActiveQuestions() => _context.Questions.Where(q => q.DeletedDate == null).ToList();
    }
} 