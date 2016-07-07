using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToMany
{
    public class Item
    {
        public int Id { get; set; }
        //By name convention, Entity Framework can recognise the pattern (NavigationPropertyName+"Id") as a foreign key without [ForeignKey] annotation
        public int ShoppingListId { get; set; }
        public string ItemName { get; set; }
        //Navigation property is right below this comment ^.^
        public ShoppingList ShoppingList { get; set; }
    }
}
