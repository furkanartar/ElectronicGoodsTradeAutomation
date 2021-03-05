namespace Core.Utilities.Results
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