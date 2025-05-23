using UserInsightSurvey.Data.Concrete;
using UserInsightSurvey.Context;
using UserInsightSurvey.Repositories.Abstract;

namespace UserInsightSurvey.Repositories.Concrete
{
	public class UserRepository : IUserRepository
	{
		private readonly UserSurveyDbContext _context;

		public UserRepository(UserSurveyDbContext context)
		{
			_context = context;
		}

		public User GetById(string id) => _context.Users.FirstOrDefault(u => u.Id == id && u.Deleted == null);

		public IEnumerable<User> GetAll() => _context.Users.Where(u => u.Deleted == null).ToList();

		public void Add(User user)
		{
			_context.Users.Add(user);
			_context.SaveChanges();
		}

		public void Update(User user)
		{
			_context.Users.Update(user);
			_context.SaveChanges();
		}

		public void Delete(int id)
		{
			var user = _context.Users.Find(id);
			if (user != null)
			{
				user.Deleted = DateTime.Now;
				_context.Users.Update(user);
				_context.SaveChanges();
			}
		}
	}
}
