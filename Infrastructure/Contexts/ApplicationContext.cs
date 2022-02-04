using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {


        }

        public DbSet<Person> People { get; set; }
        public DbSet<Identification> Identifications { get; set; }
        public DbSet<IdentificationType > IdentificationTypes{ get; set; }
    }
}