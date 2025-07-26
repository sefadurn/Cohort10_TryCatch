/*
Bu pratikte basit bir try-catch uygulaması yapalım.

 Kullanıcıdan bir sayı girmesini isteyen bir program yazın. Kullanıcı geçerli bir sayı girdiğinde bu sayının karesini ekrana yazdırınız.

Kullanıcı geçersiz bir giriş yaparsa (sayı yerine harf veya sembol girmesi gibi), "Geçersiz giriş! Lütfen bir sayı giriniz." şeklinde bir hata mesajı gösteriniz.
*/
bool sayiDogruMu = false; 

while(!sayiDogruMu)
{
    try
    {
        Console.WriteLine("Lütfen bir sayi giriniz : ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        int kare = sayi * sayi;

        Console.WriteLine($"Girilen sayinin karesi : {kare}");

        sayiDogruMu = true; // doğru girildiyse döngüyü bitir
    }
    catch (FormatException)     // Kullanıcı harf, kelime, sembol gibi sayı olmayan bir şey yazarsa çalışır.
    {
        Console.WriteLine("Hatali giriş! Lütfen geçerli bir tam sayi giriniz.");
    }
    catch (OverflowException)       // Kullanıcı çok büyük ya da çok küçük bir sayı girerse çalışır.
    {
        Console.WriteLine("İnt değer aralığı arasında bir tam sayi giriniz, girdiğiniz değer çok büyük veya çok küçük!");
    }
}


