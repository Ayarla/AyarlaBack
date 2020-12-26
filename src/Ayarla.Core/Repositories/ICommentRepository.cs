using Ayarla.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.Repositories
{
    public interface ICommentRepository : IRepository<Comments>
    {
        Task<Comments> GetWithAccountById(int commentId);
    }
}
