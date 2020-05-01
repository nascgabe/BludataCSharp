using Bludata.Teste.CSharp.Application.Models;
using Bludata.Teste.CSharp.Application.Services.GenericService;
using Bludata.Teste.CSharp.Domain.Entities;
using Bludata.Teste.CSharp.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bludata.Teste.CSharp.Application.Services.ProviderService
{
    public class ProviderServices : IProviderServices
    {
        private readonly IProviderRepository _providerRepository;

        public ProviderServices(ICompanyRepository companyRepository, IProviderRepository providerRepository)
        {
            _providerRepository = providerRepository;
        }

        public async Task<CommandResult> Create(ProviderModel request)
        {
            var validate = new CommandResult(true, "Cadastro Aprovado!");

            if (validate.Success)
            {
                if (request.PersonType == 0)
                {
                    return new CommandResult(false, "Preencher os campos de RG, CPF, e Data de Nascimento para cadastro de pessoas físicas.");
                }

                int age = DateTime.Now.Subtract(request.DateBirth).Days / 365;

                if (age < 18)
                {
                    if (request.State == 0)
                    {
                        return new CommandResult(false, "Para cadastro de pessoas físicas do estado do Paraná somente maiores de 18 anos.");
                    }
                }

                var provider = new Provider(request.Name, request.Create_At, request.CPF, request.RG, request.DateBirth, request.CNPJProvider, request.State,
                    request.PersonType, request.ContactNumber);
                await _providerRepository.Create(provider);

                return new CommandResult(true, "Cadastro realizado com sucesso");
            }

            return new CommandResult(false, "Não foi possível concluir o cadastro. Confira os dados e tente novamente.");
        }

        public async Task Delete(Guid id)
        {
            var provider = await _providerRepository.GetById(id);
            provider.Disable();
            await _providerRepository.Update(id, provider);
        }

        public async Task<IList<ProviderModel>> GetAll()
        {
            var provider = _providerRepository.GetAll().ToList();

            return provider.Select(d => ConvertToModel(d)).ToList();
        }

        public async Task<ProviderModel> GetById(Guid id)
        {
            return ConvertToModel(await _providerRepository.GetById(id));
        }

        public async Task<IEnumerable<ProviderModel>> GetProviderByCompany()
        {
            var provider = await _providerRepository
                .GetProviderByCompany();
            return provider.Select(d => ConvertToModel(d)).ToList();
        }

        public async Task Update(Guid id, ProviderModel request)
        {
            var provider = await _providerRepository.GetById(id);
            provider.Update(request.Name, request.Create_At, request.CPF, request.RG, request.DateBirth, request.CNPJProvider, request.State,
                    request.PersonType, request.ContactNumber);
            await _providerRepository.Update(id, provider);
        }

        private ProviderModel ConvertToModel(Provider provider)
        {
            return new ProviderModel()
            {
                Name = provider.Name,
                Create_At = provider.Create_At,
                CPF = provider.CPF,
                RG = provider.RG,
                DateBirth = provider.DateBirth,
                CompanyId = provider.CompanyId,
                CNPJProvider = provider.CNPJProvider,
                Company = provider.Company,
                State = provider.State,
                PersonType = provider.PersonType,
                ContactNumber = provider.ContactNumber,
            };
        }
    }
}



