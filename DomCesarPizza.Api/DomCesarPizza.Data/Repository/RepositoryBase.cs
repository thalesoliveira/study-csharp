using DomCesarPizza.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomCesarPizza.Data.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class, IEntity
    {
        protected readonly Contexto _contexto;
        public RepositoryBase(Contexto contexto)
        {
            _contexto = contexto;
        }

        public void Create(T entity)
        {
            _contexto.Set<T>().Add(entity);
            _contexto.SaveChanges();
        }

        public void Update(T entity)
        {
            _contexto.Set<T>().Update(entity);
            _contexto.SaveChanges();
        }

        public T FindById(int id)
        {
            return _contexto.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public void Delete(int id)
        {
            var entity = FindById(id);
            _contexto.Set<T>().Remove(entity);
            _contexto.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _contexto.Set<T>().ToList();
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }
    }
}
