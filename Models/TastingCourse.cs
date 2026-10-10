namespace RestaurantReservationSystem.Models;

public class TastingCourse
{
    public int Sequence { get; set; }
    public string Moment { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
