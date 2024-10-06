using tsakosPortfolio.Models;

namespace tsakosFolio.ViewModels
{
    public class ImageListViewModel
    {
        public IEnumerable<Image> Images { get; }
        public string? CurrentFolder { get; }
        public ImageListViewModel(IEnumerable<Image> images, string? currentFolder)
        {
            Images = images;
            CurrentFolder = currentFolder;
        }
    }
}
