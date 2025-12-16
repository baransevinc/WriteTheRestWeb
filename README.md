WriteTheRestWeb

WriteTheRestWeb, hikâye ve bölümlerin yönetimini sağlayan, ASP.NET Core Razor Pages ile geliştirilmiş bir frontend uygulamasıdır.
Uygulama, iş mantığı ve veri işlemleri için ayrı bir .NET Web API projesiyle haberleşir. Tüm ekleme, güncelleme, silme ve listeleme işlemleri API üzerinden yapılır.

Proje Yapısı

WriteTheRestWeb
Kullanıcı arayüzünü içeren Razor Pages tabanlı frontend projesi.

WriteTheRestApi
Ayrı bir repository veya klasör altında yer alan, veri erişimi ve iş kurallarını yöneten .NET API projesi.

Özellikler

Hikâye oluşturma, görüntüleme, güncelleme ve silme

Hikâyelere bağlı bölümlerin yönetimi (ekleme, listeleme, düzenleme, silme)

Tüm CRUD işlemlerinin API üzerinden gerçekleştirilmesi

Temiz ve modern Razor Pages mimarisi

HttpClient kullanılarak API ile haberleşme

Gereksinimler

.NET 8 SDK

Visual Studio 2022 veya daha yeni bir sürüm

Çalışır durumda bir WriteTheRestApi projesi

Kurulum ve Çalıştırma
1️⃣ API Projesini Başlatma

WriteTheRestApi projesini açın.

Projeyi çalıştırın.

Varsayılan adres:
https://localhost:7081/

Kullanılan API uç noktaları:

api/stories → Hikâye işlemleri

api/chapters → Bölüm işlemleri

2️⃣ Frontend Projesini Başlatma

Bu repository’yi bilgisayarınıza klonlayın.

Gerekli NuGet paketlerini geri yükleyin.

appsettings.json veya Program.cs içinde API adresinin doğru tanımlandığından emin olun:

https://localhost:7081/


Projeyi çalıştırın.

3️⃣ API – Frontend Entegrasyonu

API ve frontend projeleri aynı anda çalışıyor olmalıdır.

StoriesApiService ve ChapterApiService sınıfları, API endpoint’lerine istek gönderir.

Tüm kullanıcı işlemleri API üzerinden işlenir.

Kullanım

Ana sayfa üzerinden yeni hikâyeler ekleyebilir ve mevcut hikâyeleri görüntüleyebilirsiniz.

Her hikâye için Bölüm Ekle seçeneğiyle ilgili bölümleri yönetebilirsiniz.

Yapılan tüm değişiklikler anlık olarak API tarafına yansır.

Örnek API İstekleri
Hikâye Ekleme
POST /api/stories/add

{
  "title": "Yeni Hikâye",
  "theme": "Macera",
  "description": "Kısa açıklama"
}

Hikâyeye Ait Bölümleri Getirme
GET /api/chapters?storyId=1
