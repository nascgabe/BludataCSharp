using Bludata.Teste.CSharp.Domain.Entities;
using Bludata.Teste.CSharp.Domain.Interfaces.Repositories;

namespace Bludata.Teste.CSharp.Infra.Repositories
{
    public class StateRepository : RepositoryBase<State>, IStateRepository
    {
        public StateRepository(Context context) : base (context)
        {
        }
    }
}
