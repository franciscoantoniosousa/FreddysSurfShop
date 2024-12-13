namespace FreddysSurfShop.Models;

public class MockCategoryRepository : ICategoryRepository
{
    public IEnumerable<Category> AllCategories =>
        new List<Category>
        {
            new Category { CategoryId = 1, CategoryName = "Short-board", Description = "Performance boards" },
            new Category { CategoryId = 2, CategoryName = "Fish", Description = "Fish surfboard" },
            new Category { CategoryId = 3, CategoryName = "Mid length", Description = "Mid length surfboard" },
            new Category { CategoryId = 4, CategoryName = "Long-board", Description = "Long-board surfboard" },
        };
}