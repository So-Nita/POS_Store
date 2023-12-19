using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSDesignDemo.Models 
{
    public class ProductModel
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public double Price { get; set; }
        //public string? Image { get; set; } = null!;
        public int Qty { get; set; }
        //public string DisplayText => $"{Name} - ${Price}";
    }
}
