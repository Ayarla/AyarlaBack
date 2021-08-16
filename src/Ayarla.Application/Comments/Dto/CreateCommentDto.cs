using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using Ayarla.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;

namespace Ayarla.AyarlaUsersService
{
    [AutoMapTo(typeof(Comment))]
    
    public class CreateCommentDto 
    {

        public long? UserId { get; set; }
        
        public string UserComment { get; set; }
        public Guid AccountId { get; set; }
        
        public int Rating { get; set; }
        
        public int Like { get; set; }

        public int Dislike { get; set; }
        
        
    }
}
