using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllersWithViews();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Error");
			}

			//Creating Custom MiddelWare
			/*
			 app.Use(async (context, next) =>
			{
				await context.Response.WriteAsync("Hello from my first middl");
				await next();
			});

			app.Use(async (context, next) =>
			{
				await context.Response.WriteAsync("Hello from my second middl");
			});
			*/


			app.UseStaticFiles();

			app.UseRouting(); // Routing is used to map URL To the Particular Resourse

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapDefaultControllerRoute();
			});


			/*
			 * app.UseEndpoints(endpoints =>
			{
				endpoints.Map("/nagarro", async context =>
				{
					await context.Response.WriteAsync("Hello World From Nagarro"+env.EnvironmentName);
				});
			});
			*/

		}
	}
}
