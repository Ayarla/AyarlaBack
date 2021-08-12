using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Ayarla.Authorization.Accounts;

namespace Ayarla.Users.Dto
{
    [AutoMapTo(typeof(Appoinment))]
    public class CreateAppoinmentDto
    {
        public Guid EmployeeId { get; set; }

        public DateTime DayTime { get; set; }
        
        public Guid ServiceId { get; set; }
        
    }
}