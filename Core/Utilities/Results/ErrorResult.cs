namespace Core.Utilities.Results
{
    /// <summary>
    /// Geri dönüş tipi IResult ise ve durum başarısızsa bu class return edilir.
    /// </summary>
    public class ErrorResult : Result
    {
        public ErrorResult(string message) : base(false, message)
        {

        }

        public ErrorResult() : base(false)
        {

        }
    }
}