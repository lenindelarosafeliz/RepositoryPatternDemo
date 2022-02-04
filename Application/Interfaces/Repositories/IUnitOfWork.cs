using System;

namespace Application.Interfaces.Repositories
{
  public interface IUnitOfWork : IDisposable
    {
        IPeopleRepository People { get; }
        IIdentificationRepository Identificactions { get; }
        IIdentificationTypeRepository IdentificationTypes { get; }
        int Complete();
    }
}
