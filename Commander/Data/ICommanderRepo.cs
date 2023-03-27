using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
// Interface class for our repository folder.
/* 
Creating an interface for the repository so that it can act as a contract for the repo, 
so we can implement that interface as we go along implementing the repo to abide by that contract.
Just defining all of the methods that will be available
*/
    public interface ICommanderRepo {
        // method to return a list of all our command objects
        IEnumerable<Command> getAllCommands();

        // method to return one command
        Command getCommandById(int id);
    }
}
