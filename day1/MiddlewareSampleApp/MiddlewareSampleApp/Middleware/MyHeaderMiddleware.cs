using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace MiddlewareSampleApp.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class MyHeaderMiddleware
    {
        private readonly RequestDelegate _next;

        public MyHeaderMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            httpContext.Response.Headers.Add("mycustomheader", "42");
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MyHeaderMiddlewareExtensions
    {
        public static IApplicationBuilder UseMyHeaderMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MyHeaderMiddleware>();
        }
    }
}
