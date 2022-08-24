namespace Utilites.Abstract
{
    public interface IDataResult<T>
    {

        public bool Success { get; }
        public string Message { get; }
        public T Data { get; }
    }
}
