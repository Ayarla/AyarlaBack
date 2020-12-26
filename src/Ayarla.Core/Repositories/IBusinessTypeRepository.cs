using Ayarla.Authorization.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.Repositories
{
    public interface IBusinessTypeRepository : IRepository<BusinessType>
    {
        Task<BusinessType> GetWithAccountById(int businesstypeId);
    }
}
