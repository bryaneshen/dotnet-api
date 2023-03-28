using System;
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

        public void createCommand(Command cmd)
        {
            if (cmd == null) {
                throw new ArgumentNullException(nameof(cmd));
            }
            // adding the data to the DB
            _context.Commands.Add(cmd);
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

        public bool saveChanges()
        {
            // whenever you make a change to the data via DbContext, the data won't be changed on the DB unless you call this method
            return (_context.SaveChanges() >= 0);
        }
    }
}