using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfReferencing
{
    public class SelfReferencing
    {
        //One-To-One
        //One Employee may have one Manager and that Manager is also an Employee
        public class Employee
        {
            public int Id { get; set; }
            //? mark here makes ManagerId - Manger nullable
            [ForeignKey("Manager")]
            public int? ManagerId { get; set; }
            public string Name { get; set; }
            public virtual Employee Manager { get; set; }
        }
        //One-To-Many     
        //One Category may have many Subcategories. Each Subcategory is also a Category and may have other Subcategories

        public class Category
        {
            public int Id { get; set; }
            [ForeignKey("ParentCategory")]
            public int? ParentCategoryId { get; set; }
            public string Name { get; set; }
            public virtual Category ParentCategory { get; set; }
            public virtual ICollection<Category> Subcategories { get; set; }

        }

        //Many-To-Many
        //This example is kinda strange. I assume each Parent may have many Children and each Child may be many parents. Both Parent and Child are Person
        public class Person
       {
           public int Id { get; set; }
           public string Name { get; set; }
           public virtual ICollection<Person> Parents { get; set; }
           public virtual ICollection<Person> Children { get; set; }

       }
        //Modify OnModelCreating method in your DbContext class as below to define a many-to-many relationship

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Person>()
        //        .HasMany(x => x.Parents)
        //        .WithMany(x => x.Children)
        //        .Map(x => x.ToTable("Parents"));
        //}
    }
}
