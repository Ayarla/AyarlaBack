using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.Authorization.Users
{
    public class Favorite
    {
        public int Id { get; set; }

        public int accountId { get; set; }

        public int userId { get; set; }
    }
}
