using System;
using System.ComponentModel.DataAnnotations;

namespace Week10Day1Demo_EfCore.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public string OrderTitle { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        public double? StateTax { get; set; }
    }
}
