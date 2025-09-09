using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Assignment_Empty_pro_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var webapplicationBuilber = WebApplication.CreateBuilder();
            webapplicationBuilber.Services.AddControllersWithViews();

            var app = webapplicationBuilber.Build();
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();
            //app.MapGet("/index", () => "hallo from index");

            app.MapControllerRoute(
                 name: "default",
                 pattern: "{controller=Home}/{action=Index}/{id:int?}"
             );

            //app.MapGet("/{name}", async context =>
            //{
            //    var name = context.GetRouteValue("name");
            //    await context.Response.WriteAsync($"Hello {name}!");
            //});

            app.MapGet("/", async context =>
            {
                await context.Response.WriteAsync("Hello world!");
            });
            app.Run();
             
        }

        



    }
}
