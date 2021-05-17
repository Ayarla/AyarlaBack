using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Ayarla.Authorization.Accounts;
using Ayarla.Shared.Enums;

namespace Ayarla.EmployeeServices.Dto
{
    [AutoMapFrom(typeof(EmployeeService))]
    public class EmployeeServiceDto : EntityDto<Guid>
    {
        public Guid EmployeeId { get; set; }
        
        public string Service { get; set; }

        public decimal Price { get; set; }

        public int ServiceTime { get; set; }

        public TypeService ServiceType { get; set; }
    }
}
