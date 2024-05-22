using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Domain.Entities
{
    public class Customer : BaseEntitiy
    { // Bir orderin birden fazla customeri olamaz
        public string Name { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
