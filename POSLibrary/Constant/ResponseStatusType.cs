using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSLibrary.Constant
{
    public enum ResponseStatusType
    {
        success = 200,
        fail = 500
    }
    public class Response
    {
        public static List<string> Message = null!;
    }
}
