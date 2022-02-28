using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfRelationshipDemo.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }

        public int ProductRefId { get; set; }
        
        [ForeignKey("ProductRefId")]
        public Product Product { get; set; }
    }
}
