using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebAPI.Filters;

namespace WebAPI.Controllers
{
    [ProducesResponseType(typeof(DefaultControllerExceptionFilterAttribute.ErrorMessage), (int)HttpStatusCode.BadRequest),
     ProducesResponseType(typeof(DefaultControllerExceptionFilterAttribute.ErrorMessage), (int)HttpStatusCode.InternalServerError)]
    [DefaultControllerExceptionFilter]
    public class DefaultController : ControllerBase
    {
    }
}