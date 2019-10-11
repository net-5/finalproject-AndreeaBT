using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conference.Data;
using Conference.Domain.Entities;
using Conference.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Conference
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ConferenceContext>();

            services.AddTransient<IEditionRepository, EditionRepository>();
            services.AddTransient<IEditionsServices, EditionService>();

            services.AddTransient<ISpeakersRepository, SpeakersRepository>();
            services.AddTransient<ISpeakerService, SpeakerService>();

            services.AddTransient<ISponsorRepository, SponsorRepository>();
            services.AddTransient<ISponsorService, SponsorService>();

            services.AddTransient<ISponsorTypesRepository, SponsorTypesRepository>();
            services.AddTransient<ISponsorTypesService, SponsorTypesService>();

            services.AddTransient<ITalksRepository, TalksRepository>();
            services.AddTransient<ITalkService, TalkService>();

            services.AddTransient<IWorkshopRepository, WorkshopRepository>();
            services.AddTransient<IWorkshopService, WorkshopService>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                 name: "areaRoute",
                 template: "{area:exists}/{controller}/{action}/{id?}",
                 defaults: new { area = "Admin", controller = "Home", action = "Index" }
                 );

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
