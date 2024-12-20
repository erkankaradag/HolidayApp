using System;

class TatilFiyatHesaplama
{
    static void Main(string[] args)
    {
        bool devamEt = true;

        while (devamEt)
        {
            // Kullanıcıdan girişleri alalım
            Console.WriteLine("Tatil lokasyonunu giriniz (örnek: Bodrum, Marmaris, Çeşme):");
            string? lokasyon = Console.ReadLine()?.ToLower();

            if (string.IsNullOrEmpty(lokasyon))
            {
                Console.WriteLine("Geçersiz giriş. Lütfen bir lokasyon giriniz.");
                continue;
            }

            Console.WriteLine("Kaç kişilik tatil planlıyorsunuz?");
            int kisiSayisi;
            while (!int.TryParse(Console.ReadLine(), out kisiSayisi) || kisiSayisi <= 0)
            {
                Console.WriteLine("Lütfen geçerli bir kişi sayısı giriniz.");
            }

            Console.WriteLine("Ulaşım türünü seçiniz (hava/karayolu):");
            string? ulasimTuru = Console.ReadLine()?.ToLower();

            if (string.IsNullOrEmpty(ulasimTuru))
            {
                Console.WriteLine("Geçersiz giriş. Lütfen geçerli bir ulaşım türü giriniz (hava/karayolu).");
                continue;
            }

            // Lokasyon ve ulaşım türüne göre temel fiyatları belirleyelim
            int lokasyonFiyati = 0;
            int ulasimFiyati = 0;

            switch (lokasyon)
            {
                case "bodrum":
                    Console.WriteLine("Bodrum'u seçtiniz. Harika bir tatil planı olabilir!");
                    lokasyonFiyati = 4000;
                    break;
                case "marmaris":
                    Console.WriteLine("Marmaris'i seçtiniz. Harika bir tatil planı olabilir!");
                    lokasyonFiyati = 3000;
                    break;
                case "çeşme":
                    Console.WriteLine("Çeşme'nin güzel plajları ve denizi sizi bekliyor.");
                    lokasyonFiyati = 5000;
                    break;
                default:
                    Console.WriteLine("Belirtilen lokasyon için fiyat bilgisi bulunamadı.");
                    continue;
            }

            if (ulasimTuru == "hava")
            {
                ulasimFiyati = 4000; // Kişi başı hava yolu fiyatı
            }
            else if (ulasimTuru == "karayolu")
            {
                ulasimFiyati = 1500; // Kişi başı kara yolu fiyatı
            }
            else
            {
                Console.WriteLine("Geçerli bir ulaşım türü seçiniz (hava/karayolu).\n");
                continue;
            }

            // Toplam fiyatı hesaplayalım
            int toplamFiyat = lokasyonFiyati + (ulasimFiyati * kisiSayisi);

            // Sonuçları yazdıralım
            Console.WriteLine($"Tatil Lokasyonu: {lokasyon}");
            Console.WriteLine($"Kişi Sayısı: {kisiSayisi}");
            Console.WriteLine($"Ulaşım Türü: {ulasimTuru}");
            Console.WriteLine($"Toplam Tatil Fiyatı: {toplamFiyat} TL");

            // Kullanıcıya devam etmek isteyip istemediğini soralım
            Console.WriteLine("Başka bir tatil hesaplamak ister misiniz? (evet/hayır):");
            string? cevap = Console.ReadLine()?.ToLower();

            if (string.IsNullOrEmpty(cevap) || cevap != "evet")
            {
                devamEt = false;
                Console.WriteLine("Programdan çıkılıyor. İyi tatiller!");
            }
        }
    }
}
