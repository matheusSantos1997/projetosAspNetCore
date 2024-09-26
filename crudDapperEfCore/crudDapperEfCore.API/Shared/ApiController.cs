using System.Net;
using crudDapperEfCore.API.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace crudDapperEfCore.API.Shared
{
    [ApiController]
    public abstract class ApiController : ControllerBase
    {
        protected IActionResult ResponseOk(object result = null!, string message = null!) =>
            ResponseResult(HttpStatusCode.OK, result, message);

        protected IActionResult ResponseOk(string message) =>
            ResponseResult(HttpStatusCode.OK, null!, message);

        protected IActionResult ResponseOk() =>
            ResponseResult(HttpStatusCode.OK);

        protected IActionResult ResponseCreated() =>
            ResponseResult(HttpStatusCode.Created);

        protected IActionResult ResponseCreated(object data, string message) =>
            ResponseResult(HttpStatusCode.Created, data, message);

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

        protected JsonResult ResponseResultData(HttpStatusCode statusCode, object data, string successMessage, string errorMessage)
        {
            CustomResult result;

            if (string.IsNullOrEmpty(errorMessage))
            {
                var success = statusCode.IsSuccess();

                if (data != null)
                {
                    result = new CustomResult(statusCode, success, data, successMessage);
                }
                else
                {
                    result = new CustomResult(statusCode, success, successMessage);
                }
            }
            else
            {
                var errors = new List<string>();

                if (!string.IsNullOrWhiteSpace(errorMessage))
                {
                    errors.Add(errorMessage);
                }

                result = new CustomResult(statusCode, false, successMessage, errors);
            }

            // Certifique-se de que o StatusCode seja atribuído corretamente
            var jsonResult = new JsonResult(result);
            jsonResult.StatusCode = (int)statusCode;

            return jsonResult;
        }

        protected JsonResult ResponseResult(HttpStatusCode statusCode, object result, string message) =>
            ResponseResultData(statusCode, result, message, null!);

        protected JsonResult ResponseResult(HttpStatusCode statusCode, string errorMessage) =>
            ResponseResultData(statusCode, null!, null!, errorMessage);

        protected JsonResult ResponseResult(HttpStatusCode statusCode) =>
            ResponseResultData(statusCode, null!, null!, null!);
    }
}