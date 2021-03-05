namespace Core.Utilities.Results
{
    /// <summary>
    /// Geri dönüş tipi IDataResult ise ve durum başarısızsa bu class return edilir.
    /// </summary>
    /// <typeparam name="T"> Data'nın tipini belirtir. </typeparam>
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }

        public ErrorDataResult(T data) : base(data, false)
        {

        }

        public ErrorDataResult(string message) : base(default, false, message)
        {

        }

        public ErrorDataResult() : base(default, false)
        {

        }
    }
}