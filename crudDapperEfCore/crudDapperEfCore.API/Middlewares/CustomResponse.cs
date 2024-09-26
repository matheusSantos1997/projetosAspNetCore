using crudDapperEfCore.API.Shared;
using Microsoft.AspNetCore.Mvc;

namespace crudDapperEfCore.API.Middlewares
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class CustomResponse : ProducesResponseTypeAttribute
    {
        public CustomResponse(int statusCode) : base(typeof(CustomResult), statusCode){}
    }
}