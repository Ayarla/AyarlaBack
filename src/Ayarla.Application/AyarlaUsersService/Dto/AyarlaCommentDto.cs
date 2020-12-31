using Abp.AutoMapper;
using Ayarla.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.AyarlaUsersService
{
    [AutoMapFrom(typeof(AyarlaComment))]
    public class AyarlaCommentDto
    {
        public int userId { get; set; }
        public string Comment { get; set; }
        public int accountId { get; set; }
        public int Stars { get; set; }
    }
}
