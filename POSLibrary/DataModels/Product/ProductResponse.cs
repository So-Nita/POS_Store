using POSLibrary.Interface;

namespace POSLibrary.DataModels.Product
{
    public class ProductResponse : IResponse
    {
        public string Id { get; set; }
        public int CategoryId { get; set; }

        public string Name { get; set; } = null!;
        public string? NameKh { get; set; }
        public string? Image { get; set; }

        public double? Price { get; set; }
        public int Qty { get; set; }
        public string? Brand { get; set; }
        public string? Description { get; set; }

        public string? ExpirationDate { get; set; }
    }
}
