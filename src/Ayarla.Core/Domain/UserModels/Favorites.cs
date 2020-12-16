using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayarla.Models
{
    public class Favorites
    {
        public int Id { get; set; }

        public int AccountId { get; set; }

        public int UserId { get; set; }
    }
}
