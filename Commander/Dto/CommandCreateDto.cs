namespace Commander.Dto
{
    public class CommandCreateDto {
        // Defining the properties for the model
        
        // we don't need the Id field for when we create a new Command because it will automatically be created in our DB
        
        public string HowTo { get; set; }
        
        public string Line { get; set; } // the command line snippet we'll store in our DB

        public string Platform { get; set; }
    }
}