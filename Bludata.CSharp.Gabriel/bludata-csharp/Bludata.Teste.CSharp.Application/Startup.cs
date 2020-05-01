using Bludata.Teste.CSharp.Infra;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace Bludata.Teste.CSharp.Application
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
            services.Configure<GzipCompressionProviderOptions>(options => options.Level = System.IO.Compression.CompressionLevel.Optimal);

            services.AddDbContext<Context>(opt => opt.UseSqlServer(Configuration.GetConnectionString("EstacionamentoConnectionString")));
            services.AddDependecyInjection();
            services.AddResponseCompression();
            services.AddMvc()
                  .AddJsonOptions(opt =>
                  {
                      opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                  });

            services.AddCors();
            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1", new Info { Title = "TESTE - BLUDATA", Version = "v1" });

            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseCors(c =>
            {
                c.AllowAnyHeader();
                c.AllowAnyMethod();
                c.AllowAnyOrigin();
            });

            {
                app.UseSwagger();

                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("../swagger/v1/swagger.json", "TESTE - BLUDATA");
                });

                app.UseHttpsRedirection();
                app.UseMvc();
            }
        }
    }
}