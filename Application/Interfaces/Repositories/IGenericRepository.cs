using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Application.Interfaces.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(int Id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        bool Exist(int id);
        int Count(T entity);
        void Remove(int id);
        void Update(int i, T entity);
        void RemoveRage(IEnumerable<T> entities);
       // void Save();
    }
}
