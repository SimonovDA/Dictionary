namespace Dictionary.Data.Models
{
    public record User : BaseEntry
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
