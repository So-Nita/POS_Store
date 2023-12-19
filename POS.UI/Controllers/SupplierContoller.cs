using Newtonsoft.Json;
using POSDesignDemo.Constant;
using POSDesignDemo.Models;
using POSDesignDemo.Models.Request.Supplier;
using POSDesignDemo.Models.Response;

namespace POSDesignDemo.Controllers
{
    public class SupplierContoller : ControllerBase
    {
        /*public async Task<List<Supplier>> GetAllSupplier()
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, GetEndPoint(ConstantEndPoint.Supplier));
                foreach (var header in Headers)
                {
                    request.Headers.Add(header.Key, header.Value);
                }
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                var jsonContent = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonContent);
                var result = JsonConvert.DeserializeObject<List<Supplier>>(data!["result"].ToString()!);

                return result!;
            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }*/
        public async Task<List<Supplier>> GetAllSupplier()
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, GetEndPoint(ConstantEndPoint.Supplier));
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();

                var jsonContent = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonContent);
                var result = JsonConvert.DeserializeObject<List<Supplier>>(data!["result"].ToString()!);

                return result!;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<string> UpdateSupplier(SupplierUpdateReq req)
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Put, GetEndPoint(ConstantEndPoint.Supplier));
                var jsonPayload = JsonConvert.SerializeObject(req);
                var content = new StringContent(jsonPayload, null, "application/json");

                request.Content = content;
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                var responseData = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<ApiResponse>(responseData);
                return result!.Result;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        
    }
}
