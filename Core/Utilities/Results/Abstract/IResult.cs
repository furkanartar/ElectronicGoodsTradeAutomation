namespace Core.Utilities.Results.Abstract
{
    /// <summary>
    /// Result yapısının base interface'i.
    /// </summary>
    public interface IResult
    {
        public bool Success { get; }
        public string Message { get; }
    }
}