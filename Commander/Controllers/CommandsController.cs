using System.Collections.Generic;
using AutoMapper;
using Commander.Data;
using Commander.Dto;
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
        private readonly IMapper _mapper;

        // constructor for our dependency injection system
        public CommandsController(ICommanderRepo repository, IMapper mapper)
        {
            // Dependency injection; we are assigning the dependency injected value into our private field.
            // this makes it so that we're able to access the data when we assign the value of the instance of our repository.
            _repository = repository;
            _mapper = mapper;
        }

        // GET request that responds to api/commands
        [HttpGet]
        public ActionResult <IEnumerable<CommandReadDto>> getAllCommands() {
            var commandItems = _repository.getAllCommands();
            return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commandItems));
        }

        // GET request that responds to api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <CommandReadDto> getCommandById(int id) {  
            var commandItem = _repository.getCommandById(id);
            if (commandItem != null) {
                // returning a CommandReadDTO that's mapped from the Command object
                return Ok(_mapper.Map<CommandReadDto>(commandItem));
            }
            return NotFound();
        }

        // POST request that responds to api/commands. Returns back a CommandReadDto
        [HttpPost]
        public ActionResult <CommandReadDto> createCommand(CommandCreateDto commandCreateDto)
        {
            // converting what we got from the request body into a Command object, so we can store it into our DB.
            var commandModel = _mapper.Map<Command>(commandCreateDto);
            _repository.createCommand(commandModel);
            _repository.saveChanges();

            return Ok(commandModel);
        }
    }
}