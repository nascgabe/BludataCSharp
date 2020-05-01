using Bludata.Teste.CSharp.Application.Models;
using Bludata.Teste.CSharp.Application.Services.GenericService;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bludata.Teste.CSharp.Application.Services.ProviderService
{
    public interface IProviderServices : IGenericService<ProviderModel>
    {
        Task<IEnumerable<ProviderModel>> GetProviderByCompany();
    }
}
