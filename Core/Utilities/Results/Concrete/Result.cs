using Core.Utilities.Results.Abstract;

namespace Core.Utilities.Results.Concrete
{
    /// <summary>
    /// Result yapısının base class'ı.
    /// </summary>
    public class Result : IResult
    {
        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }
        public string Message { get; }
    }
}