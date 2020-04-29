using AutoMapper;
using Bludata.Teste.CSharp.Application.Models;
using Bludata.Teste.CSharp.Domain.Entities;
using Bludata.Teste.CSharp.Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bludata.Teste.CSharp.Application.Controllers
{
    public class ProviderController : ControllerBase
    {
        private readonly IProviderRepository _iProvider;

        public ProviderController(IMapper mapper, IProviderRepository ifornecedor) : base(mapper)
        {
            this._iProvider = ifornecedor;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var fornecedores = await _iProvider.GetProviderByCompany();
            return Ok(mapper.Map<IEnumerable<ProviderViewModel>>(fornecedores));
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Provider model)
        {
            await _iProvider.SaveAsync(model);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] Provider model)
        {
            await _iProvider.UpdateAsync(model);
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete([FromBody] Provider model)
        {
            await _iProvider.DeleteAsync(model);
            return Ok();
        }
    }
}