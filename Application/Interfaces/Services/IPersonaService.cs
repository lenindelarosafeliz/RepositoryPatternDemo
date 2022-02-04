using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Application.Interfaces.Services
{
    public interface IPersonaService
    {
        IEnumerable<Person> GetAll();
        Person GetById();
        IEnumerable<Person> Find(Expression<Func<Person, bool>> expression);
        void Add(Person entity);
        void AddRange(IEnumerable<Person> entities);
        void Remove(Person entity);
        bool Exist(int id);
        int Count(Person entity);
        void Remove(int id);
        void Update(int i, Person entity);
        void RemoveRage(IEnumerable<Person> entities);
    }
}