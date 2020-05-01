using Bludata.Teste.CSharp.Application.Models;
using Bludata.Teste.CSharp.Application.Services.CompanyService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bludata.Teste.CSharp.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControllerCompany : Controller
    {
        private readonly ICompanyServices _companyServices;

        public ControllerCompany(ICompanyServices companyService)
        {
            _companyServices = companyService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CompanyModel request)
        {
            var returnState = await _companyServices.Create(request);
            if (returnState.Success)
                return Ok(returnState);

            return BadRequest(returnState);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] CompanyModel request)
        {
            await _companyServices.Update(id, request);
            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            await _companyServices.Delete(id);
            return NoContent();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<CompanyModel> GetById([FromRoute] Guid id)
        {
            return await _companyServices.GetById(id);
        }

        [HttpGet]
        public async Task<IList<CompanyModel>> GetAll()
        {
            return await _companyServices.GetAll();
        }
    }
}