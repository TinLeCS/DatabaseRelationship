using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToMany
{   
    //One ShoppingList may contains many Item(s) in it
    public class ShoppingList
    {
        //From my research, the contructor below specifies using HashSet to implement ICollection to improve the performance. It is not a must for define the relationship
        public ShoppingList()
        {
            this.Items = new HashSet<Item>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        //ICollection allows to add and remove items while IEnumerable does not
        public virtual ICollection<Item> Items { get; set; }
    }
}
