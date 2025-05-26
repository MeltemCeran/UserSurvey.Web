using System.Collections.Generic;
using UserInsightSurvey.Data.Concrete;

namespace UserInsightSurvey.Repositories.Abstract
{
	public interface IUserRepository
	{
		User GetById(string id);
		IEnumerable<User> GetAll();
		void Add(User user);
		void Update(User user);
		void Delete(int id);
		int GetTotalUserCount();
		int GetUserWithAnswersCount();
		User GetByEmail(string email);
	}
}
