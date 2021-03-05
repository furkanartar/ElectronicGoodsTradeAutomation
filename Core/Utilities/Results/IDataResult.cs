using Core.Utilities.Results;

namespace Core.Utilities.Results
{
    /// <summary>
    /// DataResult yapısının base interface'i.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDataResult<T> : IResult
    {
        public T Data { get; }
    }
}