using Utilites.Abstract;

namespace Utilites.Concrete
{
    public class DataResult<T> : IDataResult<T>
    {
        public DataResult(T data, bool success, string message) : this(data, success)
        {
            Message = message;

        }
        public DataResult(T data, bool success) : this(success)
        {
            Data = data;
        }
        public DataResult(bool success)
        {
            Success = success;
        }


        //public DataResult(T data, bool success):this(success)
        //{
        //    Data = data;

        //}

        //public DataResult(bool success)
        //{
        //    Success = success;

        //}

        public bool Success { get; }
        public string Message { get; }
        public T Data { get; }

    }
}
