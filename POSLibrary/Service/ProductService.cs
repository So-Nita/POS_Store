using Microsoft.EntityFrameworkCore;
using POSLibrary.Constant;
using POSLibrary.DataModels;
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

        public Results<IEnumerable<ProductResponse>?> ReadAll()
        {
            try
            {
                var categories = _repo.Context().Categories.ToList();
                var products = _repo.GetAll()!.Where(e => e.Qty > 0).ToList();
                var result = new List<ProductResponse>();
                if (categories != null)
                {
                    foreach (var item in categories)
                    {
                        var data = products.Where(e=>e.CategoryId.ToString()==item.Id.ToString()).Select(e => new ProductResponse()
                        {
                            Id = e.Id.ToString(),
                            Product_name = e.Name,
                            Product_namekh = e.NameKh,
                            Category_id = e.CategoryId,
                            CategoryName = item.Name,
                            Price = e.Price,
                            Brand = e.Brand,
                            Qty = e.Qty,
                            Image = e.Image,
                            Description = e.Description,
                            ExpirationDate = e.ExpirationDate
                        }).ToList();
                        result.AddRange(data);
                    }
                }
                
                return Results<IEnumerable<ProductResponse>>.Success(result, result!.Count())!;
            }
            catch { throw new Exception(); }
        }

        public Results<IEnumerable<ProductResponse>?> ReadByCategoryId(int id)
        {
            try
            {
                var data = _repo.GetQueryable()!.Where(e=>e.CategoryId==id && e.Qty>0).Select(e => new ProductResponse()
                {
                    Id = e.Id.ToString(),
                    Product_name = e.Name,
                    Product_namekh = e.NameKh,
                    Category_id = e.CategoryId,
                    Price = e.Price,
                    Brand = e.Brand,
                    Qty = e.Qty,
                    Image = e.Image,
                    Description = e.Description,
                    ExpirationDate = e.ExpirationDate
                }).ToList();
                return Results<IEnumerable<ProductResponse>>.Success(data, data.Count())!;
            }
            catch { throw new Exception(); }
        }
        public Results<string> Create(ProductCreateReq req)
        {
            var validationErrors = DataValidator<ProductCreateReq>.ValidateDynamicTypes(req);
            if (validationErrors.Count > 0)
            {
                return Results<string>.Fail(validationErrors.First(), validationErrors.Count);
            }
            var product = new ProductByCategory()
            {
                Name = req.Name,
                NameKh = req.NameKh,
                Image = req.Image,
                CategoryId = req.CategoryId,
                Price = req.Price,
                Cost = req.Cost,
                CurrencyId = (int)req.CurrencyId,
                Amount = req.Amount,
                Status = req.Status.ToString(),
                MeasurementId = 3 /*req.MeasurementId*/,
                CreatedAt = DateTime.Now,
            };
            try
            {
                _repo.Add(product);
                _repo.SaveChanges();
                return Results<string>.Success(data: "Create Suceessfully. Product id : "+product.Id);
            }
            catch 
            { 
                return Results<string>.Fail("Failed to create the product"); 
            }
        }

        public Results<string> Update(ProductUpdateReq req)
        {
            try
            {
                var validationErrors = DataValidator<ProductUpdateReq>.ValidateDynamicTypes(req);
                if (validationErrors.Count > 0)
                {
                    return Results<string>.Fail(validationErrors.First(), validationErrors.Count);
                }
                var product = _repo.GetQueryable()!.FirstOrDefault(e=>e.Id==req.Id);// !.FirstOrDefault(e => e.Id.Equals(req.Id));
                if (product == null) { return Results<string>.Fail("Product does not existing."); }

                product.Name = req.Name ?? product.NameKh!;
                product.NameKh = req.NameKh ?? product.NameKh;
                product.CategoryId = (int)(req.CategoryId==0? product.CategoryId : req.CategoryId)!;
                product.UnitPrice = req.UnitPrice ?? product.CategoryId;
                product.Type = req.Type ?? product.Type;
                product.Image = req.Image ?? product.Image;
                product.Price = req.Price==0 ? product.Price : req.Price;
                product.Status = req.Status == "string" ? product.Status : req.Status!;
                product.ShopId = req.ShopId == 0 ? product.ShopId : req.ShopId;

                _repo.Update(product);
                _repo.SaveChanges();
                return Results<string>.Success(data: "Update Successfully");
            }
            catch
            {
                return Results<string>.Fail("Fail to Update");
            }
        }
        
        public Results<ProductResponse> GetById(ulong id)
        {
            try
            {
                var data = _repo.GetQueryable()!.Where(e=>e.Id==id).Select(e=>new ProductResponse()
                {
                    Id = e.Id.ToString(),
                    Product_name = e.Name,
                    Product_namekh = e.NameKh,
                    Category_id = e.CategoryId,
                    Brand = e.Brand,
                    Qty= e.Qty,
                    Price = e.Price,
                    Image = e.Image,
                    Description = e.Description,
                    ExpirationDate = e.ExpirationDate
                }).First();
                return Results<ProductResponse>.Success(data);
            }
            catch(Exception ex)
            {
                return Results<ProductResponse>.Fail();
            }
        }
        public Results<string> Delete(ulong id)
        {
            try
            {
                var product = _repo.GetById(id);
                if(product == null)
                {
                    return Results<string>.NotFound();
                }
                return Results<string>.Success("Deleted Successfully.");
            }
            catch { return Results<string>.Fail("Failed to Delete."); }
        }

    }
}
