using POSLibrary.Constant;
using POSLibrary.Interface;

namespace POSLibrary.DataModels.Category
{
    // Model as subCategpryByShop
    public class CategoryResponse : IResponse
    {
        public ulong Id { get; set; }  
        public string Name { get; set; } = null!;
        public int Parent_category_id { get; set; } 
        public string? Image { get; set; }
        public long? Shop_id {  get; set; } 

    }
}
