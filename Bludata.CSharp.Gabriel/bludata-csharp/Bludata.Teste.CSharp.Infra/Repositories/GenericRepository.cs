using Bludata.Teste.CSharp.Domain.Entities;
using Bludata.Teste.CSharp.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Bludata.Teste.CSharp.Infra.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : EntityBase
    {
        public readonly Context _dbContext;

        public GenericRepository(Context dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(TEntity entity)
        {
            await _dbContext.Set<TEntity>().AddAsync(entity);
            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task Delete(Guid id)
        {
            var entity = await GetById(id);
            _dbContext.Set<TEntity>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().AsNoTracking();
        }

        public virtual async Task<TEntity> GetById(Guid id)
        {
            return await _dbContext.Set<TEntity>()
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task Update(Guid id, TEntity entity)
        {
            entity.SetUpdateAt();
            _dbContext.Set<TEntity>().Update(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
