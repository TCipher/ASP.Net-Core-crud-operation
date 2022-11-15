using ASP.NetCoreCrud.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace ASP.NetCoreCrud.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

          
        }
        public DbSet<Category> Categories { get; set; } 
    }
}
