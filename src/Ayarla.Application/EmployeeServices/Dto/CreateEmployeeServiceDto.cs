using System;
using Abp.AutoMapper;
using Ayarla.Authorization.Accounts;
using Ayarla.Shared.Enums;

namespace Ayarla.Services.Dto
{
    [AutoMapTo(typeof(EmployeeService))]
    public class CreateEmployeeServiceDto
    {
                public Guid EmployeeId { get; set; }
        
                public string ServiceName { get; set; }
        
                public decimal Price { get; set; }
        
                public int ServiceTime { get; set; }
        
                public TypeService ServiceType { get; set; }
                
               
    }
}