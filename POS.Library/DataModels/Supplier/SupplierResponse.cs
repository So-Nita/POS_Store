namespace POSLibrary.DataModels.Supplier
{
    public class SupplierResponse
    {
        public int Id { get; set; }
        public string? SupplierName { get; set; }  
        public string? Contact { get; set; } 
        public string? Email { get; set; }  
        public string? Website { get; set; }  
        public int? ShopId { get; set; }  
        public string? ShopName { get; set; }  
        public string? VendorCode { get; set; }  
    }
}