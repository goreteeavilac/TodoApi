using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {
        //contructor-contexto que utilizamos para funcinar el scanffold
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) 
        {

        }
        public DbSet<TodoItem> TodoItems { get; set; } = null!;
    }
}
