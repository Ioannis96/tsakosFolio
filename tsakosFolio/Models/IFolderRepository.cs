namespace tsakosPortfolio.Models
{
    public interface IFolderRepository
    {
        IEnumerable<Folder> AllFolders { get; }
    }
}
