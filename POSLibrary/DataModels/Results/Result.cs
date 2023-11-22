using static System.Runtime.InteropServices.JavaScript.JSType;

namespace POSLibrary.DataModels.Results
{
    public class Results<T>
    {
        public int Status { get; set; } = default;
        public int Count { get; set; }
        public T? Result { get; set; } = default;

        public static Results<T> Success(T? data, int status)
        {
            return new Results<T>()
            {
                Status = status,
                Count = status,
                Result = data,
            };
        }
        public static Results<T> Fail(int status = 0)
        {
            return new Results<T>()
            {
                Status = status,
                Count = status,
                Result = default,
            };
        }

         
    }
    public class CustomResponse<T>
    {
        public int Status { get; set; }
        public int Total { get; set; }
        public List<T> Result { get; set; }
    }

}
