namespace tsakosPortfolio.Models
{
    public interface IImageRepository
    {
        IEnumerable<Image> AllImages { get; }
        IEnumerable<Image> ImageOfTheWeek { get; }
        Image? GetImageById(int id);
    }
}
