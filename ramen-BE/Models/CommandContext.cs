using Microsoft.EntityFrameworkCore;

namespace ramen_BE.Models
{
    public class CommandContext : DbContext
    {
        public CommandContext(DbContextOptions<CommandContext> options) :base (options)
        {

        }
        
        public DbSet<Command> CommandItems {get; set;}
    }
}