using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Domain.Entities;

namespace Application.Interfaces.Services
{
    public interface IIdentificationService
    {
        IEnumerable<Identification> GetAll();
        Identification GetById();
        IEnumerable<Identification> Find(Expression<Func<Identification, bool>> expression);
        void Add(Identification entity);
        void AddRange(IEnumerable<Identification> entities);
        void Remove(Identification entity);
        bool Exist(int id);
        int Count(Identification entity);
        void Remove(int id);
        void Update(int i, Identification entity);
        void RemoveRage(IEnumerable<Identification> entities);
    }
}
