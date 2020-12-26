using Ayarla.Authorization.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.Repositories
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        Task<Employee> GetWithEmployeeAccountById(int employeeId);
        Task<Employee> GetWithAppoinmentById(int employeeId);

    }
}
