using POSLibrary.Interface;

namespace POSLibrary.DataModels.Product
{
    public class ProductResponse : IResponse
    {
        public string Id { get; set; }
        public int Category_id { get; set; }
       // public int CategoryName { get; set; }
        public string Product_name { get; set; } = null!;
        public string? Product_namekh { get; set; }
        public string? Image { get; set; }

        public double? Price { get; set; }
        public int Qty { get; set; }
        public string? Brand { get; set; }
        public string? Description { get; set; }
        public string Category_name {  get; set; }
        public string? ExpirationDate { get; set; }
    }
}
