using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hello_DI_project
{
    public class ConsoleLoggerMiddleware : IMiddleware
    {
        public Printer printer;
        public IColor color;

        public ConsoleLoggerMiddleware(Printer printer, IColor color)
        {
            this.printer = printer;
            this.color = color;
        }

        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Console.WriteLine("Hi from the middleware");
            printer.Log("hello");
            color.PrintColor();
            /*color.PrintColor();*/
            return next(context);
        }
    }
}
