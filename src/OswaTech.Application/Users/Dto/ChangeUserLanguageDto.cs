using System.ComponentModel.DataAnnotations;

namespace OswaTech.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}