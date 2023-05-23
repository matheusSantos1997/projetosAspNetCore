using Microsoft.AspNetCore.Mvc;

namespace Pensamentos.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class CustomReponse : ProducesResponseTypeAttribute
    {
        public CustomReponse(int statusCode) : base(typeof(CustomReponse), statusCode) {}
    }
}
