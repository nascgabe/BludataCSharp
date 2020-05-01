using Bludata.Teste.CSharp.Domain.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Bludata.Teste.CSharp.Domain.Interfaces.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : EntityBase
    {
        IQueryable<TEntity> GetAll();
        Task<TEntity> GetById(Guid id);
        Task Create(TEntity entity);
        Task Update(Guid id, TEntity entity);
        Task Delete(Guid id);
    }
}
