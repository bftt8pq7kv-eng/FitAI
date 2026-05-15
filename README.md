<img width="1434" height="451" alt="image" src="https://github.com/user-attachments/assets/845c51ee-ed11-4c18-972c-5d8c012a9ffe" /># 👗 FitAI — AI Powered Smart Outfit Assistant

FitAI is an AI-powered fashion recommendation web application developed with ASP.NET Core and OpenAI integration.

The application analyzes:
- weather conditions
- user style
- preferred colors
- activity type
- gender preferences

and generates personalized outfit combinations instantly.

---

# ✨ Project Purpose

Choosing clothes every day can be difficult depending on:
- weather
- social environment
- comfort
- color harmony
- activity type

FitAI simplifies this process using artificial intelligence and creates smart outfit suggestions for users.

---

# 🚀 Features

## 🌦️ Weather Based Recommendations
The system generates combinations according to:
- temperature
- seasonal conditions
- daily weather

---

## 🤖 AI Supported Styling
OpenAI integration creates:
- upper clothing suggestions
- lower clothing suggestions
- shoes
- accessories
- style explanations

---

## 🎨 Personalized Experience
Users can customize:
- favorite colors
- clothing style
- activity type
- outfit mood

---

## 📱 Modern UI
- responsive design
- gradient modern interface
- mobile compatible layout
- animated loading states

---

# 🛠️ Technologies Used

| Technology | Purpose |
|---|---|
| ASP.NET Core | Backend API |
| HTML | Frontend structure |
| CSS | UI styling |
| JavaScript | Dynamic frontend |
| OpenAI API | AI recommendation engine |
| REST API | Backend communication |
| GitHub | Version control |

---
# 📂 Proje Mimarisi

```text
FitAI/
│
├── Controllers/        → API endpointleri
├── Services/           → Yapay zeka ve hava durumu servisleri
├── Models/             → Veri modelleri
├── Data/               → Entity Framework DbContext
├── Migrations/         → SQLite migration dosyaları
├── wwwroot/            → Frontend dosyaları
└── Program.cs          → Uygulama başlangıç yapılandırması
```

---

# 🧠 Yazılım Mimarisi ve Teknik Yaklaşım

Proje katmanlı mimari yaklaşımıyla geliştirilmiştir.

Uygulama içerisinde:

- Controller katmanı → HTTP isteklerini yönetir
- Service katmanı → iş mantığını içerir
- Model katmanı → veri yapılarını temsil eder
- Data katmanı → veritabanı işlemlerini yönetir

Bu yapı sayesinde:

- okunabilirlik
- sürdürülebilirlik
- test edilebilirlik
- modülerlik

arttırılmıştır.

Projede SOLID prensiplerine uygun servis ayrımı uygulanmıştır.

---

# 🗄️ Veritabanı Yapısı

Projede SQLite veritabanı kullanılmıştır.

Entity Framework Core kullanılarak:

- migration yönetimi
- tablo oluşturma
- veri kayıt işlemleri

gerçekleştirilmiştir.

Saklanan temel veriler:

- şehir bilgisi
- kullanıcı tercihleri
- stil türü
- aktivite bilgisi
- oluşturulan kombin önerisi
- oluşturulma tarihi

---

# 🔍 API Test Süreci

API endpointleri Swagger UI üzerinden test edilmiştir.

Swagger üzerinden:

- request gönderme
- response doğrulama
- JSON veri kontrolü
- endpoint doğrulama

işlemleri gerçekleştirilmiştir.

Swagger erişimi:

```bash
https://localhost:7140/swagger
```





