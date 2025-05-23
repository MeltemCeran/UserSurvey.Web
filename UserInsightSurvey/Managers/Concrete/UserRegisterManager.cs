using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using UserInsightSurvey.Data.Concrete;
using UserInsightSurvey.Models.Concrete;
using UserInsightSurvey.Common;
using UserInsightSurvey.Managers.Abstract;

namespace UserInsightSurvey.Managers.Concrete
{
	public class UserRegisterManager : IUserRegisterManager
	{
		private readonly UserManager<User> _userManager;
		private readonly SignInManager<User> _signInManager;

		public UserRegisterManager(UserManager<User> userManager, SignInManager<User> signInManager)
		{
			_userManager = userManager;
			_signInManager = signInManager;
		}

		public async Task<IdentityResult> RegisterUserAsync(RegisterViewModel model)
		{
			string cvFilePath = "";
			if (model.CvFile != null && model.CvFile.Length > 0)
			{
				var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");
				Directory.CreateDirectory(uploadsFolder);
				var uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(model.CvFile.FileName);
				var filePath = Path.Combine(uploadsFolder, uniqueFileName);
				using (var stream = new FileStream(filePath, FileMode.Create))
				{
					await model.CvFile.CopyToAsync(stream);
				}
				cvFilePath = "/uploads/" + uniqueFileName;
			}

			var user = new User
			{
				Name = model.Name,
				Surname = model.Surname,
				Email = model.Email,
				UserName = model.Email,
				UserType = UserType.User,
				CvFilePath = cvFilePath
			};

			var result = await _userManager.CreateAsync(user, model.Password);

			if (result.Succeeded)
			{
				await _signInManager.SignInAsync(user, isPersistent: false);
			}

			return result;
		}
	}
}
