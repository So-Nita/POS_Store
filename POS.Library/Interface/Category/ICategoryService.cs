using POSLibrary.DataModels.Category;
using POSLibrary.DataModels.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSLibrary.Interface.Category
{
    public interface ICategoryService : IService<CategoryResponse,CategoryCreateReq,CategoryUpdateReq>
    {
        Results<IEnumerable<CategoryResponse>> GetAllCategory();
    }
}
