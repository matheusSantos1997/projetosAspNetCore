using crudDapperEfCore.Controllers.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudDapperEfCore.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class CustomResponse : ProducesResponseTypeAttribute
    {
        public CustomResponse(int statusCode) : base(typeof(CustomResult), statusCode){} 
    }
}
