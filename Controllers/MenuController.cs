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
        new() { Id = 6, Name = "Alkolsüz İmza İçeceği", Description = "Narenciye, fesleğen ve ev yapımı şurup.", Category = "İçecek", Price = 170, AccentClass = "accent-ocean" },
        new() { Id = 7, Name = "Dana Wellington", Description = "Mantar duxelles, ince çıtır hamur, kök sebzeler ve nar-ekşi erik jus.", Category = "Ana Yemek", Price = 790, AccentClass = "accent-terracotta", IsChefSpecial = true, InspiredBy = "Gordon Ramsay" },
        new() { Id = 8, Name = "Miso Siyah Morina", Description = "Üç gün misoda dinlendirilmiş morina, zencefil turşusu ve narenciye.", Category = "Ana Yemek", Price = 720, AccentClass = "accent-ocean", IsChefSpecial = true, InspiredBy = "Nobu Matsuhisa" },
        new() { Id = 9, Name = "Et Meyvesi", Description = "Mandalina görünümünde tavuk ciğeri parfe, ızgara ekşi maya ve baharatlı jöle.", Category = "Başlangıç", Price = 395, AccentClass = "accent-lemon", InspiredBy = "Heston Blumenthal" },
        new() { Id = 10, Name = "İstiridye ve İnciler", Description = "İstiridye, inci tapiyoka sabayon, mersin balığı ve havyar dokunuşu.", Category = "Başlangıç", Price = 610, AccentClass = "accent-ocean", InspiredBy = "Thomas Keller" },
        new() { Id = 11, Name = "Düşen Limon Tartı", Description = "Limon kreması, kırılgan tart parçaları, bergamot ve yoğunlaştırılmış süt dondurması.", Category = "Tatlı", Price = 290, AccentClass = "accent-lemon", IsChefSpecial = true, InspiredBy = "Massimo Bottura" },
        new() { Id = 12, Name = "Köz Kereviz", Description = "Kereviz kreması, yanık elma, fındık ve adaçayı yağı.", Category = "Başlangıç", Price = 340, AccentClass = "accent-sage" },
        new() { Id = 13, Name = "Deniz Tarağı", Description = "Karnabahar ipeği, yeşil elma ve limon otu.", Category = "Başlangıç", Price = 680, AccentClass = "accent-ocean", IsChefSpecial = true },
        new() { Id = 14, Name = "Enginar Kalbi", Description = "Bakla ezmesi, dereotu emülsiyonu ve çıtır pirinç.", Category = "Başlangıç", Price = 360, AccentClass = "accent-sage" },
        new() { Id = 15, Name = "İçli Köfte Yorumu", Description = "İnce bulgur çıtırı, kuzu tartar ve isot kreması.", Category = "Başlangıç", Price = 440, AccentClass = "accent-terracotta" },
        new() { Id = 16, Name = "Pancar Gülü", Description = "İsli keçi peyniri, vişne ve kavrulmuş çekirdek.", Category = "Başlangıç", Price = 325, AccentClass = "accent-terracotta" },
        new() { Id = 17, Name = "Kuzu Sırtı", Description = "Fermente biber, firik buğdayı ve kekik jus.", Category = "Ana Yemek", Price = 860, AccentClass = "accent-terracotta", IsChefSpecial = true },
        new() { Id = 18, Name = "Ege Levreği", Description = "Rezene, koruk sosu ve deniz börülcesi.", Category = "Ana Yemek", Price = 745, AccentClass = "accent-ocean" },
        new() { Id = 19, Name = "Ördek Göğsü", Description = "Vişne, mor havuç ve kakuleli ördek jus.", Category = "Ana Yemek", Price = 825, AccentClass = "accent-terracotta" },
        new() { Id = 20, Name = "Trüflü Mantı", Description = "Minik dana mantısı, manda yoğurdu ve siyah trüf.", Category = "Ana Yemek", Price = 640, AccentClass = "accent-sage" },
        new() { Id = 21, Name = "Karnabahar", Description = "Köz karnabahar, tahin, kapari ve limon konfi.", Category = "Ana Yemek", Price = 520, AccentClass = "accent-sage" },
        new() { Id = 22, Name = "Narenciye & Rezene", Description = "Kan portakalı, rezene, taze badem ve sumak.", Category = "Salata", Price = 280, AccentClass = "accent-lemon" },
        new() { Id = 23, Name = "Izgara Şeftali", Description = "Burrata, fesleğen yağı ve domates suyu.", Category = "Salata", Price = 315, AccentClass = "accent-sage" },
        new() { Id = 24, Name = "Antep Fıstığı", Description = "Fıstık pralin, baklava yaprağı ve süt dondurması.", Category = "Tatlı", Price = 320, AccentClass = "accent-sage", IsChefSpecial = true },
        new() { Id = 25, Name = "Kakao Bahçesi", Description = "Bitter kakao, keçiboynuzu karamel ve kahve toprağı.", Category = "Tatlı", Price = 310, AccentClass = "accent-terracotta" },
        new() { Id = 26, Name = "Ayva & Ihlamur", Description = "Poşe ayva, ıhlamur kreması ve ceviz kıtırı.", Category = "Tatlı", Price = 285, AccentClass = "accent-lemon" },
        new() { Id = 27, Name = "Sumak Tonik", Description = "Sumak, pembe greyfurt, ardıç ve soda; tamamen alkolsüz.", Category = "İçecek", Price = 190, AccentClass = "accent-terracotta" },
        new() { Id = 28, Name = "Beyaz Çay & Yasemin", Description = "Soğuk demleme beyaz çay, yasemin ve beyaz şeftali.", Category = "İçecek", Price = 185, AccentClass = "accent-lemon" },
        new() { Id = 29, Name = "Kavrulmuş Elma", Description = "Elma kabuğu, tarçın, tütsülenmiş çay ve soda; tamamen alkolsüz.", Category = "İçecek", Price = 195, AccentClass = "accent-sage" }
    };

    private static readonly IReadOnlyList<TastingCourse> TastingMenu = new List<TastingCourse>
    {
        new() { Sequence = 1, Moment = "Karşılama", Name = "Sumak Bulutu", Description = "Nar suyu, sumak ve fesleğen yağı." },
        new() { Sequence = 2, Moment = "Tek Lokma", Name = "Tarhana Çıtırı", Description = "Olgun domates ve süzme yoğurt." },
        new() { Sequence = 3, Moment = "Tek Lokma", Name = "Zeytin Taşı", Description = "Gemlik zeytini, kekik ve badem." },
        new() { Sequence = 4, Moment = "Soğuk", Name = "Pancar Gülü", Description = "İsli keçi peyniri ve vişne." },
        new() { Sequence = 5, Moment = "Soğuk", Name = "Enginar", Description = "Bakla, dereotu ve limon." },
        new() { Sequence = 6, Moment = "Deniz", Name = "İstiridye İncisi", Description = "Salatalık, elma ve deniz börülcesi." },
        new() { Sequence = 7, Moment = "Sıcak", Name = "Köz Kereviz", Description = "Yanık elma ve fındık." },
        new() { Sequence = 8, Moment = "Hamur", Name = "Minik Mantı", Description = "Manda yoğurdu ve siyah trüf." },
        new() { Sequence = 9, Moment = "Deniz", Name = "Ege Levreği", Description = "Koruk ve rezene." },
        new() { Sequence = 10, Moment = "Toprak", Name = "Kuzu Sırtı", Description = "Firik ve fermente biber." },
        new() { Sequence = 11, Moment = "Geçiş", Name = "Koruk Granita", Description = "Yeşil erik ve taze nane." },
        new() { Sequence = 12, Moment = "Süt", Name = "Yoğurt", Description = "Bal, polen ve zeytinyağı." },
        new() { Sequence = 13, Moment = "Tatlı", Name = "Antep Fıstığı", Description = "Baklava yaprağı ve süt." },
        new() { Sequence = 14, Moment = "Tatlı", Name = "Ayva & Ihlamur", Description = "Ceviz ve ıhlamur kreması." },
        new() { Sequence = 15, Moment = "Minyon", Name = "Kakao Bonbon", Description = "Keçiboynuzu karameli." },
        new() { Sequence = 16, Moment = "Kapanış", Name = "Türk Kahvesi Lokumu", Description = "Damla sakızı ve fındık." }
    };

    public IActionResult Index(string? category)
    {
        var items = string.IsNullOrWhiteSpace(category)
            ? MenuItems
            : MenuItems.Where(item => item.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();

        ViewData["SelectedCategory"] = category;
        ViewData["Categories"] = MenuItems.Select(item => item.Category).Distinct().ToList();
        ViewData["TastingMenu"] = TastingMenu;
        return View(items);
    }

    public IActionResult Details(int id)
    {
        var item = MenuItems.FirstOrDefault(menuItem => menuItem.Id == id);
        return item is null ? NotFound() : View(item);
    }
}
