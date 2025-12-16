# WriteTheRestWeb

Hikâye ve bölümlerin yönetimi için geliştirilmiş **ASP.NET Core Razor Pages** tabanlı bir frontend uygulamasıdır.  
Tüm veri işlemleri, ayrı bir **.NET Web API** projesi üzerinden gerçekleştirilir.

---

## Proje Hakkında

**WriteTheRestWeb**, hikâyeleri ve bu hikâyelere ait bölümleri yönetmeye yönelik bir kullanıcı arayüzü sunar.  
Uygulama, iş mantığını ve veri erişimini içermeyen, yalnızca API ile haberleşen bir frontend yapısına sahiptir.

---

## Proje Yapısı

WriteTheRestWeb
│
├─ Frontend (ASP.NET Core Razor Pages)
│ └─ API Entegrasyonu (HttpClient)
│
WriteTheRestApi
└─ Backend (.NET Web API)

yaml
Kodu kopyala

- **WriteTheRestWeb**  
  Razor Pages kullanılarak geliştirilmiş kullanıcı arayüzü projesi.

- **WriteTheRestApi**  
  Veri işlemleri ve iş kurallarını yöneten backend API projesi.

---

## Özellikler

- Hikâye ekleme, listeleme, düzenleme ve silme
- Hikâyelere bağlı bölümlerin yönetimi
- Tüm CRUD işlemlerinin API üzerinden yapılması
- Temiz ve sade Razor Pages mimarisi
- HttpClient ile API entegrasyonu

---

## Gereksinimler

- .NET 8 SDK
- Visual Studio 2022 veya üzeri
- Çalışır durumda bir WriteTheRestApi projesi

---

## Kurulum ve Çalıştırma

### 1. API Projesini Çalıştırma

1. WriteTheRestApi projesini açın
2. Projeyi çalıştırın
3. Varsayılan adres:

https://localhost:7081/

yaml
Kodu kopyala

**API Endpoint’leri**
- `api/stories` – Hikâye işlemleri
- `api/chapters` – Bölüm işlemleri

---

### 2. Frontend Projesini Çalıştırma

1. Bu repository’yi klonlayın
2. Gerekli NuGet paketlerini geri yükleyin
3. API adresini kontrol edin:

```json
{
  "ApiBaseUrl": "https://localhost:7081/"
}
Projeyi başlatın

3. Entegrasyon
API ve frontend projeleri aynı anda çalışmalıdır

StoriesApiService ve ChapterApiService sınıfları API çağrılarını yapar

Yapılan tüm işlemler API tarafına anında yansır

Kullanım
Ana sayfadan hikâye ekleyebilir ve mevcut hikâyeleri yönetebilirsiniz

Her hikâye için bölüm ekleme ve düzenleme işlemleri yapılabilir

Tüm işlemler API üzerinden gerçekleştirilir

Örnek API İstekleri
Hikâye Ekleme
h
Kodu kopyala
POST /api/stories/add
json
Kodu kopyala
{
  "title": "Yeni Hikâye",
  "theme": "Macera",
  "description": "Kısa açıklama"
}
Bölümleri Listeleme
http
Kodu kopyala
GET /api/chapters?storyId=1
Notlar
API adresi ortama göre değiştirilebilir

Proje geliştirme ve öğrenme amaçlıdır

Katkılar açıktır
