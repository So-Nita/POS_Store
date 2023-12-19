using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSDesignDemo.Models.Response
{
    public class ProductResponse
    {
        public int Id { get; set; }
        public string? Product_Name { get; set; } = null!;
        public double? Price { get; set; }
        public string? Category_id { get;set; }
        public string? Sub_category_id { get; set; } = null!;
        public string? Sub_Category_Name { get; set; } = null!;
        public string? CategoryName { get; set; } = null!;
        public int Qty { get;set; }
        public string? Image { get; set; }
        private static string BaseUrl { get; } = "http://172.26.16.113:8082/";
        private static string DefaultImg{get ;}= "media/file/crm/uploadfile/16994192350ad09f76b331c013abfb892ee5a6f3d60.jpg";
        public string GetImageUrl => BaseUrl + (Image ?? DefaultImg);

    }
}
