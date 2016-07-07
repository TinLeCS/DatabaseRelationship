using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOne
{
    //Every person only has one-or-zero driving associated to him/her
    public class Person
    {
        //By name convention, Entity Framework can recognise variable name "Id" as a primary key without [Key] annotation
        public int Id { get; set; }
        public string Name { get; set; }

        //Put [Required] here if wanna make it become one-to-one relationship. It means when a person is created, a driving license is required to create at the same time.
        [Required]
        public virtual DrivingLicense DrivingLicense{ get; set; }
    }
}
