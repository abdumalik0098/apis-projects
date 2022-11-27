using Microsoft.EntityFrameworkCore;

namespace WebAppMinimalApi
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Todo> Todos => Set<Todo>();
    }
}
