using System.ComponentModel.DataAnnotations;

namespace Ayarla.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}