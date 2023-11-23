using POSLibrary.DataModels.Product;
using POSLibrary.DataModels.Results;

namespace POSLibrary.Interface.Product
{
    public interface IProductService : IService<ProductResponse,ProductCreateReq,ProductUpdateReq>
    {
        Results<IEnumerable<ProductResponse>?> ReadByCategoryId(int id);
    }
}
