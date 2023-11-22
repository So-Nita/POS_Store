using POSLibrary.DataModels.Product;
using POSLibrary.DataModels.Results;
using POSLibrary.Interface.Product;
using POSLibrary.Models;
using POSLibrary.Repository;

namespace POSLibrary.Service
{
    public class ProductService : IProductService
    {
        private readonly IRepository<ProductByCategory> _repo;
        public ProductService(IRepository<ProductByCategory> repository)
        {
            _repo = repository ?? throw new ArgumentNullException();
        }

        public List<ProductResponse?> ReadAll()
        {
            try
            {
                var data = _repo.GetAll()!.Select(e => new ProductResponse()
                {
                    Id = e.Id.ToString(),
                    Name = e.Name,
                    NameKh = e.NameKh,
                    CategoryId = e.CategoryId,
                    Price = e.Price,
                    Brand = e.Brand,
                    Qty = e.Qty,
                    Image = e.Image,
                    Description = e.Description,
                    ExpirationDate = e.ExpirationDate
                }).ToList();
                return data!;
            }
            catch { throw new Exception(); }
        }
        public string Create(ProductCreateReq req)
        {
            var product = new ProductByCategory()
            {
                Name = req.Name,
            };
            try
            {
                _repo.Add(product);
                return product.Id.ToString();
            }
            catch { return null!; }
        }
        public bool Update(ProductResponse t)
        {
            throw new NotImplementedException();
        }
        public bool Delete(string t)
        {
            throw new NotImplementedException();
        }

        
    }
}
