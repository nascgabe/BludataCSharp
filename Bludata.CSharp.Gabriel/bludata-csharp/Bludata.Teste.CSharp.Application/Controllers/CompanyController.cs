using AutoMapper;
using Bludata.Teste.CSharp.Domain.Entities;
using Bludata.Teste.CSharp.Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Bludata.Teste.CSharp.Application.Controllers
{
    public class CompanyController : ControllerBase
    {
        public CompanyController(IMapper mapper) : base(mapper)
        {
        }

        [HttpGet]
        public async Task<ActionResult> Get([FromServices] ICompanyRepository empresa)
        {
            return Ok(await empresa.AllAsync());
        }
        
        [HttpPost]
        public async Task<ActionResult> Post([FromServices] ICompanyRepository empresa, [FromBody] Company model)
        {
            await empresa.SaveAsync(model);
            return Ok();
        }
    }
}