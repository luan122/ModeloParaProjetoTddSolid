using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using ModeloParaProjetoTddSolid.Api.Middleware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModeloParaProjetoTddSolid.Api.Extensions
{
    public static class GlobalExceptionHandlerMiddlewareExtension
    {
        public static IServiceCollection AddGlobalExceptionHandlerMiddleware(this IServiceCollection services)
        {
            return services.AddTransient<GlobalExceptionHandlerMiddleware>();
        }

        public static void UseGlobalExceptionHandlerMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<GlobalExceptionHandlerMiddleware>();
        }
    }
}
