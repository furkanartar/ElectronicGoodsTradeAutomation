namespace Core.Utilities.Results.Abstract
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