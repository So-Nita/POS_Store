namespace POSLibrary.DataModels.Supplier
{
    public class SupplierUpdateReq
    {
        public int Id {  get; set; }
        public string? SupplierName { get; set; } = null!;

        public string? Contact { get; set; }

        public string? Email { get; set; }
        public string? Website { get; set; }

        public int? ShopId { get; set; }

        public int? SupplierCode { get; set; }
    }
}