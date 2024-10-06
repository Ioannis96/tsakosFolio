using Microsoft.AspNetCore.Mvc;
using tsakosFolio.ViewModels;
using tsakosPortfolio.Models;

namespace tsakosPortfolio.Controllers
{
    public class ImageController : Controller
    {
        private readonly IImageRepository _imageRepository;
        private readonly IFolderRepository _folderRepository;

        public ImageController(IImageRepository imageRepository, IFolderRepository folderRepository)
        {
            _imageRepository = imageRepository;
            _folderRepository = folderRepository;
        }

        public IActionResult List()
        {
            ImageListViewModel imageVM = new ImageListViewModel (_imageRepository.AllImages, "Eikonitses :)");
            return View(imageVM);
        }

        public IActionResult Test()
        {
            ViewBag.Folder = "PAO-AEK";
            return View(_imageRepository.AllImages);
        }

    }
}
