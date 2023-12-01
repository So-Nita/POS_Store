using POSLibrary.Constant;
using POSLibrary.Interface;

namespace POSLibrary.DataModels.Category
{
    public class CategoryUpdateReq : IUpdateReq
    {
        public ulong Id { get; set; }
        public int ParentCategoryId { get; set; }
        public long? ShopId { get; set; }
        public string? Name { get; set; } = null!;
        public string? Image { get; set; }
        public string? Type { get; set; }
        public StatusType? Status { get; set; }
        public string? Description { get; set; }
    }
}
