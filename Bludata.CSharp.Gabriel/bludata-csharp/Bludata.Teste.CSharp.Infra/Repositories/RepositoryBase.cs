using Bludata.Teste.CSharp.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bludata.Teste.CSharp.Infra.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private DbSet<T> entity_;
        private readonly Context context;

        public RepositoryBase(Context context)
        {
            this.context = context;
            entity_ = context.Set<T>();
        }

        public async Task<IEnumerable<T>> AllAsync()
        {
            return await entity_.ToListAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            entity_.Remove(entity);
            context.SaveChanges();
        }

        public async Task<T> SaveAsync(T entity)
        {
            entity_.Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public T[] SaveRange(T[] entity)
        {
            entity_.AddRange(entity);
            context.SaveChanges();
            return entity;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            entity_.Update(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public T[] UpdateRange(T[] entity)
        {
            entity_.UpdateRange(entity);
            context.SaveChanges();
            return entity;
        }
    }
}
