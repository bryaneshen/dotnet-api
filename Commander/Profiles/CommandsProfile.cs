using AutoMapper;
using Commander.Dto;
using Commander.Models;

namespace Commander.Profiles
{
    // This class is to create the mapping between the DTO and the internal domain model (the Command object) 
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            // Creating a map to map between a source object and the destination object
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
        }
    }
}