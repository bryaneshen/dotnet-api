using System.ComponentModel.DataAnnotations;

namespace Commander.Models
{
    public class Command {
        // Defining the properties for the model
        
        [Key] // saying that the Id is the primary key
        public int Id { get; set; }
        
        [Required] // this makes it so that it won't be null in the DB
        [MaxLength(250)]
        public string HowTo { get; set; }
        
        [Required]
        public string Line { get; set; } // the command line snippet we'll store in our DB
        
        [Required]
        public string Platform { get; set; } // the application platform our command line relates to 
    }
}