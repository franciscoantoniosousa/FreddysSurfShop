using FreddysSurfShop.Models;

namespace FreddysSurfShop.ViewModels;

public class SurfboardListViewModel
{
    public IEnumerable<Surfboard> Surfboards { get; }
    public string? CurrentCategory { get; }

    public SurfboardListViewModel(IEnumerable<Surfboard> surfboards, string? currentCategory)
    {
        Surfboards = surfboards;
        CurrentCategory = currentCategory;
    }
}