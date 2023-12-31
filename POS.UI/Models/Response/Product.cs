﻿using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSDesignDemo.Models.Response
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public double Price { get; set; }
        public string Thumbnail { get; set; } = null!;
        public int Qty { get; set; }
        public string Category { get; set; } = null!;
    }
    public class ApiResultTest
    {
        public List<Product> Products { get; set; } = new();
    }
}
