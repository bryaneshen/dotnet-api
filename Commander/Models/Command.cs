namespace Commander.Models
{
    public class Command {
        // Defining the properties for the model
        public int Id { get; set; }
        public string HowTo { get; set; }
        public string Line { get; set; } // the command line snippet we'll store in our DB
        public string Platform { get; set; } // the application platform our command line relates to 
    }
}