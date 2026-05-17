using System;

namespace KahveAsistani
{
    public class EspressoTabanli : Kahve
    {
        public int ShotSayisi { get; set; }
        public override void ReceteGoster()
        {
            Console.WriteLine($"\n--- {Ad} REÇETESİ (Espresso Tabanlı) ---");
            Console.WriteLine($"İçindekiler: {Icindekiler}");
            Console.WriteLine($"Espresso Miktarı: {ShotSayisi} Shot");
            Console.WriteLine($"Hazırlanma Süresi: {DemlemeSuresiSaniye} saniye");
            Console.WriteLine($"Fiyat: {Fiyat} TL");
        }
    }
}