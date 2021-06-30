using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Serilog;

namespace Corporate.DotnetSE.ExampleErrorHandlingCenter.Middlewares
{
    public class ErrorHandlingCenter
    {
        private readonly RequestDelegate _next;
        private const string ContentType = "application/json";

        public ErrorHandlingCenter(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next.Invoke(context);
            }
            catch (Exception e)
            {
                Log.Error(e, e.Message);

                context.Response.ContentType = ContentType;
                context.Response.StatusCode = (int) HttpStatusCode.InternalServerError;
                
                await context.Response.WriteAsJsonAsync(new
                {
                    message = e.Message,
                    service = "Corporate.DotnetSE.ExampleErrorHandlingCenter",
                    company = "DotnetSe"
                });
            }
        }
    }
}