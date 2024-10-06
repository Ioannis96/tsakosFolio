
using System.IO.Pipelines;
using static System.Net.Mime.MediaTypeNames;

namespace tsakosPortfolio.Models
{
    public class MockImageRepository : IImageRepository
    {
        private readonly IFolderRepository _folderRepository = new MockFolderRepository();
        public IEnumerable<Image> AllImages => new List<Image>
        {
                new Image {Id = 1, Name="AEK v PAO 22-01-2001", ShortDescription = "est qui dolorem", LongDescription = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...", ImagePath = "C:\\Users\\johnk\\source\\repos\\tsakosPortfolio\\tsakosPortfolio\\wwwroot\\images\\pexels-delvis-2444852.jpg", Folder = _folderRepository.AllFolders.ToList()[0] },
                new Image {Id = 2, Name="SFA v GEA 12-11-2022", ShortDescription = "est qui dolorem", LongDescription = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...", ImagePath = "C:\\Users\\johnk\\source\\repos\\tsakosPortfolio\\tsakosPortfolio\\wwwroot\\images\\pexels-expressivestanley-3148452.jpg", Folder = _folderRepository.AllFolders.ToList()[0]  },
                new Image {Id = 3, Name="NJH v GSB 23-02-2011", ShortDescription = "est qui dolorem", LongDescription = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...", ImagePath = "C:\\Users\\johnk\\source\\repos\\tsakosPortfolio\\tsakosPortfolio\\wwwroot\\images\\pexels-mali-1415810.jpg", Folder = _folderRepository.AllFolders.ToList()[1]  },
                new Image {Id = 4, Name="FGE v UYJ 25-12-2021", ShortDescription = "est qui dolorem", LongDescription = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...", ImagePath = "C:\\Users\\johnk\\source\\repos\\tsakosPortfolio\\tsakosPortfolio\\wwwroot\\images\\pexels-pixabay-70567.jpg", Folder = _folderRepository.AllFolders.ToList()[1]  }
        };

        public IEnumerable<Image> ImageOfTheWeek => throw new NotImplementedException();

        public Image? GetImageById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
