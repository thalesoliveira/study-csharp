using System;
using System.Collections.Generic;
using System.Text;

namespace DomCesarPizza.Domain.Interfaces
{
    public interface IRepositoryBase<T> : IDisposable where T : class, IEntity
    {
        void Create(T entity);
        void Update(T entity);
        T FindById(int id);
        void Delete(int id);
        List<T> GetAll();
    }
}
