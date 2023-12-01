namespace POSLibrary.DataModels.Supplier
{
    public class SupplierCreateReq
    {
        public string SupplierName { get; set; } = null!;
        public string? Contact { get; set;}
        public string? Email { get; set;}
        public int? ShopId { get;set; }
        public int? SuppplierCode { get; set;} = null!;   
    }
}