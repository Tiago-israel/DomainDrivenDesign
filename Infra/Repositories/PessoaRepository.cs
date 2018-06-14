using Domain.Models;
using Infra.DataContext;
using Infra.Interfaces.Base;
using Infra.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.Repositories
{
    public class PessoaRepository :BaseRepository<Pessoa>, IPessoaRepository
    {
        //private readonly Context _dataContext;

        public PessoaRepository(Context dataContext):base(dataContext)
        {
            //_dataContext = dataContext;
        }

        //public PessoaRepository(Context dataContext)
        //{
        //    _dataContext = dataContext;
        //}

        //public Pessoa Atualizar(Pessoa entity)
        //{
        //    _dataContext.Update(entity);
        //    _dataContext.SaveChanges();
        //    return entity;
        //}

        //public IEnumerable<Pessoa> BucarTodos()
        //{
        //    return _dataContext.Pessoas.ToList();
        //}

        //public Pessoa BuscarPorId(Guid id)
        //{
        //    return _dataContext.Pessoas.FirstOrDefault(x => x.Id == id);
        //}

        //public void Delete(Guid id)
        //{
        //    var pessoa = this.BuscarPorId(id);
        //    if (pessoa != null)
        //        _dataContext.Pessoas.Remove(pessoa);
        //}

        //public Pessoa Salvar(Pessoa entity)
        //{
        //    _dataContext.Add(entity);
        //    _dataContext.SaveChanges();
        //    return entity;
        //}
    }
}
