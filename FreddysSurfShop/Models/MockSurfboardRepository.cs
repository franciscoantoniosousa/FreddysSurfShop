namespace FreddysSurfShop.Models;

public class MockSurfboardRepository : ISurfboardRepository
{
    private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

    public IEnumerable<Surfboard> AllSurfboards =>
        new List<Surfboard>
        {
            new Surfboard
                { BoardId = 1, Name = "Rocket Cruise", Category = _categoryRepository.AllCategories.ToList()[0], IsSurfboardOfTheWeek = false },
            new Surfboard
                { BoardId = 2, Name = "Fish Cruise", Category = _categoryRepository.AllCategories.ToList()[1], IsSurfboardOfTheWeek = true},
            new Surfboard
                { BoardId = 3, Name = "Mid Cruise", Category = _categoryRepository.AllCategories.ToList()[2], IsSurfboardOfTheWeek = false },
            new Surfboard
                { BoardId = 4, Name = "Long Cruise", Category = _categoryRepository.AllCategories.ToList()[3], IsSurfboardOfTheWeek = true },
        };

    public IEnumerable<Surfboard> SurfBoardsOfTheWeek
    {
        get
        {
            return AllSurfboards.Where(s => s.IsSurfboardOfTheWeek);
        }
    }

    public Surfboard? GetSurfboard(int surfboardId) => AllSurfboards.FirstOrDefault(s => s.BoardId == surfboardId);

}