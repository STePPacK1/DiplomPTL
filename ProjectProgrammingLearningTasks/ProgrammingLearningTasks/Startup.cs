using System.Linq;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProgrammingLearningTasks.Database;
using ProgrammingLearningTasks.Database.Entities;
using ProgrammingLearningTasks.Database.Repositories;
using ProgrammingLearningTasks.Utils;

namespace ProgrammingLearningTasks
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews()
                .AddRazorRuntimeCompilation();

            services.AddRazorPages()
                .AddRazorRuntimeCompilation();
            
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<ViewRender>();
            
            services.AddTransient<ProgrammingTaskRepository>();
            services.AddTransient<UserRepository>();

            services.AddEntityFrameworkSqlServer()
                .AddDbContext<ProgrammingLearningTasksContext>();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    options =>
                    {
                        options.LoginPath = new PathString("/Identity/Login");
                        options.AccessDeniedPath = new PathString("/Home/NotAccess");
                    }
                );

            services.AddAuthorization();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=ProgrammingTasks}/{action=Index}/{id?}");
            });

            SeedDatabase(app);
        }

        private void SeedDatabase(IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.CreateScope();
            var serviceProvider = scope.ServiceProvider;

            var context = serviceProvider.GetRequiredService<ProgrammingLearningTasksContext>();
            var defaultUser = Configuration.GetSection("DefaultLearnerIdentity").Get<User>();
            ProgrammingLearningTasksContext.Seed(context, defaultUser);
        }
    }
}