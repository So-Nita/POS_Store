using POSLibrary.Interface;

namespace POSLibrary.DataModels.Product
{
    public class ProductCreateReq : ICreateReq
    {
        public string Name { get; set; } = null!;
    }
}
