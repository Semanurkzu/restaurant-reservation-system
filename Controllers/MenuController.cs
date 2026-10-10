using Microsoft.AspNetCore.Mvc;
using RestaurantReservationSystem.Models;

namespace RestaurantReservationSystem.Controllers;

public class MenuController : Controller
{
    private static readonly IReadOnlyList<MenuItem> MenuItems = new List<MenuItem>
    {
        new() { Id = 1, Name = "Füme Patlıcan", Description = "İsli yoğurt, ceviz ve nar ekşisi ile.", Category = "Başlangıç", Price = 185, AccentClass = "accent-sage", IsChefSpecial = true },
        new() { Id = 2, Name = "Deniz Mahsullü Risotto", Description = "Karides, kalamar, safran ve parmesan ile.", Category = "Ana Yemek", Price = 465, AccentClass = "accent-ocean", IsChefSpecial = true },
        new() { Id = 3, Name = "Dana Kaburga", Description = "Sekiz saat pişmiş kaburga, patates püresi ve demi-glace.", Category = "Ana Yemek", Price = 540, AccentClass = "accent-terracotta" },
        new() { Id = 4, Name = "Mevsim Bahçesi", Description = "Taze yeşillikler, keçi peyniri ve turunç sos.", Category = "Salata", Price = 220, AccentClass = "accent-sage" },
        new() { Id = 5, Name = "Limonlu Cheesecake", Description = "Limon kreması, badem kırığı ve orman meyveleri.", Category = "Tatlı", Price = 195, AccentClass = "accent-lemon" },
        new() { Id = 6, Name = "İmza Kokteyli", Description = "Narenciye, fesleğen ve ev yapımı şurup.", Category = "İçecek", Price = 170, AccentClass = "accent-ocean" },
        new() { Id = 7, Name = "Dana Wellington", Description = "Mantar duxelles, ince çıtır hamur, kök sebzeler ve kırmızı şarap jus.", Category = "Ana Yemek", Price = 790, AccentClass = "accent-terracotta", IsChefSpecial = true, InspiredBy = "Gordon Ramsay" },
        new() { Id = 8, Name = "Miso Siyah Morina", Description = "Üç gün misoda dinlendirilmiş morina, zencefil turşusu ve narenciye.", Category = "Ana Yemek", Price = 720, AccentClass = "accent-ocean", IsChefSpecial = true, InspiredBy = "Nobu Matsuhisa" },
        new() { Id = 9, Name = "Et Meyvesi", Description = "Mandalina görünümünde tavuk ciğeri parfe, ızgara ekşi maya ve baharatlı jöle.", Category = "Başlangıç", Price = 395, AccentClass = "accent-lemon", InspiredBy = "Heston Blumenthal" },
        new() { Id = 10, Name = "İstiridye ve İnciler", Description = "İstiridye, inci tapiyoka sabayon, mersin balığı ve havyar dokunuşu.", Category = "Başlangıç", Price = 610, AccentClass = "accent-ocean", InspiredBy = "Thomas Keller" },
        new() { Id = 11, Name = "Düşen Limon Tartı", Description = "Limon kreması, kırılgan tart parçaları, bergamot ve yoğunlaştırılmış süt dondurması.", Category = "Tatlı", Price = 290, AccentClass = "accent-lemon", IsChefSpecial = true, InspiredBy = "Massimo Bottura" }
    };

    public IActionResult Index(string? category)
    {
        var items = string.IsNullOrWhiteSpace(category)
            ? MenuItems
            : MenuItems.Where(item => item.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();

        ViewData["SelectedCategory"] = category;
        ViewData["Categories"] = MenuItems.Select(item => item.Category).Distinct().ToList();
        return View(items);
    }

    public IActionResult Details(int id)
    {
        var item = MenuItems.FirstOrDefault(menuItem => menuItem.Id == id);
        return item is null ? NotFound() : View(item);
    }
}
