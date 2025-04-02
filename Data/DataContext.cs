using CelestialObject.Models;
using Microsoft.EntityFrameworkCore;

namespace CelestialObject.Data
{
    public class DataContext : DbContext
    {
        public DbSet<CelestialObjects> CelestialObjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=celestialobjects;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}
