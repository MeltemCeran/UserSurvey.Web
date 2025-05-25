namespace UserInsightSurvey.Models.Concrete
{
    using System.ComponentModel.DataAnnotations;

    public class AdminLoginViewModel
    {
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }

        [Display(Name = "Şifre")]
        public string Password { get; set; }
    }
} 