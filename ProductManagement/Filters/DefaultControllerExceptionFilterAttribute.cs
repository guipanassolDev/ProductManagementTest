using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Sentry;
using System.Net;
using WebAPI.Application.Exceptions;
using WebAPI.Core.Exceptions;
using WebAPI.Exceptions;
using WebAPI.Resources;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace WebAPI.Filters
{
    public class DefaultControllerExceptionFilterAttribute : ExceptionFilterAttribute
    {
        private string GetBaseMessage(ExceptionContext context)
        {
            var friendlyMessage = ExceptionsResource.ResourceManager.GetString(context.Exception.GetType().Name);
            var defaultMessage = context.Exception.Message;
            var stackTrace = context.Exception.StackTrace;

            if (!string.IsNullOrEmpty(friendlyMessage))
                return friendlyMessage;
            if (!string.IsNullOrEmpty(defaultMessage))
                return defaultMessage;

            return stackTrace;
        }

        public override Task OnExceptionAsync(ExceptionContext context)
        {
            var baseMessage = GetBaseMessage(context);

            if (context.Exception is APICommonException apiException)
            {
                var message = string.Format(baseMessage, apiException.MessageParams);
                context.Result = new ObjectResult(new ErrorMessage(message, apiException.Error, apiException.InvalidField))
                {
                    StatusCode = (int)HttpStatusCode.BadRequest
                };
            }
            else
            if (context.Exception is CoreCommonException coreException)
            {
                var message = string.Format(baseMessage, coreException.MessageParams);
                context.Result = new ObjectResult(new ErrorMessage(message, coreException.Error, coreException.InvalidField))
                {
                    StatusCode = (int)HttpStatusCode.BadRequest
                };
            }
            else
            if (context.Exception is ApplicationCommonException applicationException)
            {
                var message = string.Format(baseMessage, applicationException.MessageParams);
                context.Result = new ObjectResult(new ErrorMessage(message, applicationException.Error, applicationException.InvalidField))
                {
                    StatusCode = (int)HttpStatusCode.BadRequest
                };
            }
            else
            {
                if (context.Exception is ArgumentNullException argumentNullException)
                {
                    context.Result = new ObjectResult(new ErrorMessage(argumentNullException))
                    {
                        StatusCode = (int)HttpStatusCode.BadRequest
                    };
                }
                else if (context.Exception is ArgumentException argumentException)
                {
                    context.Result = new ObjectResult(new ErrorMessage(argumentException))
                    {
                        StatusCode = (int)HttpStatusCode.BadRequest
                    };
                }
                else
                {
                    context.Result = new ObjectResult(new ErrorMessage(context.Exception))
                    {
                        StatusCode = (int)HttpStatusCode.InternalServerError
                    };
                }

                if (!context.HttpContext.RequestServices.GetRequiredService<IHostingEnvironment>().IsDevelopment())
                {
                    SentrySdk.CaptureException(context.Exception);
                }
            }

            return base.OnExceptionAsync(context);
        }

        internal class ErrorMessage
        {
            public string Message { get; set; }

            public string Error { get; set; }

            public string InvalidField { get; set; }

            public ErrorMessage() { }

            public ErrorMessage(Exception exception) : this(exception, null) { }

            public ErrorMessage(Exception exception, string error, string invalidField = null)
            {
                Message = exception.Message;
                Error = error;
                InvalidField = invalidField;
            }

            public ErrorMessage(string message, string error, string invalidField = null)
            {
                Message = message;
                Error = error;
                InvalidField = invalidField;
            }
        }
    }
    
}
