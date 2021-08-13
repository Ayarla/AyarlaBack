using System;
using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Ayarla.Authorization.Accounts;
using Ayarla.EmployeeServices.Dto;

namespace Ayarla.Users.Dto
{
    [AutoMapTo(typeof(Appoinment))]
    public class CreateAppoinmentDto
    {
        public Guid AccountId { get; set; }
        public Guid EmployeeId { get; set; }

        public DateTime DayTime { get; set; }
        
        public List<EmployeeServiceDto> Services { get; set; }
        
        public decimal TotalPrice { get; set; }
        
    }
}