using AutoMapper;
using Ayarla.Authorization.Users;

namespace Ayarla.Comments.Dto
{
    public class CommentMapProfile : Profile
    {
        public CommentMapProfile()
        {
            CreateMap<CommentDto, Comment>();
            CreateMap<Comment, CommentDto>();
        }
    }
}