using Bludata.Teste.CSharp.Domain.Entities;
using Bludata.Teste.CSharp.Domain.Interfaces.Repositories;

namespace Bludata.Teste.CSharp.Infra.Repositories
{
    public class CompanyRepository : GenericRepository<Company>, ICompanyRepository
    {
        public CompanyRepository(Context dbContext) : base(dbContext)
        {
        }
    }
}
