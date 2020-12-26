using Ayarla.Authorization.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.Repositories
{
    public interface IAppoinmentRepository : IRepository<Appoinment>
    {
        Task<Appoinment> GetWithUserById(int appoinmentId);
        
        //Employee Date Entity kurulursa buraya eklenecek...
    }
}
