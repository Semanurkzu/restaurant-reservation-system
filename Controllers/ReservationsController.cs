using Microsoft.AspNetCore.Mvc;
using RestaurantReservationSystem.Models;

namespace RestaurantReservationSystem.Controllers;

public class ReservationsController : Controller
{
    private static readonly List<Reservation> Reservations = new()
    {
        new() { Id = 1, CustomerName = "Beyza", Phone = "0500 000 00 01", ReservationDate = DateTime.Today.AddDays(1).AddHours(19), GuestCount = 3, Status = "Onaylandı" },
        new() { Id = 2, CustomerName = "Nisa", Phone = "0500 000 00 02", ReservationDate = DateTime.Today.AddDays(2).AddHours(20), GuestCount = 2, Status = "Bekliyor" }
    };

    public IActionResult Index()
    {
        return View(Reservations.OrderBy(reservation => reservation.ReservationDate).ToList());
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

        if (!ModelState.IsValid)
        {
            return View(reservation);
        }

        reservation.Id = Reservations.Count == 0 ? 1 : Reservations.Max(item => item.Id) + 1;
        reservation.Status = "Bekliyor";
        Reservations.Add(reservation);

        TempData["ReservationName"] = reservation.CustomerName;
        TempData["ReservationDate"] = reservation.ReservationDate.ToString("dd.MM.yyyy HH:mm");
        return RedirectToAction(nameof(Success));
    }

    public IActionResult Success()
    {
        return View();
    }
}
