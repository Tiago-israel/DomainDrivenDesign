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
    public class BaseRepository<T> : IBaseRepository<T>  where T : class
    {
        private readonly Context _dataContext;

        public BaseRepository(Context dataContext) {
            _dataContext = dataContext;
        }
        
        public T Salvar(T entity)
        {
            _dataContext.Add(entity);
            this.Commit();
            return entity;
        }

        public T Atualizar(T entity)
        {
            _dataContext.Update(entity);
            this.Commit();
            return entity;
        }

        public T BuscarPorId(Guid id)
        {
            return _dataContext.Find<T>(id);
        }

        public void Delete(Guid id)
        {
            var entity = _dataContext.Find<T>(id);
            _dataContext.Remove<T>(entity);
            this.Commit();
        }

        public IEnumerable<T> BucarTodos()
        {
            return _dataContext.Set<T>();
        }

        public void Commit()
        {
            _dataContext.SaveChanges();
        }
    }
}
