using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.Interfaces.Base
{
    public interface IBaseRepository<T> where T : class
    {
        T Salvar(T entity);
        T Atualizar(T entity);
        T BuscarPorId(Guid id);
        IEnumerable<T> BucarTodos();
        void Delete(Guid id);
    }
}
