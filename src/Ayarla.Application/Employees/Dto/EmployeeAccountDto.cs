using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Ayarla.Authorization.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.Services.Dto
{
    [AutoMapFrom(typeof(EmployeeAccount))]
    public class EmployeeAccountDto : FullAuditedEntityDto<Guid>
    {
        public string Phone1 { get; set; }

        public string Phone2 { get; set; }

        public string Phone3 { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Address { get { return AddressDetail + "," + District + "/" + City; } }

        public string AccountName { get; set; }

        public string AccountImage { get; set; }

        public Guid AccountTypeId { get; set; }

        public string AccountNotes { get; set; }

        public string AddressDetail { get; set; }

        public string District { get; set; }

        public string City { get; set; }

        public Guid CommentId { get; set; }

        public Guid OpenCloseTimeId { get; set; }

        public string Location { get; set; }

        public int TimePeriod { get; set; }
    }
}
