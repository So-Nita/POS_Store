using POSLibrary.Constant;
using POSLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSLibrary.DataModels.Category
{
    public class CategoryCreateReq : ICreateReq
    {
        public string Name { get; set; } = null!;
        public string? Image { get; set; }
        public int ParentCategoryId { get; set; }
        public long ShopId { get; set; }
        public StatusType Status { get; set; }
        public string? Type { get; set; }
        public string? Description { get; set; }
    }
}
