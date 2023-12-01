using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSLibrary.Constant
{
    public enum ResponseStatusType
    {
        Success = 200,
        NotFound = 404,
        Conflict = 409,
        Fail = 500,
    }
    public class Response
    {
        public static List<string> Message = null!;
    }
}
