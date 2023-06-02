using crudDapperEfCore.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace crudDapperEfCore.Controllers.Shared
{
    [ApiController]
    public abstract class ApiController : ControllerBase
    {
        protected IActionResult ResponseOk(object result) =>
            ResponseResult(HttpStatusCode.OK, result);

        protected IActionResult ResponseOk() =>
            ResponseResult(HttpStatusCode.OK);

        protected IActionResult ResponseCreated() =>
            ResponseResult(HttpStatusCode.Created);

        protected IActionResult ResponseCreated(object data) =>
            ResponseResult(HttpStatusCode.Created, data);

        protected IActionResult ResponseNoContent() =>
            ResponseResult(HttpStatusCode.NoContent);

        protected IActionResult ResponseNotModified() =>
            ResponseResult(HttpStatusCode.NotModified);

        protected IActionResult ResponseBadRequest(string errorMessage) =>
            ResponseResult(HttpStatusCode.BadRequest, errorMessage: errorMessage);

        protected IActionResult ResponseBadRequest() =>
            ResponseResult(HttpStatusCode.BadRequest, errorMessage: "A requisição é inválida");

        protected IActionResult ResponseNotFound(string errorMessage) =>
            ResponseResult(HttpStatusCode.NotFound, errorMessage);

        protected IActionResult ResponseNotFound() =>
            ResponseResult(HttpStatusCode.NotFound, errorMessage: "O registro não foi encontrado");

        protected IActionResult ResponseUnauthorized(string errorMessage) =>
            ResponseResult(HttpStatusCode.Unauthorized, errorMessage: errorMessage);

        protected IActionResult ResponseUnauthorized() =>
            ResponseResult(HttpStatusCode.Unauthorized, errorMessage: "Permissão negada");

        protected IActionResult ResponseInternalServerError() =>
            ResponseResult(HttpStatusCode.InternalServerError);

        protected IActionResult ResponseInternalServerError(string errorMessage) =>
            ResponseResult(HttpStatusCode.InternalServerError, errorMessage: errorMessage);

        protected IActionResult ResponseInternalServerError(Exception exception) =>
            ResponseResult(HttpStatusCode.InternalServerError, errorMessage: exception.Message);

        protected JsonResult ResponseResultData(HttpStatusCode statusCode, object data, string errorMessage)
        {
            CustomResult result = null;

            if(string.IsNullOrEmpty(errorMessage))
            {
                var success = statusCode.IsSuccess();

                if(data != null)
                {
                    result = new CustomResult(statusCode, success, data);
                }
                else
                {
                    result = new CustomResult(statusCode, success);
                }
            }
            else
            {
                var errors = new List<string>();

                if (!string.IsNullOrWhiteSpace(errorMessage))
                {
                    errors.Add(errorMessage);
                }

                result = new CustomResult(statusCode, false, errors);
            }

            return new JsonResult(result) { StatusCode = (int)result.StatusCode };
        }

        protected JsonResult ResponseResult(HttpStatusCode statusCode, object result) => ResponseResultData(statusCode, result, null);


        protected JsonResult ResponseResult(HttpStatusCode statusCode, string errorMessage) => ResponseResultData(statusCode, null, errorMessage);
       

        protected JsonResult ResponseResult(HttpStatusCode statusCode) => ResponseResultData(statusCode, null, null);

    }
}
