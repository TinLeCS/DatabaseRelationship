using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOne
{
    public class DrivingLicense
    {
        [Key]
        //String in the "" must be exactly the same as variable name for a navigation property
        [ForeignKey("Person")]
        public int PersonId { get; set; }
        public string DrivingLicenseNumber { get; set; }
        //Navigation property is right below this comment ^.^
        public virtual Person Person { get; set; }
    }
}
