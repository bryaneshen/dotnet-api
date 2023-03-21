using System.Collections.Generic;
using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

// Convention to name our controller plurallly, and to name our model to be non-plural
// Note: IEnumerable in C# is read only, where as a list is not. IEnumerable is also an interface
namespace Commader.Controllers
{
    // This is the base route is for getting to the API endpoints within our controller.
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase {
        // creating a new instance of our repo so that we can access the data
        public readonly MockCommanderRepo _repository = new MockCommanderRepo();

        // GET request that responds to api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Command>> getAllCommands() {
            var commandItems = _repository.getAppCommands();
            return Ok(commandItems);
        }

        // GET request that responds to api/commands/{int id}
        [HttpGet("{id}")]
        public ActionResult <Command> getCommandById(int id) {
            var commandItem = _repository.getCommandById(id);
            return Ok(commandItem);
        }
    }
}