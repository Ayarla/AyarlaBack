using Abp.AutoMapper;
using Ayarla.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.AyarlaUsersService
{
    [AutoMapFrom(typeof(Comment))]
    public class CommentDto
    {
        public int UserId { get; set; }
        public string Comment { get; set; }
        public int AccountId { get; set; }
        public int Stars { get; set; }
    }
}
