using RestaurantReservationSystem.Models;

namespace RestaurantReservationSystem.Services;

// Uygulama boyunca tek örnek (singleton) olarak yaşar; formdan eklenen rezervasyonlar
// rezervasyon listesi, başarı sayfası ve ViewComponent tarafından ortak okunur.
public class ReservationStore
{
    private readonly object _sync = new();
    private readonly List<Reservation> _reservations = new()
    {
        new() { Id = 1, CustomerName = "Beyza", Phone = "0500 000 00 01", ReservationDate = DateTime.Today.AddDays(1).AddHours(19), GuestCount = 3, SeatingArea = "Şef Masası", IsSpecialOccasion = true, Note = "Doğum günü sürprizi.", Status = "Onaylandı" },
        new() { Id = 2, CustomerName = "Nisa", Phone = "0500 000 00 02", ReservationDate = DateTime.Today.AddDays(2).AddHours(20), GuestCount = 2, SeatingArea = "Teras", Status = "Bekliyor" }
    };

    public IReadOnlyList<Reservation> GetAll()
    {
        lock (_sync)
        {
            return _reservations.OrderBy(reservation => reservation.ReservationDate).ToList();
        }
    }

    public IReadOnlyList<Reservation> GetUpcoming(int count)
    {
        lock (_sync)
        {
            return _reservations
                .Where(reservation => reservation.ReservationDate > DateTime.Now)
                .OrderBy(reservation => reservation.ReservationDate)
                .Take(count)
                .ToList();
        }
    }

    public Reservation? Find(int id)
    {
        lock (_sync)
        {
            return _reservations.FirstOrDefault(reservation => reservation.Id == id);
        }
    }

    public Reservation Add(Reservation reservation)
    {
        lock (_sync)
        {
            reservation.Id = _reservations.Count == 0 ? 1 : _reservations.Max(item => item.Id) + 1;
            reservation.Status = "Bekliyor";
            _reservations.Add(reservation);
            return reservation;
        }
    }
}
