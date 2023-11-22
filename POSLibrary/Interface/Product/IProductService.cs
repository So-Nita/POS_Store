using POSLibrary.DataModels.Product;

namespace POSLibrary.Interface.Product
{
    public interface IProductService : IService<ProductResponse,ProductCreateReq,ProductUpdateReq>
    {
    }
}
