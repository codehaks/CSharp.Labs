using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace AsyncDemo
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");

                var t1 =  Work1();
                var t2 =  Work2();

                var t3 = await Work3();
                var t4 = await Work4();

                await context.Response.WriteAsync($"\n Work1 -> Thread : {t1.Result}");
                await context.Response.WriteAsync($"\n Work1 -> Thread : {t2.Result}");
            });
        }


        public async Task<int> Work1()
        {
            await Task.Delay(5000);
            return Thread.CurrentThread.ManagedThreadId;
        }

        public async Task<int> Work2()
        {
            await Task.Delay(5000);
            return Thread.CurrentThread.ManagedThreadId;
        }

        public async Task<int> Work3()
        {
            await Task.Delay(2000);
            return Thread.CurrentThread.ManagedThreadId;
        }

        public async Task<int> Work4()
        {
            await Task.Delay(2000);
            return Thread.CurrentThread.ManagedThreadId;
        }


    }
}
