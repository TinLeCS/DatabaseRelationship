using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToMany
{
    public class Seller
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
 