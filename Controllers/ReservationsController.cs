using Microsoft.AspNetCore.Mvc;
using RestaurantReservationSystem.Models;
using RestaurantReservationSystem.Services;

namespace RestaurantReservationSystem.Controllers;

public class ReservationsController : Controller
{
    private readonly ReservationStore _store;

    public ReservationsController(ReservationStore store)
    {
        _store = store;
    }

    public IActionResult Index()
    {
        return View(_store.GetAll());
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View(new Reservation
        {
            ReservationDate = DateTime.Today.AddDays(1).AddHours(19),
            GuestCount = 2
        });
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Reservation reservation)
    {
        if (reservation.ReservationDate <= DateTime.Now)
        {
            ModelState.AddModelError(nameof(reservation.ReservationDate), "Rezervasyon tarihi gelecekte olmalıdır.");
        }

        if (!string.IsNullOrEmpty(reservation.SeatingArea) && !Reservation.SeatingAreas.Contains(reservation.SeatingArea))
        {
            ModelState.AddModelError(nameof(reservation.SeatingArea), "Geçerli bir oturma tercihi seçiniz.");
        }

        if (!ModelState.IsValid)
        {
            return View(reservation);
        }

        var saved = _store.Add(reservation);
        TempData["NewReservationId"] = saved.Id;
        return RedirectToAction(nameof(Success), new { id = saved.Id });
    }

    public IActionResult Success(int id)
    {
        var reservation = _store.Find(id);
        return reservation is null ? RedirectToAction(nameof(Index)) : View(reservation);
    }
}
