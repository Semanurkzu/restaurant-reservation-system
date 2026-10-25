using Microsoft.AspNetCore.Mvc;
using RestaurantReservationSystem.Services;

namespace RestaurantReservationSystem.ViewComponents;

// Yaklaşan rezervasyonları kendi verisini çekerek gösteren bağımsız bileşen.
// Ana sayfada ve "Masa Ayır" sayfasında farklı parametrelerle kullanılır.
public class UpcomingReservationsViewComponent : ViewComponent
{
    private readonly ReservationStore _store;

    public UpcomingReservationsViewComponent(ReservationStore store)
    {
        _store = store;
    }

    public IViewComponentResult Invoke(int count = 3, string title = "Yaklaşan masalar")
    {
        ViewData["WidgetTitle"] = title;
        return View(_store.GetUpcoming(count));
    }
}
