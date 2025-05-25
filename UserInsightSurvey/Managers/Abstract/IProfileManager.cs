using System.Threading.Tasks;
using UserInsightSurvey.Models.Concrete;

namespace UserInsightSurvey.Managers.Abstract
{
    public interface IProfileManager
    {
        Task<ProfileViewModel> GetProfileWithAnswersAsync(string email);
        Task<bool> UpdateProfileAsync(ProfileViewModel model);
    }
} 