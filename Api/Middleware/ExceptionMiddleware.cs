using Core.Common.Exceptions;
using Newtonsoft.Json;

namespace Api.Middleware
{
    public class ExceptionMiddleware(RequestDelegate requestDelegate)
    {
        private readonly RequestDelegate _requestDelegate = requestDelegate;

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _requestDelegate(context);
            }
            catch (ApiException ex) 
            {
                await HandleApiExceptionAsync(context, ex);
            }
            catch(Exception ex) 
            {
                var apiException = new ApiException(500, "An unexpected error occurred.", ex.Message);
                await HandleApiExceptionAsync(context, apiException);
            }
        }

        private static Task HandleApiExceptionAsync(HttpContext context, ApiException exception) 
        {
            var response = new
            {
                code = exception.Code,
                message = exception.Message,
                data = exception.Data
            };

            var json = JsonConvert.SerializeObject(response);

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = exception.Code;

            return context.Response.WriteAsync(json);   
        }


    }
}
