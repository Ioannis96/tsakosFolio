namespace tsakosPortfolio.Models
{
    public class Folder
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public List<Image>? Images { get; set; }
    }
}
