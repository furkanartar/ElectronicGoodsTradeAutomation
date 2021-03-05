namespace Core.Utilities.Results
{
    /// <summary>
    /// Geri dönüş tipi IDataResult ise ve durum başarılıysa bu class return edilir.
    /// </summary>
    /// <typeparam name="T"> Data'nın tipini belirtir. </typeparam>
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, string message) : base(data, true, message)
        {

        }

        public SuccessDataResult(T data) : base(data, true)
        {

        }

        public SuccessDataResult(string message) : base(default, true, message)
        {

        }

        public SuccessDataResult() : base(default, true)
        {

        }
    }
}