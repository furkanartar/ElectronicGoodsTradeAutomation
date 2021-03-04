using Core.Utilities.Results.Abstract;

namespace Core.Utilities.Results.Concrete
{
    /// <summary>
    /// DataResult yapısının base class'ı.
    /// </summary>
    /// <typeparam name="T"> Data'nın tipini belirtir. </typeparam>
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool success, string message) : base(success, message)
        {
            Data = data;
        }

        public DataResult(T data, bool success) : base(success)
        {
            Data = data;
        }

        public T Data { get; }
    }
}