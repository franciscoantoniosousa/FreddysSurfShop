namespace FreddysSurfShop.Models;

public class MockSurfboardRepository : ISurfboardRepository
{
    private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

    public IEnumerable<Surfboard> AllSurfboards =>
        new List<Surfboard>
        {
            new Surfboard
            {
                BoardId = 1, Name = "Rocket Cruise",
                Category = _categoryRepository.AllCategories.ToList()[0],
                IsSurfboardOfTheWeek = false,
                Price = 400,
                InStock = true,
                ImageThumbnailUrl = "https://d3iswawdztsslu.cloudfront.net/46/surfboards/18886214695df9.png"
            },
            new Surfboard
            {
                BoardId = 2, Name = "Fish Cruise", Category = _categoryRepository.AllCategories.ToList()[1],
                IsSurfboardOfTheWeek = true,
                Price = 600,
                InStock = true,
                ImageThumbnailUrl = "https://d3iswawdztsslu.cloudfront.net/46/surfboards/1799413065df81.png"
            },
            new Surfboard
            {
                BoardId = 3, Name = "Mid Cruise",
                Category = _categoryRepository.AllCategories.ToList()[2],
                IsSurfboardOfTheWeek = false,
                Price = 700,
                InStock = true,
                ImageThumbnailUrl = "https://d3iswawdztsslu.cloudfront.net/46/surfboards/21036908445ea0.png"
            },
            new Surfboard
            {
                BoardId = 4, Name = "Long Cruise",
                Category = _categoryRepository.AllCategories.ToList()[3],
                IsSurfboardOfTheWeek = true,
                Price = 900,
                InStock = true,
                ImageThumbnailUrl = "https://d3iswawdztsslu.cloudfront.net/46/surfboards/15035815215fdf.png"
            },
        };

    public IEnumerable<Surfboard> SurfBoardsOfTheWeek
    {
        get { return AllSurfboards.Where(s => s.IsSurfboardOfTheWeek); }
    }

    public Surfboard? GetSurfboard(int surfboardId) => AllSurfboards.FirstOrDefault(s => s.BoardId == surfboardId);
}