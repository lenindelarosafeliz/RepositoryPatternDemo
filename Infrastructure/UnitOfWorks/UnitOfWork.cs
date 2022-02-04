using Application.Interfaces.Repositories;
using Infrastructure.Contexts;

namespace Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;
        public IPeopleRepository People { get; }

        public IIdentificationRepository Identificactions { get; }

        public IIdentificationTypeRepository IdentificationTypes { get; }

        public UnitOfWork(ApplicationContext context,
                          IPeopleRepository people,
                          IIdentificationRepository identificactions,
                          IIdentificationTypeRepository identificationTypes)
        {
            _context = context;
            People = people;
            Identificactions = identificactions;
            IdentificationTypes = identificationTypes;
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
