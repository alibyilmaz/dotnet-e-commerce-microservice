using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeCourse.Services.Catalog.API.Dtos;
using FreeCourse.Services.Catalog.API.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FreeCourse.Services.Catalog.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
          var host =  CreateHostBuilder(args).Build();
          using (var scope = host.Services.CreateScope())
          {
              var servcieProvider = scope.ServiceProvider;
              var categoryService = servcieProvider.GetRequiredService<ICategoryService>();

              if (!categoryService.GetAllAsync().Result.Data.Any())
              {
                  categoryService.CreateAsync((new CategoryDto() {Name = "Asp Net Core Kursu"})).Wait();
                  categoryService.CreateAsync((new CategoryDto() {Name = "Asp Net Core API Kursu"})).Wait();
              }

          }
          host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
