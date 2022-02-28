﻿using System.ComponentModel.DataAnnotations;

namespace EfRelationshipDemo.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
    }
}
