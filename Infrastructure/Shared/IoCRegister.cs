using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using Infrastructure.Contexts;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Shared
{
    public static class IoCRegister
    {
        public static void AddInfrastucture(this IServiceCollection services, IConfiguration configuration)
        {
            //Contexts
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            
            //Repositories
            services.AddRegisterRepository();

            //Services
            services.AddRegisterServices();
        }

        public static IServiceCollection AddRegisterRepository(this IServiceCollection services)
        {
            return services.AddTransient<IPeopleRepository, PeopleRepository>()
               .AddTransient<IIdentificationRepository, IdentificationRepository>()
               .AddTransient<IIdentificationTypeRepository, IdentificationTypeRepository>()
               .AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>))
               .AddTransient<IUnitOfWork, UnitOfWork>();
        }

        public static IServiceCollection AddRegisterServices(this IServiceCollection services)
        {
            return services.AddTransient<IIdentificationTypeService, IdentificationTypeService>();
        }
    }
}
