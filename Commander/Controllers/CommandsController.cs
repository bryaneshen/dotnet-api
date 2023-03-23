using System.Collections.Generic;
using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

// Convention to name our controller plurallly, and to name our model to be non-plural
// Note: IEnumerable in C# is read only, where as a list is not. IEnumerable is also an interface

/*
This is the controller class. The HTTP requests will go to here and the Controller class handles it.
*/
namespace Commader.Controllers
{
    // This is the base route is for getting to the API endpoints within our controller.
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase {
        private readonly ICommanderRepo _repository;

        // constructor for our dependency injection system
        public CommandsController(ICommanderRepo repository)
        {
            // Dependency injection; we are assigning the dependency injected value into our private field.
            // this makes it so that we're able to access the data when we assign the value of the instance of our repository.
            _repository = repository;
        }

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