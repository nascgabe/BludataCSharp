using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Bludata.Teste.CSharp.Application.Controllers
{
    [Route("api/v1/[controller]")]
    public class ControllerBase : Controller
    {
        protected readonly IMapper mapper;

        public ControllerBase(IMapper mapper)
        {
            this.mapper = mapper;
        }
    }
}