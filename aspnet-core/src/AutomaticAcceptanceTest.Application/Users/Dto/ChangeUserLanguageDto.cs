using System.ComponentModel.DataAnnotations;

namespace AutomaticAcceptanceTest.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}