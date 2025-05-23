using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using UserInsightSurvey.Models.Concrete;

namespace UserInsightSurvey.Managers.Abstract
{
	public interface IUserRegisterManager
	{
		Task<IdentityResult> RegisterUserAsync(RegisterViewModel model);
	}
}
