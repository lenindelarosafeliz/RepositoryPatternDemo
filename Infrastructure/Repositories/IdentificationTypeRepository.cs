using Application.Interfaces.Repositories;
using Domain.Entities;
using Infrastructure.Contexts;

namespace Infrastructure.Repositories
{
  public  class IdentificationTypeRepository: GenericRepository<IdentificationType>, IIdentificationTypeRepository
    {
        public IdentificationTypeRepository(ApplicationContext context): base(context)
        {

        }
    }
}
