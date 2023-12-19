using Newtonsoft.Json;
using POSDesignDemo.Models;
using POSDesignDemo.Models.Request.UserLogin;
using POSDesignDemo.Models.Request.Order;
using POSDesignDemo.Constant;
using System.Text;
using POSDesignDemo.Models.Response;
using Category = POSDesignDemo.Models.Response.Category;
using POSDesignDemo.Models.Request.Product;

namespace POSDesignDemo.Controllers
{
    public class ProductController : ControllerBase
    {
        private List<Category> Categories = new();
        private List<ProductResponse> Products = new();

        public ProductController() { }
        public async Task<List<Category>> GetCategoriesAsync()
        {
            if (Categories.Count == 0)
            {
                Categories = await GetAllCategoryAsync();
            }

            return Categories;
        }
        public async Task<string> GetUser(UserLoginReq req)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    foreach (var header in Headers)
                    {
                        client.DefaultRequestHeaders.Add(header.Key, header.Value);
                    }
                    var payload = new
                    {
                        email = req.Email,
                        password = req.Password
                    };
                    var jsonPayload = JsonConvert.SerializeObject(payload);

                    var request = new HttpRequestMessage(HttpMethod.Post, GetEndPoint(ConstantEndPoint.AuthLogin));
                    request.Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                    var response = await client.SendAsync(request);
                    response.EnsureSuccessStatusCode();

                    var responseContent = await response.Content.ReadAsStringAsync();
                    var user = JsonConvert.DeserializeObject<User>(responseContent);
                    return null!;
                }
            }
            catch
            {
                throw new Exception();
            }
        }

        // Api Laravel
        public async Task<List<ProductResponse>> GetAllProductsAsync()
        {
            try
            {
                var client = new HttpClient();

                var request = new HttpRequestMessage(HttpMethod.Get, GetEndPoint(ConstantEndPoint.ProductList));

                foreach (var header in Headers)
                {
                    request.Headers.Add(header.Key, header.Value);
                }

                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                var jsonContent = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonContent);
                var result = JsonConvert.DeserializeObject<List<ProductResponse>>(data!["result"].ToString()!);

                return result!.Where(e => e.Qty != 0).OrderBy(e => e.Id).ToList();
            }
            catch
            {
                throw new Exception();
            }
        }
        //-- 
        /*private async Task<List<Category>> GetAllCategoryAsync()
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, GetEndPoint(ConstantEndPoint.SubCategoryByShop));
                foreach (var header in Headers)
                {
                    request.Headers.Add(header.Key, header.Value);
                }
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();

                var jsonContent = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonContent);
                var result = JsonConvert.DeserializeObject<List<Category>>(data["result"].ToString()!)!;
                Categories.AddRange(result.DistinctBy(e => e.Id).ToList());
                return Categories.OrderBy(e=>e.Name).ToList();

                *//*var products = await GetAllProductsAsync();
                var result = products.DistinctBy(e=>e.Category_Id).Select(e=>new Category()
                {
                    Id =e.Category_Id, 
                    Name =e.Sub_Category_Name,
                    MainCategory = e.Category_Name
                }).ToList();
                return result;*//*
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }*/
         // My Api 

        // Get Product By Category Id

        private async Task<List<Category>> GetAllCategoryAsync()
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, GetEndPoint(ConstantEndPoint.SubCategoryByShop));
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                var jsonContent = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonContent);
                var result = JsonConvert.DeserializeObject<List<Category>>(data!["result"].ToString()!);
                return result!;
            }
            catch { throw new ArgumentException(); }
        }
      
        public async Task<List<ProductResponse>> GetProductByCategory(int categoryid)
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get,GetEndPoint(ConstantEndPoint.ProductByCateId)+categoryid /*"http://172.26.17.126:8002/api/product/getProductByCategoryId?categoryId=306"*/);
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();

                var jsonContent = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonContent);
                var result = JsonConvert.DeserializeObject<List<ProductResponse>>(data!["result"].ToString()!);
                return result!;
            }
            catch { throw new ArgumentException(); }
        }
        public async Task<Category> GetCategoryByName(string name)
        {
            try
            {
                Categories = await GetAllCategoryAsync();
                var categories = Categories.Where(e => e.Name == name).Select(e => new Category()
                {
                    Id = e.Id,
                    Name = e.Name,
                    Shop_Id = e.Shop_Id,
                    Description = e.Description,
                    //MainCategory = e.MainCategory
                }).FirstOrDefault();
                return categories!;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Line : " + ex.StackTrace + "\nMessage : " + ex.Message);
                throw new ArgumentException();
            }
        }
        // Method for Add New Product
        public bool CreateProduct(ProductCreateReq product)
        {
            try
            {
                var newProduct = new ProductResponse()
                {
                    Product_Name = product.Name,
                    Price = product.Price,
                    Image = product.Image
                };
                Products.Add(newProduct);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw new ArgumentException();
            }
        }
        public bool UpdateProduct(ProductUpdateReq product)
        {
            try
            {
                var existPro = Products.FirstOrDefault(e => e.Id == product.Id);
                if (existPro == null) throw new Exception();
                existPro.Product_Name = product.Name!;
                existPro.Sub_category_id = product.Category!;
                existPro.Price = (double)product.Price!;
                existPro.Image = product.Image!;
                return true;
            }catch 
            {
                throw new Exception();
            }
        }
        public string DeleteProduct(int id)
        {
            try
            {
                var product = Products.FirstOrDefault(e => e.Id == id);
                if (product != null)
                {
                    Products.Remove(product);
                }
                return "Delete Successfully";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
        public async Task<SellDetailResponse> GetSellOrderDetails()
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, GetEndPoint(ConstantEndPoint.SellOrderedDetail));

                foreach (var header in Headers)
                {
                    request.Headers.Add(header.Key, header.Value);
                }

                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                var jsonContent = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<SellDetailResponse>(jsonContent);
                return data!;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
         
        public async Task<bool> CreatePurchaseOrderAsync(OrderCreateReq req)
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Post, GetEndPoint(ConstantEndPoint.PurchaseOrder));
                var jsonPayload = JsonConvert.SerializeObject(req);
                var content = new StringContent(jsonPayload, null, "application/json");

                foreach (var header in Headers)
                {
                    request.Headers.Add(header.Key, header.Value);
                }

                request.Content = content;
                var response = await client.SendAsync(request);
                var test = (response.IsSuccessStatusCode != true) ? false : true;

                return (response.IsSuccessStatusCode != true) ? false : true;
            }
            catch(Exception ex) { throw new Exception(ex.Message); }
        }

    }
}
