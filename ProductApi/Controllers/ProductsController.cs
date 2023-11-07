using Microsoft.AspNetCore.Mvc;
using ProductApi.Models;

namespace ProductApi.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var products = new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Title = "Product-1",
                    Price = 549,
                    Category = "smartphones",
                    Thumbnail = "https://i.dummyjson.com/data/products/1/thumbnail.jpg"
                },
                 new Product()
                {
                    Id = 2,
                    Title = "Product-2",
                    Price = 899,
                    Category = "smartphones",
                    Thumbnail = "https://i.dummyjson.com/data/products/2/thumbnail.jpg"
                },
                  new Product()
                {
                    Id = 3,
                    Title = "Product-3",
                    Price = 1749,
                    Category = "laptops",
                    Thumbnail = "https://i.dummyjson.com/data/products/6/thumbnail.png"
                },
                   new Product()
                {
                    Id = 4,
                    Title = "Product-4",
                    Price = 13,
                    Category = "fragrances",
                    Thumbnail = "https://i.dummyjson.com/data/products/11/thumbnail.jpg"
                },
            };
            return Ok(products);
        }
    }
}
