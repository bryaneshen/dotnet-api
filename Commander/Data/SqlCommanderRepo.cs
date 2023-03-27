using System.Collections.Generic;
using System.Linq;
using Commander.Models;

namespace Commander.Data 
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;

        // use dependency injection to get an instance of our DbContext (CommanderContext) class
        public SqlCommanderRepo(CommanderContext context)
        {
            _context = context;
        }
        // want to make use of our CommanderContext class to return our items from our DB
        public IEnumerable<Command> getAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command getCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }
    }
}