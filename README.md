# AHENK - Restoran Rezervasyon Sistemi

Üniversitenin ilk gününden beri yakın arkadaş olan Beyza, Nisa ve Semanur'un dostluğunu simgeleyen ASP.NET Core MVC restoran rezervasyon ve menü yönetim projesi.

## Proje ekibi

- Beyza
- Nisa
- Semanur

## İlk hafta gereksinimleri

- [x] En az 3 Controller
- [x] Her Controller için en az 2 View
- [x] Toplam 7 View
- [x] Responsive özel CSS tasarımı
- [x] Razor ile dinamik menü kartları ve rezervasyon tablosu
- [x] Model doğrulamalı rezervasyon formu

## MVC yapısı

| Controller | View'lar |
|---|---|
| `HomeController` | `Index`, `About` |
| `MenuController` | `Index`, `Details` |
| `ReservationsController` | `Index`, `Create`, `Success` |

## Çalıştırma

Bilgisayarda .NET 8 SDK kurulu olmalıdır.

```bash
dotnet restore
dotnet run
```

Ardından terminalde gösterilen localhost adresini tarayıcıda açın.

## İlk hafta özellikleri

- Responsive navigasyon ve mobil menü
- Gerçek lüks restoran sitelerinden ilham alan, fotoğraf odaklı editoryal arayüz
- Projeye özel üretilmiş yerel kahraman ve tabak görselleri
- Ana sayfa, proje hakkında sayfası ve dönem yol haritası
- Controller'dan gelen örnek verilerle dinamik Razor menüsü
- Kategoriye göre menü filtreleme
- Menü detay sayfası
- Dinamik rezervasyon listesi
- Doğrulamalı rezervasyon oluşturma formu
- Başarı sayfası

## Sonraki haftalar için plan

1. Entity Framework Core ve SQL Server bağlantısı
2. Menü, kategori, masa ve rezervasyon CRUD işlemleri
3. Tarih-saat bazlı masa uygunluk kontrolü
4. Kullanıcı kaydı, giriş ve rol yönetimi
5. Yönetici paneli
6. Arama, filtreleme ve raporlama
