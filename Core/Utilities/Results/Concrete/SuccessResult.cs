namespace Core.Utilities.Results.Concrete
{
    /// <summary>
    /// Geri dönüş tipi IResult ise ve durum başarılıysa bu class return edilir.
    /// </summary>
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(true, message)
        {

        }

        public SuccessResult() : base(true)
        {

        }
    }
}