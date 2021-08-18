using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Runtime.Session;
using Ayarla.Authorization;
using Ayarla.Authorization.Accounts;
using Ayarla.Authorization.Users;
using Ayarla.AyarlaAccounts.Dto;
using Ayarla.AyarlaUsersService;
using Ayarla.Comments.Dto;
using Ayarla.Users.Dto;

namespace Ayarla.Comments
{
    [AbpAuthorize(PermissionNames.Pages_Users)]
    
    public class CommentAppService : AsyncCrudAppService<Comment,CommentDto,Guid,PagedCommentResultRequestDto,CreateCommentDto,CommentDto>,ICommentAppService
    {
       
        private readonly IRepository<Account,Guid> _accountRepository;
        
        public CommentAppService(
            IRepository<Comment, Guid> commentRepository,
            IRepository<Account,Guid> accountRepository) 
            : base(commentRepository)
        {
           
            _accountRepository = accountRepository;
        }
        
        public override async Task<CommentDto> CreateAsync(CreateCommentDto input)
        {
            CheckCreatePermission();
            
            var comment = ObjectMapper.Map<Comment>(input);

            comment.UserId = AbpSession.UserId;
            
            comment.CreationTime = DateTime.Now;

            await _accountRepository.GetAsync(input.AccountId);

            await Repository.InsertAsync(comment);

            CurrentUnitOfWork.SaveChanges();

            return ObjectMapper.Map<CommentDto>(comment);

        }

        public override async Task DeleteAsync(EntityDto<Guid> input)
        {
            CheckDeletePermission();
            
            var comment = await Repository.GetAsync(input.Id);

            await Repository.DeleteAsync(comment);

        }
    }
}