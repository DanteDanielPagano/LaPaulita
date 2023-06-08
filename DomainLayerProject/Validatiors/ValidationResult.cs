namespace DomainLayerProject.Validatiors
{
    public class ValidationResult
    {
        public bool IsValid { get; set; }
        public List<string> Errors { get; set; }

        public ValidationResult() //constructor
        {
            Errors = new List<string>();
        }
    }
}
