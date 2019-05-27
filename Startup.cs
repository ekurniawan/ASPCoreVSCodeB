using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ASPCoreGroupB.DAL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.FileProviders;

namespace ASPCoreGroupB
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //menambahkan mvc
            services.AddMvc();
            services.AddSession(options=>{
                options.IdleTimeout = TimeSpan.FromMinutes(2);
            });
            services.AddSingleton<IFileProvider>(  
            new PhysicalFileProvider(  
                Path.Combine(Directory.GetCurrentDirectory(), "wwwroot")));
                
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IMahasiswa,MahasiswaDAL>();
            services.AddScoped<IPengguna,PenggunaDAL>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //menambahkan file static di wwwwroot
            app.UseStaticFiles();
            //menambahkan session
            app.UseSession();
            //untuk menambahkan mvc pattern
            app.UseMvcWithDefaultRoute();

            /* app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World !");
            });*/
        }
    }
}
