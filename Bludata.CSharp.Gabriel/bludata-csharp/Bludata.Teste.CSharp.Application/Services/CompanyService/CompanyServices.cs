using Bludata.Teste.CSharp.Application.Models;
using Bludata.Teste.CSharp.Application.Services.GenericService;
using Bludata.Teste.CSharp.Domain.Entities;
using Bludata.Teste.CSharp.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bludata.Teste.CSharp.Application.Services.CompanyService
{
    public class CompanyServices : ICompanyServices
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyServices(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public async Task<CommandResult> Create(CompanyModel request)
        {
            var validate = new CommandResult(true, "Ok");

            if (validate.Success)
            {
                var company = new Company(request.CNPJ, request.Fantasy, request.StateId);
                await _companyRepository.Create(company);
                return new CommandResult(true, "Cadastro realizado com sucesso");
            }

            return new CommandResult(false, "Algo deu errado. Confira os dados e tente novamente.");
        }

        public async Task Delete(Guid id)
        {
            var company = await _companyRepository.GetById(id);
            company.Disable();
            await _companyRepository.Update(id, company);
        }

        public async Task<IList<CompanyModel>> GetAll()
        {
            var company = _companyRepository.GetAll().ToList();

            return company.Select(d => ConvertToModel(d)).ToList();
        }

        public async Task<CompanyModel> GetById(Guid id)
        {
            return ConvertToModel(await _companyRepository.GetById(id));
        }

        public async Task Update(Guid id, CompanyModel request)
        {
            var company = await _companyRepository.GetById(id);
            company.Update(request.CNPJ, request.Fantasy, request.StateId);
            await _companyRepository.Update(id, company);
        }

        private CompanyModel ConvertToModel(Company company)
        {
            return new CompanyModel()
            {
                CNPJ = company.CNPJ,
                Fantasy = company.Fantasy,
                StateId = company.StateId,
            };
        }
    }
}
