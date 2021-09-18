using Microsoft.EntityFrameworkCore;
using CRUDBasics.Models;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.Reflection;
using CRUDBasics.RepositoryContracts.CommandContracts;
using CRUDBasics.RepositoryImplementation.CommandImplementation;
using CRUDBasics.RepositoryContracts.QueryContracts;
using CRUDBasics.RepositoryImplementation.QueryImplementation;

namespace CRUDBasics
{
    /// <summary>
    /// Startup
    /// </summary>
    public class Startup
    {

        /// <summary>
        /// Configuration
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// IConfiguration
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddTransient<MySqlConnection>(_ => new MySqlConnection(Configuration["ConnectionStrings:Default"]));
            //"server=localhost;port=3306;user=root;password=hrhk,database=test";
            //Configuration["ConnectionStrings:DBConnection"]
            services.AddDbContext<AppDbContext>(options => options.UseMySQL(Configuration["ConnectionStrings:DBConnection"]), ServiceLifetime.Transient);

            // MediatR services registeration
            services.AddMediatR(typeof(Startup));

            services.AddAutoMapper(typeof(Startup));

            services.AddScoped<IUserCommandRepository, UserCommandRepository>();
            services.AddScoped<IUserQueryRepository, UserQueryRepository>();

            // Swagger registeration
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info { Title = "Aquity Eye", Version = "v1" });
            });
            services.AddControllers();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
