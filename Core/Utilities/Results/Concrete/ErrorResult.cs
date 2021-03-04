namespace Core.Utilities.Results.Concrete
{
    /// <summary>
    /// Geri dönüş tipi IResult ise ve durum başarısızsa bu class return edilir.
    /// </summary>
    public class ErrorResult : Result
    {
        public ErrorResult(string message) : base(true, message)
        {

        }

        public ErrorResult() : base(true)
        {

        }
    }
}