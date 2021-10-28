using Microsoft.EntityFrameworkCore;

namespace simple_api.Models
{
    public class SimpleApiDbContext : DbContext
    {
        public DbSet<SimpleData> SimpleDatas { get; set; }
    }
}