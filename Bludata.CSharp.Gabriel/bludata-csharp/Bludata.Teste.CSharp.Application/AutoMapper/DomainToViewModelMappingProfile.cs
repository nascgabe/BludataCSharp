using AutoMapper;
using Bludata.Teste.CSharp.Application.Models;
using Bludata.Teste.CSharp.Domain.Entities;

namespace Bludata.Teste.CSharp.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Provider, ProviderViewModel>()
                .ForMember(x => x.Name, y => y.MapFrom(v => v.Company.Fantasy));
            CreateMap<Contact, PhoneViewModel>();
        }
    }
}
