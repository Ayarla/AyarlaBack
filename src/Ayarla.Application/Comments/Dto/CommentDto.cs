using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Ayarla.Authorization.Users;

namespace Ayarla.Comments.Dto
{
    [AutoMapFrom(typeof(Comment))]
    public class CommentDto :  EntityDto<Guid>
    {
        public long? UserId { get; set; }
        
        public string Comment { get; set; }
        
        public Guid AccountId { get; set; }
        
        public int Rating { get; set; }
        
        public DateTime CreationTime { get; set; }
        
        public int Like { get; set; }

        public int Dislike { get; set; }
        
        
    }
}