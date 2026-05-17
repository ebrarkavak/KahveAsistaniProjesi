using System;

namespace KahveAsistani
{
    public class FiltreKahve : Kahve
    {
        public string FiltreTipi { get; set; }
        public override void ReceteGoster()
        {
            Console.WriteLine($"\n--- {Ad} REÇETESİ (Demleme) ---");
            Console.WriteLine($"İçindekiler: {Icindekiler}");
            Console.WriteLine($"Filtreleme Yöntemi: {FiltreTipi}");
            Console.WriteLine($"Demleme Süresi: {DemlemeSuresiSaniye} saniye");
            Console.WriteLine($"Fiyat: {Fiyat} TL");
        }
    }
}