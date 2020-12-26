using Ayarla.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetWithAppoinmentById(int userId);
        Task<User> GetWithFavoriteById(int userId);
        Task<User> GetWithCommentById(int userId);

    }
}
