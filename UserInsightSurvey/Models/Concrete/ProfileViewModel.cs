using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace UserInsightSurvey.Models.Concrete
{
    public class ProfileViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string CvFilePath { get; set; }
        public List<UserAnswerViewModel> Answers { get; set; }
        public string Password { get; set; }
        public IFormFile? CvFile { get; set; }
    }
} 