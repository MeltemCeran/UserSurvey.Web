using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using UserInsightSurvey.Common;

namespace UserInsightSurvey.Models.Concrete
{
	public class RegisterViewModel
	{
		[Required(ErrorMessage = "Ad zorunludur.")]
		[Display(Name = "Ad")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Soyad zorunludur.")]
		[Display(Name = "Soyad")]
		public string Surname { get; set; }

		[Required(ErrorMessage = "Email zorunludur.")]
		[EmailAddress(ErrorMessage = "Geçerli bir email giriniz.")]
		[Display(Name = "E-posta")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Şifre zorunludur.")]
		[DataType(DataType.Password)]
		[Display(Name = "Şifre")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Şifre tekrarı zorunludur.")]
		[DataType(DataType.Password)]
		[Compare("Password", ErrorMessage = "Şifreler uyuşmuyor.")]
		[Display(Name = "Şifre Tekrar")]
		public string ConfirmPassword { get; set; }

		[Display(Name = "CV Yükle")]
		public IFormFile? CvFile { get; set; }
	}
}