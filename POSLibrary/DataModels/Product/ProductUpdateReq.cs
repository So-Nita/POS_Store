using POSLibrary.Interface;

namespace POSLibrary.DataModels.Product
{
    public class ProductUpdateReq : IUpdateReq
    {
        public ulong Id { get; set; } 
        public int? CategoryId { get; set; }

        public string? Name { get; set; } = null!;

        public string? NameKh { get; set; }

        public string? Type { get; set; }

        public string? Image { get; set; }

        public double? Price { get; set; }

        public string? Status { get; set; } = null!;

        public long? ShopId { get; set; }
        public float? UnitPrice { get; set; }
    }
}
