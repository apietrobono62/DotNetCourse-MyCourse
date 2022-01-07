using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Mycourse
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                // è sempre meglio che questo middleware sia il primo
                app.UseDeveloperExceptionPage(); // produce una pagina informativa nel caso in cui dovesse prodursi un errore
            }
            app.UseStaticFiles(); //middleware che si occupa di caricare i file statici in wwwroot
          /*  app.Run(async (context) =>
            {
                String nome =  context.Request.Query["nome"];
                if (nome == null) nome = "";
                await context.Response.WriteAsync($"Ciao {nome.ToUpper()}!");
            });*/
            //middleware di routing per accedere ai controllers
           // app.UseMvcWithDefaultRoute();
            app.UseMvc(routeBuilder =>
            {
                routeBuilder.MapRoute("default","{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}
