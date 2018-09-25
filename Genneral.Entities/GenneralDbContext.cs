using Microsoft.EntityFrameworkCore;
using Genneral.Entities.Category;

namespace Genneral.Entities
{
    public class GenneralDbContext : DbContext
    {
        public GenneralDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Category.Category> Categories { get; set; }
    }
}
