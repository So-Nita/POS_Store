using System.ComponentModel;

namespace ProductAPI.Models
{
    public class Product
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;   
        public double Price { get; set; }
        public string Image { get; set; } = null!;
        public string CategoryId { get; set; } = null!;
        public Category Category { get; set; } = new ();
    }
}
