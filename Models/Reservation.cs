using System.ComponentModel.DataAnnotations;

namespace RestaurantReservationSystem.Models;

public class Reservation
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Ad soyad alanı zorunludur.")]
    [Display(Name = "Ad Soyad")]
    [StringLength(80, MinimumLength = 3, ErrorMessage = "Ad soyad 3-80 karakter arasında olmalıdır.")]
    public string CustomerName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Telefon alanı zorunludur.")]
    [Display(Name = "Telefon")]
    [Phone(ErrorMessage = "Geçerli bir telefon numarası giriniz.")]
    public string Phone { get; set; } = string.Empty;

    [Required(ErrorMessage = "Tarih ve saat seçiniz.")]
    [Display(Name = "Rezervasyon Tarihi")]
    public DateTime ReservationDate { get; set; }

    [Range(1, 12, ErrorMessage = "Kişi sayısı 1-12 arasında olmalıdır.")]
    [Display(Name = "Kişi Sayısı")]
    public int GuestCount { get; set; }

    [Display(Name = "Özel Not")]
    [StringLength(250, ErrorMessage = "Not en fazla 250 karakter olabilir.")]
    public string? Note { get; set; }

    public string Status { get; set; } = "Bekliyor";
}
