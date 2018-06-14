using Domain.Models;
using Infra.DataContext;
using Infra.Interfaces.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.Repositories.Base
{
    public class BaseRepository<TEntitty> : IBaseRepository<TEntitty>  where TEntitty : class
    {
        private readonly Context _dataContext;

        public BaseRepository(Context dataContext) {
            _dataContext = dataContext;
        }
        
        public TEntitty Salvar(TEntitty entity)
        {
            _dataContext.Add(entity);
            _dataContext.SaveChanges();
            return entity;
        }

        public TEntitty Atualizar(TEntitty TEntitty)
        {
            _dataContext.Update(TEntitty);
            _dataContext.SaveChanges();
            return TEntitty;
        }

        public TEntitty BuscarPorId(Guid id)
        {
            return _dataContext.Find<TEntitty>(id);
        }

        public void Delete(Guid id)
        {
            var TEntitty = _dataContext.Find<TEntitty>(id);
            _dataContext.Remove<TEntitty>(TEntitty);
        }

        public IEnumerable<TEntitty>BucarTodos()
        {
            return _dataContext.Set<TEntitty>();
        }
    }
}
