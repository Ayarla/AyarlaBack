using System;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using Ayarla.Authorization.Users;

namespace Ayarla.Users.Dto
{
    [AutoMapFrom(typeof(Comment))]
    public class CommentDto :  FullAuditedEntity<Guid>
    {
        public int UserId { get; set; }
        public string Comment { get; set; }
        public int AccountId { get; set; }
        public int Rating { get; set; }
    }
}