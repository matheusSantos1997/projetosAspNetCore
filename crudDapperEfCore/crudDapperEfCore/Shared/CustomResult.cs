using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace crudDapperEfCore.Controllers.Shared
{
    public class CustomResult
    {
        public HttpStatusCode StatusCode { get; private set; }

        public bool Success { get; private set; }

        public object Data { get; private set; }

        public IList<string> Errors { get; private set; }

        public CustomResult(HttpStatusCode statusCode, bool success)
        {
            StatusCode = statusCode;
            Success = success;
        }

        public CustomResult(HttpStatusCode statusCode, bool success, object data) : this(statusCode, success)
        {
            Data = data;
        }

        public CustomResult(HttpStatusCode statusCode, bool success, IList<string> errors) : this(statusCode, success)
        {
            Errors = errors;
        }

        public CustomResult(HttpStatusCode statusCode, bool success, object data, IList<string> errors) : this(statusCode, success, data)
        {
            Errors = errors;
        }
    }
}
