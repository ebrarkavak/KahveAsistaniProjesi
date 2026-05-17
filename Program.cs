using System;
using System.Collections.Generic;

namespace KahveAsistani
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kahve> menu = new List<Kahve>();

            // --- 1. Espresso Tabanlı Kahveler ---
            menu.Add(new EspressoTabanli { 
                Ad = "Latte", 
                Icindekiler = "1 Shot Espresso, Buharlanmış Süt, İnce Süt Köpüğü", 
                ShotSayisi = 1, 
                DemlemeSuresiSaniye = 35, 
                Fiyat = 150
            });

            menu.Add(new EspressoTabanli { 
                Ad = "Americano", 
                Icindekiler = "1 Shot Espresso, Sıcak Su", 
                ShotSayisi = 1, 
                DemlemeSuresiSaniye = 25, 
                Fiyat = 145 
            });

            menu.Add(new EspressoTabanli { 
                Ad = "Cappuccino", 
                Icindekiler = "1 Shot Espresso, Eşit Miktarda Süt ve Yoğun Köpük", 
                ShotSayisi = 1, 
                DemlemeSuresiSaniye = 40, 
                Fiyat = 150
            });
            menu.Add(new EspressoTabanli { 
                Ad = "Iced Caramel Macchiato", 
                Icindekiler = "Vanilya Şurubu, Soğuk Süt, Buz, 1 Shot Espresso ve Karamel Sos", 
                ShotSayisi = 1, 
                DemlemeSuresiSaniye = 50, // Katmanlı yapıldığı için biraz daha uzun sürüyor
                Fiyat = 160
            });

            // --- 2. Filtre ve Demleme Kahveler ---
            menu.Add(new FiltreKahve { 
                Ad = "Filtre Kahve", 
                Icindekiler = "Öğütülmüş Kahve Çekirdeği, Sıcak Su", 
                FiltreTipi = "Kağıt veya Metal Filtre", 
                DemlemeSuresiSaniye = 180, // 3 dakika
                Fiyat = 140 
            });

            menu.Add(new FiltreKahve { 
                Ad = "Türk Kahvesi", 
                Icindekiler = "Çok İnce Öğütülmüş Kahve, Su", 
                FiltreTipi = "Cezvede Telvesiyle Pişirme", 
                DemlemeSuresiSaniye = 150, 
                Fiyat = 70 
            });

            menu.Add(new FiltreKahve { 
                Ad = "Buzlu Filtre Kahve", 
                Icindekiler = "Demlenmiş Filtre Kahve, Bol Buz", 
                FiltreTipi = "Buz Üzerine Süzme", 
                DemlemeSuresiSaniye = 210, // Soğuma süresi dahil
                Fiyat = 155 
            }); 


            // --- Kullanıcı Arayüzü ---
            Console.WriteLine("☕ KAHVEASİSTANİ KAHVE REHBERİNE HOŞ GELDİNİZ ☕");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Reçetesini görmek istediğiniz kahveyi seçin:");
            
    
            for (int i = 0; i < menu.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {menu[i].Ad}");
            }

            try {
                Console.Write("\nSeçiminiz (1-7): ");
                string girdi = Console.ReadLine();
                int secim = int.Parse(girdi) - 1;

                if (secim >= 0 && secim < menu.Count)
                {
                    menu[secim].ReceteGoster();
                  
KahveYonetici yonetici = new KahveYonetici();
yonetici.IslemiKaydet(menu[secim]);
                }
                else
                {
                    Console.WriteLine("Lütfen listedeki sayılardan birini seçin.");
                }
            }
            catch (Exception) {
                
                Console.WriteLine("\n[Hata]: Lütfen geçerli bir sayı giriniz!");
            }

            Console.WriteLine("\nProgramdan çıkmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}