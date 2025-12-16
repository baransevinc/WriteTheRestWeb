# WriteTheRestWeb

WriteTheRestWeb, hikâyeler ve bu hikâyelere bağlı bölümlerin yönetimi için geliştirilmiş bir ASP.NET Core Razor Pages frontend uygulamasıdır.  
Uygulama yalnızca kullanıcı arayüzünü içerir ve tüm veri işlemleri ayrı bir .NET Web API projesi üzerinden yapılır.

# Genel Bilgi

Bu projede frontend ve backend birbirinden ayrıdır.  
Frontend tarafı yalnızca API ile iletişim kurar ve doğrudan veri işlemi yapmaz.  
API ile haberleşme HttpClient kullanılarak sağlanır.

# Proje Yapısı

- WriteTheRestWeb  
  Kullanıcı arayüzünü barındıran Razor Pages uygulaması.

- WriteTheRestApi  
  Hikâye ve bölüm verilerini yöneten .NET Web API projesi.

# Özellikler

- Hikâye ekleme, listeleme, düzenleme ve silme
- Hikâyelere ait bölümlerin eklenmesi ve yönetilmesi
- Tüm işlemlerin API üzerinden yapılması
- Basit ve anlaşılır Razor Pages yapısı
- HttpClient ile API entegrasyonu

# Gereksinimler

- .NET 8 SDK
- Visual Studio 2022 veya üzeri
- Çalışır durumda bir WriteTheRestApi projesi

# Çalıştırma Adımları

# API Projesi

API projesini açıp çalıştırın.  
Varsayılan olarak https://localhost:7081/ adresinde çalışır.

Kullanılan endpoint’ler:
- api/stories (hikâye işlemleri)
- api/chapters (bölüm işlemleri)

# Frontend Projesi

Bu repository’yi klonlayın.  
Gerekli NuGet paketlerini yükleyin.  
API adresinin doğru tanımlandığından emin olun.  
Projeyi çalıştırın.

# Kullanım

Uygulama üzerinden hikâyeler eklenebilir ve mevcut hikâyeler yönetilebilir.  
Her hikâye için bölümler oluşturulabilir ve düzenlenebilir.  
Yapılan tüm işlemler anında API tarafına yansır.

# Örnek API İstekleri

Hikâye ekleme:
```json
{
  "title": "Yeni Hikâye",
  "theme": "Macera",
  "description": "Kısa açıklama"
}
