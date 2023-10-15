
using System.Text.Json;
using PizzaParty.Exceptions;

namespace PizzaParty.Middlewares;

public class HttpResponseErrorMiddeware : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {

        try
        {
            await next(context);
        }
        catch (Exception e)
        {
            if (e is HttpResponseException err)
            {
                context.Response.StatusCode = err.StatusCode;

                var errorResponse = JsonSerializer.Serialize(new
                {
                    err.StatusCode,
                    err.Message,
                    err.Errors
                });

                await context.Response.WriteAsJsonAsync(errorResponse);
            }
            else
            {
                await next(context);
            }
        }
    }
}

