using Application.Interfaces.Repositories;
using Domain.Entities;
using Infrastructure.Contexts;

namespace Infrastructure.Repositories
{
public class PeopleRepository : GenericRepository<Person>, IPeopleRepository
    {
        public PeopleRepository(ApplicationContext context) : base(context)
        {

        }
    }
}