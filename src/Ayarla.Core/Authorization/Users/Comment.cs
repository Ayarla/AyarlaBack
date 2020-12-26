using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.Authorization.Users
{
    public class Comments
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string Comment { get; set; }

        public int AccountId { get; set; }

        public int Stars { get; set; }
    }
}
