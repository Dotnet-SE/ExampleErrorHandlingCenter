using Corporate.DotnetSE.ExampleErrorHandlingCenter.Middlewares;
using Microsoft.AspNetCore.Builder;

namespace Corporate.DotnetSE.ExampleErrorHandlingCenter.Extensions
{
    public static class ErrorHandlingCenterExtension
    {
        public static IApplicationBuilder UseErrorHandlingCenter(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ErrorHandlingCenter>();
        }
    }
}