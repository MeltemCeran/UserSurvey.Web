using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using UserInsightSurvey.Common;

namespace UserInsightSurvey.Models.Concrete
{
	public class RegisterViewModel
	{
		[Required(ErrorMessage = "Ad zorunludur.")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Soyad zorunludur.")]
		public string Surname { get; set; }

		[Required(ErrorMessage = "Email zorunludur.")]
		[EmailAddress(ErrorMessage = "Geçerli bir email giriniz.")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Şifre zorunludur.")]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[Required(ErrorMessage = "Şifre tekrarı zorunludur.")]
		[DataType(DataType.Password)]
		[Compare("Password", ErrorMessage = "Şifreler uyuşmuyor.")]
		public string ConfirmPassword { get; set; }

		public IFormFile? CvFile { get; set; }
	}
}