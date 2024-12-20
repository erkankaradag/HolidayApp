# HolidayApp
# Tatil Fiyat Hesaplama Programı

Bu proje, C# kullanılarak yazılmış bir tatil fiyat hesaplama uygulamasıdır. Kullanıcı, tatil lokasyonunu, kişi sayısını ve ulaşım türünü seçerek toplam tatil maliyetini öğrenebilir. Program, kullanıcı dostu bir arayüz sunar ve hatalı girişlere karşı gerekli kontrolleri yapar.

## Özellikler

- Kullanıcıdan tatil lokasyonu seçimi yapılır.
- Tatil için kişi sayısı belirtilir.
- Ulaşım türü (hava yolu veya kara yolu) seçilir.
- Lokasyon ve ulaşım türüne göre toplam fiyat hesaplanır.
- Kullanıcıya sonuçlar gösterilir ve tekrar hesaplama yapmak isteyip istemediği sorulur.

## Kullanılan Teknolojiler

- **C#**: Ana programlama dili.
- **.NET**: Giriş/çıkış işlemleri ve temel sınıf kütüphaneleri için.

## Nasıl Çalışır?

1. Program çalıştırıldığında kullanıcıdan tatil lokasyonu istenir.
2. Kullanıcı kişi sayısını girer.
3. Kullanıcı ulaşım türünü (hava veya kara) seçer.
4. Program, lokasyon ve ulaşım türüne göre fiyatı hesaplar.
5. Toplam tatil fiyatı kullanıcıya gösterilir.
6. Kullanıcıdan yeni bir hesaplama yapmak isteyip istemediği sorulur.
7. Eğer kullanıcı "evet" yanıtı verirse program tekrar çalışır; aksi takdirde sonlandırılır.

## Örnek Kullanım

Aşağıda, programın bir örnek kullanımı gösterilmektedir:

```
Tatil lokasyonunu giriniz (örnek: Bodrum, Marmaris, Çeşme): Bodrum
Kaç kişilik tatil planlıyorsunuz?: 2
Ulaşım türünü seçiniz (hava/karayolu): hava
Tatil Lokasyonu: bodrum
Kişi Sayısı: 2
Ulaşım Türü: hava
Toplam Tatil Fiyatı: 12000 TL
Başka bir tatil hesaplamak ister misiniz? (evet/hayır): hayır
Programdan çıkılıyor. İyi tatiller!
```

## Lokasyon ve Fiyatlar

| Lokasyon  | Lokasyon Fiyatı (TL) |
|-----------|-----------------------|
| Bodrum    | 4000                 |
| Marmaris  | 3000                 |
| Çeşme     | 5000                 |

| Ulaşım Türü | Kişi Başı Fiyat (TL) |
|-------------|----------------------|
| Hava Yolu   | 4000                |
| Kara Yolu   | 1500                |

## Geliştirme ve Katkı

Projeyi geliştirmek veya katkıda bulunmak istiyorsanız, aşağıdaki adımları takip edebilirsiniz:

1. Bu projeyi fork edin.
2. Kendi bilgisayarınıza klonlayın.
3. Değişikliklerinizi yapın.
4. Pull request gönderin.

## Lisans

Bu proje MIT lisansı ile lisanslanmıştır. Daha fazla bilgi için `LICENSE` dosyasını kontrol edebilirsiniz.

## İletişim

Herhangi bir sorunuz ya da öneriniz varsa, [iletişim adresinizi buraya ekleyebilirsiniz].

