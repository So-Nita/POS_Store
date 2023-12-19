using POSLibrary.Constant;
using POSLibrary.Interface;

namespace POSLibrary.DataModels.Product
{
    public class ProductCreateReq : ICreateReq
    {
        public string Name { get; set; } = null!;
        public string? NameKh { get; set; } 
        public string? Image {  get; set; }
        public double? Price {  get; set; } 
        public int CategoryId { get; set; } 
        public StatusType Status { get; set; }
        public CurrencyType CurrencyId { get; set; }  
        public Double Cost { get; set; }    
        public int Amount { get; set; }
        public int MeasurementId { get; set; }  
        public DateTime CreatedAt {  get; set; }
    }
    
    
}
