﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Week10Day1Demo_EfCore_DbFirst.Models
{
    public partial class GetIdResult
    {
        public int OrderId { get; set; }
        public string OrderTitle { get; set; }
        public DateTime OrderDate { get; set; }
        public double? StateTax { get; set; }
    }
}
