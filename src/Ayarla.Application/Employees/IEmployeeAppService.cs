﻿using Abp.Application.Services;
using Ayarla.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.Services
{
    public interface IEmployeeAppService : IAsyncCrudAppService<EmployeeDto,Guid,PagedEmployeeResultRequestDto>
    {
    }
}
