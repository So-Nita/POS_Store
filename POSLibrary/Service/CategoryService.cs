using Microsoft.EntityFrameworkCore;
using POSLibrary.Constant;
using POSLibrary.DataModels;
using POSLibrary.DataModels.Category;
using POSLibrary.DataModels.Product;
using POSLibrary.DataModels.Results;
using POSLibrary.Interface.Category;
using POSLibrary.Models;
using POSLibrary.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace POSLibrary.Service
{
    public class CategoryService : ICategoryService 
    {
        private readonly IRepository<Category> _repo;
        public CategoryService(IRepository<Category> repository)
        {
             _repo = repository;
        }
        public Results<IEnumerable<CategoryResponse>> ReadAll()
        {
            try
            {
                var categories = new List<Category>();
                var products = _repo.Context().ProductByCategories.Where(e => e.Qty > 0).ToList();
                var result = _repo.GetQueryable()!.ToList();
                foreach (var item in products)
                {
                    var t = result!.Where(e => e.Id == (ulong)item.CategoryId).First();
                    categories.Add(t);
                }
                var data = categories.Select(e => new CategoryResponse()
                {
                    Id = e.Id,
                    Name = e.Name,
                    Parent_category_id = e.ParentCategoryId,
                    Image = e.Image,
                    Shop_id = e.ShopId
                }).OrderBy(e=>e.Name).DistinctBy(e=>e.Id);
                return Results<IEnumerable<CategoryResponse>>.Success(data,data.Count());
            }catch 
            { 
                return Results<IEnumerable<CategoryResponse>>.Fail(); 
            }
        }
        public Results<IEnumerable<CategoryResponse>> GetAllCategory()
        {
            try
            {
                var data = _repo.GetAll()!.Select(e=>new CategoryResponse()
                {
                    Id = e.Id,
                    Name = e.Name,
                    Parent_category_id = e.ParentCategoryId,
                    Image = e.Image,
                    Shop_id = e.ShopId
                });
                return Results<IEnumerable<CategoryResponse>>.Success(data, data.Count());
            }
            catch
            {
                return Results<IEnumerable<CategoryResponse>>.Fail();
            }
        }
        public Results<CategoryResponse> GetById(ulong id)
        {
            try
            {
                var category = _repo.GetById(id);
                var data = new CategoryResponse()
                {
                    Id = category!.Id,
                    Name = category.Name,
                    Parent_category_id = category.ParentCategoryId,
                    Image = category.Image,
                    Shop_id = (long)category.ShopId!
                };
                return Results<CategoryResponse>.Success(data);
            }
            catch(ArgumentException ex) { return Results<CategoryResponse>.Fail(); }
        }

        public Results<string> Create(CategoryCreateReq req)
        {
            try
            {
                var validationErrors = DataValidator<CategoryCreateReq>.ValidateDynamicTypes(req);
                if (validationErrors.Count > 0)
                {
                    return Results<string>.Fail(validationErrors.First() );
                }
                var category = new Category()
                {
                    Name = req.Name,
                    Image = req.Image,
                    ShopId = req.ShopId,
                    ParentCategoryId = req.ParentCategoryId,
                    Type = req.Type,
                    Status = req.Status.ToString(),
                    CreatedAt = DateTime.Now
                };
                
                _repo.Add(category);
                _repo.SaveChanges();

                return Results<string>.Success( "Created Successfully.");
            }
            catch
            {
                return Results<string>.Fail("Created Successfully."); 
            }
        }
        public Results<string> Update(CategoryUpdateReq req)
        {
            try
            {
                if (req.Id == 0)
                {
                    return Results<string>.Fail("Field Id is Required.");
                }
                var categoryFound = _repo.GetById(req.Id);

                if (categoryFound == null) 
                    return Results<string>.NotFound("Category Id does not existing.");

                categoryFound.Name = req.Name ?? categoryFound.Name;
                categoryFound.Image = req.Image ?? categoryFound.Image;
                categoryFound.ShopId = (req.ShopId==0 || req.ShopId==null) ? categoryFound.ShopId : req.ShopId;
                categoryFound.ParentCategoryId = (req.ParentCategoryId != 0) ? req.ParentCategoryId : categoryFound.ParentCategoryId;
                categoryFound.Type = req.Type ?? categoryFound.Type;
                categoryFound.Description = req.Description ?? categoryFound.Description;   
                categoryFound.Status = (req.Status==null || req.Status==0) ? categoryFound.Status : req.Status.ToString();
                categoryFound.UpdatedAt = DateTime.Now;

                _repo.Update(categoryFound);
                _repo.SaveChanges();

                return Results<string>.Success("Updated Successfully");
            }
            catch(Exception ex)
            {
                return Results<string>.Fail("Failed to Update.");
            }
        }
        public Results<string> Delete(ulong id)
        {
            try
            {
                if (id.Equals(0)) return Results<string>.Fail("Field Id is Required.");

                var category = _repo.GetById(id);

                if(category==null) return Results<string>.Fail("Category Id does not existing.");

                _repo.Delete(category);
                _repo.SaveChanges();

                return Results<string>.Success("Deleted Successfully");
            }
            catch
            {
                return Results<string>.Fail("Failed to Delete.");
            }
        }

        
    }
}
