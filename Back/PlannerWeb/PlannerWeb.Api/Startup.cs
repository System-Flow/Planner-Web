using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using PlannerWeb.Infra.Context;
using Microsoft.IdentityModel.Tokens;
using Microsoft.EntityFrameworkCore;
using PlannerWeb.Domain.Repositories;
using PlannerWeb.Infra.Repositories;
using PlannerWeb.Domain.Handlers;

namespace PlannerWeb.Api
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
            services.AddControllers();
            //trocar quando tiver o banco montado 
            //services.AddDbContext<DataContext>(opt => opt.UseNpgsql(Configuration.GetConnectionString("connectionString")));
            services.AddDbContext<DataContext>(opt => opt.UseInMemoryDatabase("Database"));
            
            services.AddTransient<IKnowledgeWall, KnowledgeWallRepository>();
            services.AddTransient<KnowledgeWallHandler, KnowledgeWallHandler>();
            
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "PlannerWeb.Api", Version = "v1" });
            });

            //RETIRAR PARTE COMENTADA QUANDO TIVER AUTENTICAÇÃO
            //services
            //  .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            //  .AddJwtBearer(options =>
            //  {
            //      options.Authority = "";
            //      options.TokenValidationParameters = new TokenValidationParameters
            //      {
            //          ValidateIssuer = true,
            //          ValidIssuer = "",
            //          ValidateAudience = true,
            //          ValidAudience = "",
            //          ValidateLifetime = true
            //      };
            //  });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PlannerWeb.Api v1"));
            }

            app.UseHttpsRedirection();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(x => x
               .AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader());

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            }); 
            
        }
    }
}
