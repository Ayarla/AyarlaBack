using Abp.Application.Services.Dto;

namespace Ayarla.Services.Dto
{
    public class PagedEmployeeAccountResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
        
        public bool? IsActive { get; set; }  
    }
}