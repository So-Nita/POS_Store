using POSDesignDemo.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSDesignDemo.Models.Response
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        //public string MainCategory { get; set; } = null!;
        public string? Description { get; set; }
        public string Parent_Category_Id {  get; set; } = null!;
        public string Shop_Id { get; set; } = null!;
        private string? Image { get; set; }
        private static string BaseUrl { get; } = "http://172.26.16.113:8082/";
        public string GetImage => BaseUrl + Image;
    }
}
 