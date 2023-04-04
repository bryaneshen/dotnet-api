using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    // This class is the repository and it interacts with the data and the database.
    // The class implements the ICommanderRepo interface
    public class MockCommanderRepo : ICommanderRepo
    {
        public void createCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void deleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> getAllCommands()
        {
            // just hardcoding some fake data right now
            var commands = new List<Command> {
                new Command{Id=0, HowTo="bofa", Line="coffee", Platform="seven"},
                new Command{Id=1, HowTo="ligma", Line="tea", Platform="family"},
                new Command{Id=2, HowTo="sug", Line="water", Platform="lawsons"}
            };
            return commands;
        }

        public Command getCommandById(int id)
        {
            // returning some hardcoded data for now
            return new Command{Id=0, HowTo="bofa", Line="coffee", Platform="seven"};
        }

        public bool saveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void updateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}