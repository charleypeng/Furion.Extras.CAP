# Furion.Extras.CAP
A furion extra for DotNetCore.CAP

    using Furion;
	using DotNetCore.CAP;
	using Microsoft.Extensions.DependencyInjection;
	using Microsoft.AspNetCore.Builder;
	using Microsoft.AspNetCore.Hosting;
	using Savorboard.CAP.InMemoryMessageQueue;

	namespace DotNetCore.CAP.Sample
	{
		    public class MQServiceStartup:AppStartup
		    {
			        public void ConfigureServices(IServiceCollection services)
			        {
			            //add cap
			            services.AddFurionCap(opt =>
			            {
			                opt.UseInMemoryStorage();
			                opt.UseInMemoryMessageQueue();
			                opt.UseDashboard();
			            });
			        }

	        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
	        {
	            app.UseCapDashboard();
	        }
	    }
	}
 Feel free to use!
