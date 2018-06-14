using System;
using System.Collections.Generic;
using System.Text;

namespace Aplication.Interfaces.Base
{
    public interface IBaseService<T>
    {
        T Salvar(T viewModel);
        T Atualizar(Guid id, T viewModel);
        T BuscarPorId(Guid id);
        IEnumerable<T> BuscarTodos();
        void Excluir(Guid id);
    }
}
