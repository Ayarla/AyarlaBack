using System;
using Abp.Application.Services;
using Ayarla.AyarlaUsersService;
using Ayarla.Comments.Dto;
using Ayarla.Users.Dto;

namespace Ayarla.Comments
{
    public interface ICommentAppService : IAsyncCrudAppService<CommentDto,Guid,PagedCommentResultRequestDto,CreateCommentDto,CommentDto>
    {
        
    }
}