namespace tsakosPortfolio.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? ShortDescription { get; set; }
        public string? LongDescription { get; set; }
        public string? ImagePath { get; set; }
        public Folder Folder { get; set; } = default!;
    }
}
