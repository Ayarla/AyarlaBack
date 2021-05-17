using Abp.Application.Services.Dto;

namespace Ayarla.AyarlaAccounts.Dto
{
    public class PagedOpenClosedTimeResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
        
        public bool? IsActive { get; set; }  
    }
}