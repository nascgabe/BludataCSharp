using Bludata.Teste.CSharp.Domain.Entities;
using Bludata.Teste.CSharp.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bludata.Teste.CSharp.Infra.Repositories
{
    public class ProviderRepository : GenericRepository<Provider>, IProviderRepository
    {
        private readonly Context context;

        public ProviderRepository(Context context) : base(context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Provider>> GetProviderByCompany()
        {
            return context.Set<Provider>().AsNoTracking()
                .Include(x => x.CPF)
                .Include(x => x.CNPJProvider)
                .Include(x => x.Create_At);
        }
    }
}
