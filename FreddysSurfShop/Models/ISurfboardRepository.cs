namespace FreddysSurfShop.Models;

public interface ISurfboardRepository
{
    IEnumerable<Surfboard> AllSurfboards { get; }
    IEnumerable<Surfboard> SurfBoardsOfTheWeek { get; }
    Surfboard? GetSurfboard(int surfboardId);
}