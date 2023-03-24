using Commander.Models;
using Microsoft.EntityFrameworkCore;

namespace Commander.Data
{
    // This class is the context class, it's to access the actual database
    public class CommanderContext : DbContext
    {
        // calling the constructor from the DbContext
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {
            
        }

        // creating the representation of the Command model in our database. We'll do that by using a DB set.
        // we want to represent our Command object into our database as a DbSet and it will be called "Commands"
        public DbSet<Command> Commands { get; set; }

    }
}

// Migrations are a list of instructions given to our db to allow it to create/recreate a db schema that mirrors our internal representation of the data within our application