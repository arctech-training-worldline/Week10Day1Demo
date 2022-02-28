using System;
using System.ComponentModel.DataAnnotations;

namespace Week10Day1Demo_EfCore_CodeFirst.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        public double Salary { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool? IsMarried { get; set; }
        [StringLength(2000)]
        public string Appraisal { get; set; }
        public double? TaxRate { get; set; }
    }
}
