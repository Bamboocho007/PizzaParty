namespace PizzaParty.Exceptions;

public class HttpResponseException : Exception
{
    public HttpResponseException(int statusCode, string message, List<object>? errors = null) : base(message) =>
        (StatusCode, Errors) = (statusCode, errors);

    public int StatusCode { get; }

    public List<object>? Errors { get; }
}
