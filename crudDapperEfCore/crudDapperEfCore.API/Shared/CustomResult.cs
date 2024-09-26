using System.Net;

namespace crudDapperEfCore.API.Shared
{
    public class CustomResult
    {
        public HttpStatusCode StatusCode { get; private set; }

        public bool Success { get; private set; }

        public object Data { get; private set; }

        public string Message { get; private set; }

        public IList<string> Errors { get; private set; }

        public CustomResult(HttpStatusCode statusCode, bool success)
        {
            StatusCode = statusCode;
            Success = success;
        }

        public CustomResult(HttpStatusCode statusCode, bool success, string message)
        {
            StatusCode = statusCode;
            Success = success;
            Message = message;
        }

        public CustomResult(HttpStatusCode statusCode, bool success, object data, string message) : this(statusCode, success)
        {
            Data = data;
            Message = message;
        }

        public CustomResult(HttpStatusCode statusCode, bool success, string message, IList<string> errors) : this(statusCode, success)
        {
            Errors = errors;
            Message = message;
        }

        public CustomResult(HttpStatusCode statusCode, bool success, object data, string message, IList<string> errors) : this(statusCode, success, data, message)
        {
            Errors = errors;
        }
    }
}