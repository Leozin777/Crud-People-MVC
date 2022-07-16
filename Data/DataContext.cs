using CrudMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudMvc.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts) : base(opts)
        { }

        public DbSet<People> People { get; set; }
    }
}
