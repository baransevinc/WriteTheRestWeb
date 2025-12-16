✍️ WriteTheRestWeb

Hikâye ve bölüm yönetimi için geliştirilmiş modern bir ASP.NET Core Razor Pages frontend uygulaması.

🚀 Proje Hakkında

WriteTheRestWeb, hikâyelerin ve bu hikâyelere ait bölümlerin yönetilmesini sağlayan bir kullanıcı arayüzü uygulamasıdır.
Uygulama, tüm veri işlemleri ve iş mantığı için ayrı bir .NET Web API projesi ile entegre çalışır.

🔗 CRUD işlemlerinin tamamı API üzerinden gerçekleştirilir.

🧩 Proje Yapısı
WriteTheRestWeb/
├── Frontend (Razor Pages)
└── API Entegrasyonu (HttpClient)


WriteTheRestApi/
└── Backend (.NET Web API)

WriteTheRestWeb
Kullanıcı arayüzünü barındıran Razor Pages tabanlı frontend projesi.

WriteTheRestApi
Veri erişimi, iş kuralları ve API uç noktalarını yöneten backend projesi.

✨ Özellikler

📖 Hikâye ekleme, listeleme, güncelleme ve silme

📝 Hikâyelere bağlı bölümlerin yönetimi

🔄 API tabanlı tüm CRUD işlemleri

🧱 Temiz ve ölçeklenebilir Razor Pages mimarisi

🌐 HttpClient ile API haberleşmesi

🛠️ Gereksinimler

.NET 8 SDK

Visual Studio 2022 veya üzeri

Çalışır durumda bir WriteTheRestApi projesi

⚙️ Kurulum & Çalıştırma
1️⃣ API Projesini Çalıştırın

WriteTheRestApi projesini açın

Projeyi çalıştırın

Varsayılan adres:

https://localhost:7081/

Kullanılan API Endpoint'leri:

api/stories → Hikâye işlemleri

api/chapters → Bölüm işlemleri

2️⃣ Frontend Projesini Çalıştırın

Bu repository’yi klonlayın

NuGet paketlerini geri yükleyin

API adresini kontrol edin:

// appsettings.json veya Program.cs
"ApiBaseUrl": "https://localhost:7081/"

Projeyi başlatın

3️⃣ Entegrasyon

Frontend ve API projeleri eş zamanlı çalışmalıdır

StoriesApiService ve ChapterApiService sınıfları API isteklerini yönetir

Kullanıcı aksiyonları anlık olarak API tarafına yansıtılır

🧪 Kullanım

🏠 Ana sayfadan hikâye ekleyebilir ve mevcut hikâyeleri yönetebilirsiniz

➕ Her hikâye için Bölüm Ekle seçeneğiyle bölümleri düzenleyebilirsiniz

🔄 Yapılan tüm işlemler API üzerinden kaydedilir

📌 Örnek API İstekleri
➕ Hikâye Ekleme
POST /api/stories/add
{
  "title": "Yeni Hikâye",
  "theme": "Macera",
  "description": "Kısa açıklama"
}
📄 Bölümleri Listeleme
GET /api/chapters?storyId=1
📎 Notlar

API adresi ortama göre değiştirilebilir

Proje eğitim ve geliştirme amaçlı tasarlanmıştır

Katkılar ve geliştirmeler açıktır
