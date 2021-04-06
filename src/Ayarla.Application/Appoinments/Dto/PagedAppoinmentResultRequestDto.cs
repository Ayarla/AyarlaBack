using Abp.Application.Services.Dto;

namespace Ayarla.Users.Dto
{
    public class PagedAppoinmentResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
        
        public bool? IsActive { get; set; }
    }
}