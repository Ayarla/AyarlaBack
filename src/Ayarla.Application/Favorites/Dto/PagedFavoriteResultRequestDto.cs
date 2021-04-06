using Abp.Application.Services.Dto;

namespace Ayarla.Favorites.Dto
{
    public class PagedFavoriteResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
        
        public bool? IsActive { get; set; }
    }
}