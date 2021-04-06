using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using Ayarla.Authorization.Users;

namespace Ayarla.Users.Dto
{
    [AutoMapFrom(typeof(Comment))]
    public class CommentDto :  FullAuditedEntityDto<Guid>
    {
        public static long? UserId { get; set; }
        public string Comment { get; set; }
        public Guid AccountId { get; set; }
        public int Rating { get; set; }
    }
}