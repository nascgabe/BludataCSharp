using Bludata.Teste.CSharp.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bludata.Teste.CSharp.Domain.Interfaces.Repositories
{
    public interface IProviderRepository : IGenericRepository<Provider>
    {
        Task<IEnumerable<Provider>> GetProviderByCompany();
    }
}
