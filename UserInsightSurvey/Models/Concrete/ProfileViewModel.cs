using System.ComponentModel.DataAnnotations;

namespace UserInsightSurvey.Models.Concrete
{
    public class ProfileViewModel
    {
        [Required(ErrorMessage = "Ad zorunludur.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad zorunludur.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "E-posta zorunludur.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta giriniz.")]
        public string Email { get; set; }

        public string? CvFilePath { get; set; }
        public List<UserAnswerViewModel>? Answers { get; set; }
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }
        public IFormFile? CvFile { get; set; }
    }
} 