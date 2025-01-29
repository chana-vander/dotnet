﻿namespace Clinic.API.MiddleWares
{
    public class ShabbatMiddleware
    {
        private readonly RequestDelegate _next;
        public ShabbatMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine("middleWare start!!!");
            var shabbat = true;
            if (shabbat)
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
            else
                await _next(context);
            Console.WriteLine("middleWare finish!!!");
        }
    }
}
