using BlazorApp3.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp3.Models
{
    public class TodoDbcontext : DbContext
    {


        public DbSet<TodoItem> todoItems { get; set; }

        public TodoDbcontext(DbContextOptions<TodoDbcontext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

    }

}
