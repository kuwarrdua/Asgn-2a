using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarStockingg.Models
{
    public class Stock
    {
        //My field for the stock table along with the data types of field that will be used in sql
        //Also i have referenced the supplier table to show the relationship between them 
        //i Have assigned keys as well

        public Stock()
        {
            CarMake = "";
            Location = "";

        }

        [Key]
        public int StockId { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public String CarMake { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public String Location { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public double Price { get; set; }
        [ForeignKey("Supplier")]
        public int SupplierId { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}

