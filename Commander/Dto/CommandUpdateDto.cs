using System.ComponentModel.DataAnnotations;

namespace Commander.Dto
{
    public class CommandUpdateDto {
        // Defining the properties for the model
        
        // we don't need the Id field for when we create a new Command because it will automatically be created in our DB

        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }
        
        [Required]
        public string Line { get; set; } // the command line snippet we'll store in our DB

        [Required]
        public string Platform { get; set; }
    }
}