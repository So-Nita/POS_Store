using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSDesignDemo.Models.Response
{
    public class ApiResponse
    {
        public int Status { get; set; }
        public int Total { get; set; }
        public string Result { get; set; } = "";
    }
}
