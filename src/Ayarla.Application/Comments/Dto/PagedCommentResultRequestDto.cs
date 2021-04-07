using Abp.Application.Services.Dto;

namespace Ayarla.Comments.Dto
{
    public class PagedCommentResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
        
        public bool? IsActive { get; set; }
    }
}