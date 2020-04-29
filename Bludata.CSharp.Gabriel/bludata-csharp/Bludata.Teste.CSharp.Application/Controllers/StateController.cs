using AutoMapper;
using Bludata.Teste.CSharp.Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Bludata.Teste.CSharp.Application.Controllers
{
    public class StateController : ControllerBase
    {
        public StateController(IMapper mapper) : base(mapper)
        {

        }

        [HttpGet]
        public async Task<ActionResult> Get([FromServices] IStateRepository estado)
        {
            return Ok(await estado.AllAsync());
        }
    }
}