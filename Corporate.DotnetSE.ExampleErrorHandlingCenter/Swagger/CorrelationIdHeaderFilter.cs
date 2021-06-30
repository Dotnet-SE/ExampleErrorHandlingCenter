using System;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Corporate.DotnetSE.ExampleErrorHandlingCenter.Swagger
{
    public class CorrelationIdHeaderFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            operation.Parameters.Add(new OpenApiParameter 
            {
                Name = "CorrelationId",
                In = ParameterLocation.Header,
                Description = "Request correlation Id",
                Required = true,
                Schema = new OpenApiSchema
                {
                    Type = "string",
                    Default = new OpenApiString(Guid.NewGuid().ToString())
                }
            });
        }
    }
}