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
    [AutoMapFrom(typeof(ServiceType))]
    public class ServiceTypeDto : FullAuditedEntityDto<Guid>
    {
        public enum Type
        {
            FullTime = 1,

            HalfTime = 2,

            NoService = 3
        }
    }
}
