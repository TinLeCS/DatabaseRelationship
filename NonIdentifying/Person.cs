using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonIdentifying
{
    // Person and House exist independently to each other. Like me as a Person still exists without owning any house. And there is some haunted House out there without any owner :D
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //From my research there is no need to put navigation property here for Non-Identifying Relationship
    }
}
