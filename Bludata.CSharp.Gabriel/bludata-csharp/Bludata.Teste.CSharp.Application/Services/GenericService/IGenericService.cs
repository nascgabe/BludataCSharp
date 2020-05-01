using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bludata.Teste.CSharp.Application.Services.GenericService
{
    public interface IGenericService<Model>
    {
        Task<CommandResult> Create(Model request);
        Task Update(Guid id, Model request);
        Task Delete(Guid id);
        Task<Model> GetById(Guid id);
        Task<IList<Model>> GetAll();
    }
}
