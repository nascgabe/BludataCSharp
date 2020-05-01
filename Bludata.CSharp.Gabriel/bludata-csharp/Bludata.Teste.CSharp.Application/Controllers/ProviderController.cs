using Bludata.Teste.CSharp.Application.Models;
using Bludata.Teste.CSharp.Application.Services.ProviderService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bludata.Teste.CSharp.Application.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class ProviderController : Controller
    {
        private readonly IProviderServices _providerServices;

        public ProviderController(IProviderServices providerService)
        {
            _providerServices = providerService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ProviderModel request)
        {
            await _providerServices.Create(request);
            return NoContent();
        }

        [HttpPut]
        [Route("{id1}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] ProviderModel request)
        {
            await _providerServices.Update(id, request);
            return NoContent();
        }

        [HttpDelete]
        [Route("{id1}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            await _providerServices.Delete(id);
            return NoContent();
        }

        [HttpGet]
        [Route("{id1}")]
        public async Task<ProviderModel> GetById([FromRoute] Guid id)
        {
            return await _providerServices.GetById(id);
        }

        [HttpGet]
        public async Task<IEnumerable<ProviderModel>> GetProviderByCompany()
        {
            return await _providerServices.GetProviderByCompany();
        }

        [HttpGet]
        public async Task<IList<ProviderModel>> GetAll()
        {
            return await _providerServices.GetAll();
        }
    }
}