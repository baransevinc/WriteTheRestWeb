WriteTheRestWeb

WriteTheRestWeb, hikaye ve bölüm yönetimi için geliştirilmiş bir ASP.NET Core Razor Pages frontend uygulamasıdır. Proje, ayrı bir .NET API projesi ile entegre çalışır. Tüm veri işlemleri (CRUD) API üzerinden gerçekleştirilir.
Proje Yapısı
•	WriteTheRestWeb: Bu repository’deki frontend (kullanıcı arayüzü) projesidir.
•	WriteTheRestApi: Ayrı bir repository veya klasörde bulunan, veri işlemlerini ve iş mantığını yöneten .NET API projesidir.

Özellikler
•	Hikaye ekleme, listeleme, düzenleme ve silme
•	Her hikayeye ait bölümleri ekleme, listeleme, düzenleme ve silme
•	Tüm işlemler API üzerinden yapılır
•	Modern Razor Pages mimarisi
•	HttpClient ile API entegrasyonu

Gereksinimler
•	.NET 8 SDK
•	Visual Studio 2022 veya üzeri
•	API projesi (WriteTheRest) ile birlikte çalışır

Adımlar
1.	API Projesini Çalıştırın
•	API projesini açın ve çalıştırın.
•	Varsayılan olarak https://localhost:7081/ adresinde çalışır.
•	API endpoint’leri:
•	api/stories (hikaye işlemleri)
•	api/chapters (bölüm işlemleri)
2.	Frontend Projesini Çalıştırın
•	Bu repository’yi klonlayın.
•	Gerekli NuGet paketlerini yükleyin.
•	appsettings.json veya Program.cs dosyasında API adresinin doğru olduğundan emin olun (https://localhost:7081/).
•	Projeyi başlatın.

3.	Entegrasyon
•	API ve frontend projeleri aynı anda çalıştırılmalıdır.
•	Servisler (StoriesApiService, ChapterApiService) API endpoint’lerine istek atar.

Kullanım
•	Ana sayfada hikaye ekleyebilir, mevcut hikayeleri görebilir ve düzenleyebilirsiniz.
•	Her hikaye için “Bölüm Ekle” butonuna tıklayarak ilgili bölümleri yönetebilirsiniz.
•	Tüm işlemler anında API’ya yansır.

Örnek API İstekleri
POST /api/stories/add
{
  "title": "Yeni Hikaye",
  "theme": "Macera",
  "description": "Kısa açıklama"
}

GET /api/chapters?storyId=1


