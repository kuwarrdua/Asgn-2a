using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarStockingg.Models
{
    public class Supplier
    {
        //The supplier table with some necessary field and the creation of PK as well.

        public Supplier()
        {
            Name = "";
            Email = "";
            Contact = "";
        }

        [Key]
        public int SupplierId { get; set; }
        [Column(TypeName = "nvarchar(80)")]
        public String Name { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public String Email { get; set; }
        [Column(TypeName = "char(10)")]
        public String Contact { get; set; }
    }
}
