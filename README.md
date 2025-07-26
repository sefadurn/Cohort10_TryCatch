# Cohort10_TryCatch

# Sayının Karesini Hesaplayan C# Uygulaması

Bu küçük C# konsol uygulaması, kullanıcıdan bir **tam sayı** girmesini ister ve bu sayının **karesini** hesaplayarak ekrana yazdırır.

## 🚀 Özellikler

- Kullanıcıdan sayı girişi istenir.
- Girilen değerin geçerli bir `int` (tam sayı) olup olmadığı kontrol edilir.
- Hatalı girişlerde kullanıcı bilgilendirilir ve tekrar giriş yapması istenir.
- Geçerli bir sayı girildiğinde, sayının karesi hesaplanarak ekrana yazdırılır.

## 📌 Kullanılan Yapılar

- `try-catch` blokları: Hatalı girişleri yakalamak ve programın çökmesini engellemek için.
- `while` döngüsü: Geçerli bir sayı girilene kadar kullanıcıdan tekrar giriş alabilmek için.
- `bool` kontrol değişkeni: Döngüyü kontrol etmek için.

## 🛠️ Hangi Hatalar Ele Alınıyor?

- `FormatException`: Harf, sembol veya geçersiz veri girildiğinde.
- `OverflowException`: Girilen sayı `int` veri türünün sınırlarını aştığında.
