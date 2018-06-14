using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.Interfaces.Base
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        TEntity Salvar(TEntity entity);
        TEntity Atualizar(TEntity entity);
        TEntity BuscarPorId(Guid id);
        IEnumerable<TEntity> BucarTodos();
        void Delete(Guid id);
    }
}
