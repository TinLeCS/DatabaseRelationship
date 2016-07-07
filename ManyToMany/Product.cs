using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToMany
{
    //One Product can be sold by many Sellers. And one Seller can sell many different products too.
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public virtual ICollection<Seller> Sellers { get; set; }
    }
}
