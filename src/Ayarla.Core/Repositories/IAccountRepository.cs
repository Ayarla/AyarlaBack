using Ayarla.Authorization.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.Repositories
{
    public interface IAccountRepository : IRepository<Account>
    {
        Task<Account> GetWithAccountById(int accountId);
        Task<Account> GetWithFavoriteById(int accountId);
        Task<Account> GetWithEmployeeById(int accountId);
        Task<Account> GetWithEmployeeAccountById(int accountId);
        Task<Account> GetWithCommentById(int accountId);
    }
    
}
