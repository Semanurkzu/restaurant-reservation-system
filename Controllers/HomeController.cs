using Microsoft.AspNetCore.Mvc;

namespace RestaurantReservationSystem.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewData["TonightTableCount"] = 8;
        ViewData["MenuItemCount"] = 12;
        return View();
    }

    public IActionResult About()
    {
        return View();
    }

    public IActionResult Error()
    {
        return View("Index");
    }
}
