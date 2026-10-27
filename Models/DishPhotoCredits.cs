namespace RestaurantReservationSystem.Models;

// Menü fotoğrafları Wikimedia Commons'tan alınmıştır; lisansları (CC) fotoğrafçının adının belirtilmesini ister.
public record PhotoCredit(string Artist, string License, string SourceUrl);

public static class DishPhotoCredits
{
    private static readonly IReadOnlyDictionary<int, PhotoCredit> Credits = new Dictionary<int, PhotoCredit>
    {
        [1] = new("Ji-Elle", "CC BY-SA 4.0", "https://commons.wikimedia.org/wiki/File:Baba_ganoush-Jordanie.jpg"),
        [2] = new("Ceeseven", "CC BY-SA 4.0", "https://commons.wikimedia.org/wiki/File:Seafood_Risotto.jpg"),
        [3] = new("Aw58", "CC BY-SA 4.0", "https://commons.wikimedia.org/wiki/File:%C5%BBeberka_w_sosie_w%C5%82asnym_z_ziemniakami_-_2024.05.01.jpg"),
        [4] = new("Andy Li", "CC0", "https://commons.wikimedia.org/wiki/File:Goat%27s_Cheese_Salad_-_The_Oven_2025-07-24.jpg"),
        [5] = new("stu_spivack", "CC BY-SA 2.0", "https://commons.wikimedia.org/wiki/File:Lemon_cheesecake_special_with_raspberries.jpg"),
        [6] = new("dana robinson", "CC BY-SA 2.0", "https://commons.wikimedia.org/wiki/File:Basil_lemonade_(3609257528).jpg"),
        [7] = new("Wheeler Cowperthwaite", "CC BY 2.0", "https://commons.wikimedia.org/wiki/File:11-28-2024_Beef_Wellington_-_011.jpg"),
        [8] = new("Jeremy Keith", "CC BY 2.0", "https://commons.wikimedia.org/wiki/File:Miso_cod_(5441609643).jpg"),
        [9] = new("irene.", "CC BY-SA 2.0", "https://commons.wikimedia.org/wiki/File:Meat_Fruit_at_Dinner_by_Heston.jpg"),
        [10] = new("Sarah_Ackerman", "CC BY 2.0", "https://commons.wikimedia.org/wiki/File:Oysters_and_Pearls_(13042048545).jpg"),
        [11] = new("Prayitno", "CC BY 2.0", "https://commons.wikimedia.org/wiki/File:Lemon_tart_dusted_with_powdered_sugar_at_a_restaurant.jpg"),
        [12] = new("Ewan Munro", "CC BY-SA 2.0", "https://commons.wikimedia.org/wiki/File:Viajante,_Bethnal_Green,_London_(5569173236).jpg"),
        [13] = new("Charles Haynes", "CC BY-SA 2.0", "https://commons.wikimedia.org/wiki/File:Seared_scallops_Bengaluru,_Karnataka,_India.jpg"),
        [14] = new("Continentaleurope", "CC BY-SA 4.0", "https://commons.wikimedia.org/wiki/File:Stuffed_artichokes.jpg"),
        [15] = new("Garrett Ziegler", "CC BY-SA 4.0", "https://commons.wikimedia.org/wiki/File:%C4%B0%C3%A7li_k%C3%B6fte_(Oruk).jpg"),
        [16] = new("Benreis", "CC BY-SA 4.0", "https://commons.wikimedia.org/wiki/File:Rote-Bete-Carpaccio_Berlin.jpg"),
        [17] = new("Bonnachoven", "CC0", "https://commons.wikimedia.org/wiki/File:Longhorn_Lamb_Chops_.jpg"),
        [18] = new("Kolforn", "CC BY-SA 4.0", "https://commons.wikimedia.org/wiki/File:-2021-12-19_Fillet_of_sea_bass,_saut%C3%A9ed_new_potatoes,_braised_fennel,_broccoli,_white_wine_and_dill_cream_sauce,_Trimingham,_Norfolk_(2).jpg"),
        [19] = new("Kolforn", "CC BY-SA 4.0", "https://commons.wikimedia.org/wiki/File:-2022-03-08_Pan-Roasted_Duck_Breast,_fondant_potato,_wilted_greens,_cherry_sauce,_Trimingham,_Norfolk.JPG"),
        [20] = new("Nérostrateur", "CC BY 2.5", "https://commons.wikimedia.org/wiki/File:Mant%C4%B1.jpg"),
        [21] = new("HaJunkiyada", "CC BY-SA 4.0", "https://commons.wikimedia.org/wiki/File:Liat_Portal_for_Foodie_Disorder_%E2%80%93_Whole_roasted_cauliflower.jpg"),
        [22] = new("Ralph Daily", "CC BY 2.0", "https://commons.wikimedia.org/wiki/File:Shaved_Fennel_Salad_(6635670959).jpg"),
        [23] = new("Gerda Arendt", "CC0", "https://commons.wikimedia.org/wiki/File:Tomato_salad_with_burrata,_Limburg.jpg"),
        [24] = new("Kutlusafa", "CC BY 4.0", "https://commons.wikimedia.org/wiki/File:%C5%9E%C4%B1ll%C4%B1k_dessert_served_at_Hac%C4%B1baba_in_%C5%9Eanl%C4%B1urfa,_full_plate_view.jpg"),
        [25] = new("Gerda Arendt", "CC BY-SA 4.0", "https://commons.wikimedia.org/wiki/File:Chocolate_dessert,_Hetschbach.jpg"),
        [26] = new("E4024", "CC BY-SA 4.0", "https://commons.wikimedia.org/wiki/File:Quince_dessert_(ayva_tatl%C4%B1s%C4%B1).jpg"),
        [27] = new("Famartin", "CC BY-SA 4.0", "https://commons.wikimedia.org/wiki/File:2024-12-16_15_09_43_A_glass_of_strawberry_lemonade_at_the_Applebee%27s_along_U.S._Route_1_(Brunswick_Pike)_in_Lawrence_Township,_Mercer_County,_New_Jersey.jpg"),
        [28] = new("Hellstorm", "CC BY-SA 3.0", "https://commons.wikimedia.org/wiki/File:Jasmine_Tea_blossomed.jpg"),
        [29] = new("Memorino", "CC BY-SA 3.0 de", "https://commons.wikimedia.org/wiki/File:Apple_juice_with_2apples.jpg"),
    };

    public static PhotoCredit? For(int menuItemId) => Credits.GetValueOrDefault(menuItemId);
}
