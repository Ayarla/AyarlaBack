using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Ayarla.Authorization.Accounts;
using Ayarla.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.AyarlaAccounts.Dto
{
    [AutoMapFrom(typeof(Account))]
    public class AccountDto : EntityDto<Guid>
    {
        public long? UserId { get; set; }
        
        public string Phone1 { get; set; }

        public string Phone2 { get; set; }

        public string Phone3 { get; set; }
        public string Address { get { return AddressDetail + "," + District + "/" + City; } }

        public string AccountName { get; set; }

        public string AccountImage { get; set; }

        public Gender Gender { get; set; }

        public string AccountNotes { get; set; }

        public string AddressDetail { get; set; }

        public string District { get; set; }

        public string City { get; set; }
        
        public virtual ICollection<OpenCloseTimeDto> OpenCloseTimes { get; set; }

        public string Location { get; set; }
        
        public int CommentNumber { get; set; }
    }
}
