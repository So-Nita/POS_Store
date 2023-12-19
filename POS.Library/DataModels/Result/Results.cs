using POSLibrary.Constant;
using System.Collections.Generic;

namespace POSLibrary.DataModels.Results
{
    public class Results<T>
    {
        public int Status { get; set; }
        public int Total { get; set; }
        public T? Result { get; set; } = default;
        public static Results<T> Success(T? data = default, int total = 1)
        {
            return new Results<T>()
            {
                Status = (int)ResponseStatusType.Success,
                Total = total,
                Result = data,
            };
        }
        public static Results<T> NotFound(T? data = default, int total = 0)
        {
            return new Results<T>()
            {
                Status = (int)ResponseStatusType.NotFound,
                Total = total,
                Result = data,
            };
        }
        public static Results<T> Conflict(T? data = default, int total = 0)
        {
            return new Results<T>()
            {
                Status = (int)ResponseStatusType.Conflict,
                Total = total,
                Result = data,
            };
        }
        public static Results<T> Fail(T? data = default, int total = 0)
        {
            return new Results<T>()
            {
                Status = (int)ResponseStatusType.Fail,
                Total = total,
                Result = data
            };
        }
        
    }

     
}
