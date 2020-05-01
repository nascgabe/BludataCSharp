using Bludata.Teste.CSharp.Application.Services.CompanyService;
using Bludata.Teste.CSharp.Application.Services.ProviderService;
using Bludata.Teste.CSharp.Domain.Interfaces.Repositories;
using Bludata.Teste.CSharp.Infra.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace Bludata.Teste.CSharp.Application
{
    public static class InjectionDependency
    {
        public static void AddDependecyInjection(this IServiceCollection services)
        {
            services.AddScoped<IProviderServices, ProviderServices>();
            services.AddScoped<ICompanyServices, CompanyServices>();
            services.AddScoped<IProviderRepository, ProviderRepository>();
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.InvalidModelStateResponseFactory = (context) =>
                {
                    var errors = context.ModelState.Values.SelectMany(x => x.Errors.Select(p => p.ErrorMessage)).ToList();
                    var result = new
                    {
                        Code = "007",
                        Message = "Validation errors",
                        Errors = errors
                    };
                    return new BadRequestObjectResult(context.ModelState);
                };
            });
        }
    }
}

