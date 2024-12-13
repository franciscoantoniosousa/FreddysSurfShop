using FreddysSurfShop.Models;
using FreddysSurfShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FreddysSurfShop.Controllers;

public class SurfboardController : Controller
{
    private readonly ISurfboardRepository _surfboardRepository;
    private readonly ICategoryRepository _categoryRepository;

    public SurfboardController(ISurfboardRepository surfboardRepository, ICategoryRepository categoryRepository)
    {
        _surfboardRepository = surfboardRepository;
        _categoryRepository = categoryRepository;
    }

    public IActionResult List()
    {
        // ViewBag.CurrentCategory = "Mid length";
        // return View(_surfboardRepository.AllSurfboards);
        SurfboardListViewModel surfboardListViewModel =
            new SurfboardListViewModel(_surfboardRepository.AllSurfboards, "Mid length");
        return View(surfboardListViewModel);
    }
}