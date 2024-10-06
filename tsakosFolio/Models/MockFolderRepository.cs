namespace tsakosPortfolio.Models
{
    public class MockFolderRepository : IFolderRepository
    {
        public IEnumerable<Folder> AllFolders =>
            new List<Folder>
            {
                new Folder{Id = 1, Name="PAO-AEK", Description= "To Match htan Kalo" },
                new Folder{Id = 2, Name="PAO-OSFP", Description= "To Match htan Kalo" },
                new Folder{Id = 3, Name="OSFP-AEK", Description= "To Match htan Kalo" },
            };
    }
}
