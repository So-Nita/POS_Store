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
                });
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
            catch { return Results<CategoryResponse>.Fail(); }
        }

        public Results<string> Create(CategoryCreateReq c)
        {
            try
            {
                return Results<string>.Success( );
            }
            catch
            {
                return Results<string>.Fail();
            }
        }
        public Results<string> Update(CategoryUpdateReq req)
        {
            try
            {
                return Results<string>.Success();
            }
            catch
            {
                return Results<string>.Fail();
            }
        }
        public Results<bool> Delete(string t)
        {
            try
            {
                return Results<bool>.Success();
            }
            catch
            {
                return Results<bool>.Fail();
            }
        }

        
    }
}
