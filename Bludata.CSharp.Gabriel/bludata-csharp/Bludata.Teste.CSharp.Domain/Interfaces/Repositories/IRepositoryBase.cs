using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bludata.Teste.CSharp.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<IEnumerable<T>> AllAsync();
        Task<T> SaveAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        T[] SaveRange(T[] entity);
        T[] UpdateRange(T[] entity);
    }
}
