using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonIdentifying
{
    public class House
    {
        public int Id { get; set; }
        public int? OwnerId { get; set; }
        public string Address { get; set; }
        //Don't need to care about THIS ONE
        public bool IsHaunted {
            get
            {
                return (OwnerId == null) ? true : false;
            }
        }
        public virtual Person Owner { get; set; }
    }
}
