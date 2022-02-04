using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Application.Interfaces.Services
{
   public interface IIdentificationTypeService
    {
        IEnumerable<IdentificationType> GetAll();
        IdentificationType GetById(int id);
        IEnumerable<IdentificationType> Find(Expression<Func<IdentificationType, bool>> expression);
        void Add(IdentificationType entity);
        void AddRange(IEnumerable<IdentificationType> entities);
        void Remove(IdentificationType entity);
        bool Exist(int id);
        int Count(IdentificationType entity);
        void Remove(int id);
        void Update(int id, IdentificationType entity);
        void RemoveRage(IEnumerable<IdentificationType> entities);
    }
}
