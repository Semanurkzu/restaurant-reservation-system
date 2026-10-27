namespace RestaurantReservationSystem.Models;

public class MenuItem
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string AccentClass { get; set; } = "accent-terracotta";
    public bool IsChefSpecial { get; set; }
    public string? InspiredBy { get; set; }

    // Her yemeğin malzemelerine göre çizilmiş tabak görseli: wwwroot/images/dishes/{Id}.svg
    public string ImagePath => $"~/images/dishes/{Id}.svg";
}
