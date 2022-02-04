using Application.Interfaces.Repositories;
using Domain.Entities;
using Infrastructure.Contexts;

namespace Infrastructure.Repositories
{
    public class IdentificationRepository : GenericRepository<Identification>, IIdentificationRepository
    {
        public IdentificationRepository(ApplicationContext context) : base(context)
        {

        }
    }
}