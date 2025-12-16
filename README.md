# WriteTheRestWeb

WriteTheRestWeb, hikâye ve bölümlerin yönetimini sağlayan bir ASP.NET Core Razor Pages frontend uygulamasıdır.  
Uygulama, veri işlemleri ve iş mantığı için ayrı bir .NET API projesi ile birlikte çalışır.  
Tüm ekleme, güncelleme, silme ve listeleme işlemleri API üzerinden yapılır.

# Proje Yapısı

- WriteTheRestWeb  
  Bu repository içinde yer alan kullanıcı arayüzü (frontend) projesidir.

- WriteTheRestApi  
  Ayrı bir repository veya klasörde bulunan, veri işlemlerini ve iş mantığını yöneten .NET API projesidir.

# Özellikler

- Hikâye ekleme, görüntüleme, düzenleme ve silme
- Hikâyelere ait bölümlerin eklenmesi ve yönetilmesi
- Tüm işlemlerin API üzerinden gerçekleştirilmesi
- Razor Pages tabanlı modern frontend mimarisi
- HttpClient kullanılarak API entegrasyonu

# Gereksinimler

- .NET 8 SDK
- Visual Studio 2022 veya üzeri
- WriteTheRestApi projesi ile birlikte çalışır

# Adımlar

# API Projesini Çalıştırma

API projesini açıp çalıştırın.  
Varsayılan olarak https://localhost:7081/ adresinde hizmet verir.

Kullanılan API endpoint’leri:
- api/stories (hikâye işlemleri)
- api/chapters (bölüm işlemleri)

# Frontend Projesini Çalıştırma

Bu repository’yi klonlayın.  
Gerekli NuGet paketlerini yükleyin.  
appsettings.json veya Program.cs dosyasında API adresinin doğru tanımlandığından emin olun.  
Projeyi başlatın.

# Entegrasyon

API ve frontend projeleri aynı anda çalıştırılmalıdır.  
StoriesApiService ve ChapterApiService sınıfları, ilgili API endpoint’lerine istek gönderir.

# Kullanım

Ana sayfa üzerinden yeni hikâyeler ekleyebilir ve mevcut hikâyeleri yönetebilirsiniz.  
Her hikâye için bölüm ekleme seçeneğiyle ilgili bölümler düzenlenebilir.  
Yapılan tüm işlemler anında API tarafına yansır.

# Örnek API İstekleri

Hikâye ekleme isteği:
```http
POST /api/stories/add
