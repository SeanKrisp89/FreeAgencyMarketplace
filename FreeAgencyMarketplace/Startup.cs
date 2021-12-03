using FreeAgencyMarketplace.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeAgencyMarketplace
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. This method is used to add services to the container (and to configure those services). But, what are exactly services in the .NET Core world? Services should 
		// be seen as a broad concept. A service is a component that is intended for common consumption in an application. There are framework services like Identity, MVC, Entity Framework Core services.
		// But, there are also application services which are application specific, for example a component to send mail.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<ApplicationDbContext>(options =>
				options.UseSqlServer(
					Configuration.GetConnectionString("DefaultConnection")));
			services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
				.AddEntityFrameworkStores<ApplicationDbContext>();
			services.AddControllersWithViews();
			services.AddRazorPages();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		//Whenever an HTTP request comes in, something must handle that request and provide an HTTP response.
		//The code that handles requests and provides responses make up the request pipeline.
		//WHAT WE CAN DO IS CONFIGURE THAT REQUEST PIPELINE BY ADDING MIDDLEWARE WHICH IS SOFTWARE COMPONENTS (code) THAT ARE ASSEMBLED INTO AN APPLICATION PIPELINE TO HANDLE REQUESTS AND RESPONSES
		//An example of middleware could be authentication (like Identity?)
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage(); //This statement configures the request pipeline by adding the DeveloperExceptionPage to it. So now when an exception is thrown this piece of middleware will handle it
				app.UseDatabaseErrorPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}
			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();					//This is our HTTP request pipeline! See 2nd module lesson 5 & 6 in asp.net Core Web API pluralsight course
												//Meaning this is how our ASP.NET Core MVC app is configured to handle HTTP requests
			app.UseAuthentication();
			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");
				endpoints.MapRazorPages();
			});
		}
	}
}
