<h1 align="center"> Travel Trip Project </h1>

<p align="center"> Modern gezginler ve içerik üreticileri için tasarlanmış, profesyonel, full-stack bir seyahat blogu ve destinasyon yönetim ekosistemi. </p>

<p align="center">
  <img alt="Build" src="https://img.shields.io/badge/Build-Passing-brightgreen?style=for-the-badge">
  <img alt="Framework" src="https://img.shields.io/badge/Framework-ASP.NET%20Core-512bd4?style=for-the-badge">
  <img alt="Database" src="https://img.shields.io/badge/Database-SQL%20Server-red?style=for-the-badge">
  <img alt="Architecture" src="https://img.shields.io/badge/Architecture-MVC-blue?style=for-the-badge">
</p>

---

## 🌟 Genel Bakış

### Giriş
**Travel Trip Project**, seyahat hikâyelerinin oluşturulma, paylaşılma ve yönetilme sürecini dönüştüren kapsamlı bir dijital platformdur. Güçlü bir bloglama ve yönetim arayüzü sayesinde seyahat tutkunları ile takipçileri arasında kusursuz bir köprü oluşturur.

### Problem
> Birçok seyahat blog yazarı ve turizm girişimcisi için dijital dünyaya giriş bariyeri oldukça yüksektir. Mevcut İçerik Yönetim Sistemleri (CMS) çoğu zaman gereğinden karmaşık, gereksiz özelliklerle dolu veya seyahat rotaları, destinasyon detayları ve yorum etkileşimlerini etkili biçimde sergilemek için yeterince özelleştirilmiş değildir. Blog yazıları, iletişim mesajları ve yönetim işlemleri gibi dinamik içerikleri yönetirken tutarlı bir tasarım sağlamak çoğunlukla birden fazla aracın birlikte kullanımını gerektirir ve bu da operasyonel zorluklar ve zayıf bir kullanıcı deneyimi oluşturur.

### Çözüm
**Travel Trip Project**, seyahat içerikleri için özel olarak optimize edilmiş MVC tabanlı bir mimari sunarak bu sorunları ortadan kaldırır. Yöneticilere; etkileyici blog yazıları hazırlamaktan destinasyon galerilerini yönetmeye, kullanıcı yorumlarını moderasyondan iletişim mesajlarına cevap vermeye kadar tüm süreçleri tek bir platform üzerinden yönetme imkânı sağlar. Yapısal veri modeli ve profesyonel arayüz sayesinde odak noktası teknik detaylar değil, seyahat deneyiminin kendisi olur.

### Mimari Genel Bakış
Sistem, sorumlulukların temiz bir şekilde ayrılmasını sağlayan **Model-View-Controller (MVC)** mimarisi kullanılarak geliştirilmiştir. Sunucu tarafında **ASP.NET**, veri yönetiminde **Entity Framework** (SQL tabanlı veritabanı ile) ve responsive bir ön yüz için **Bootstrap** ile **jQuery** kullanılmıştır. Bu yapı, uygulamanın ölçeklenebilir, sürdürülebilir ve hızlı olmasını sağlar.

---

## ✨ Temel Özellikler

### 👨‍💼 Profesyonel Yönetim Paneli
* **Merkezi Dashboard:** Güvenli ve özel bir yönetim paneli üzerinden sitenizi tamamen kontrol edin.
* **İçerik Yaşam Döngüsü Yönetimi:** Blog yazılarını ve destinasyon içeriklerini kod yazmadan kolayca ekleyin, düzenleyin ve silin.
* **Yorum Moderasyonu:** Kullanıcı yorumlarını yöneterek sağlıklı bir topluluk oluşturun.

### 📝 Zengin Blog Deneyimi
* **Detaylı Seyahat Yazıları:** Uzun açıklamalar ve anlatımlar içeren yapılandırılmış blog içerikleri paylaşın.
* **Etkileşimli Yapı:** Dahili yorum sistemi sayesinde okuyucular geri bildirim bırakabilir.
* **Kategorili İçerik:** Seyahatleri organize ederek kullanıcıların aradıkları destinasyonları kolayca bulmasını sağlayın.

### 🖼️ Etkileyici Görseller
* **Destinasyon Galerileri:** Uçuşlar, oteller ve gezilecek yerler için yüksek kaliteli görseller sergileyin.
* **Responsive Şablonlar:** `web`, `web2`, `weblogin` gibi farklı UI yapıları sayesinde masaüstü, tablet ve mobil cihazlarda uyumlu tasarım.

### 📬 Kesintisiz İletişim
* **Doğrudan İletişim:** Dahili iletişim sistemi sayesinde kullanıcılar site yöneticisine kolayca ulaşabilir.
* **Mesaj Yönetimi:** Gelen mesajlar yönetim panelinden görüntülenebilir ve yönetilebilir.

---

## 🛠️ Teknoloji Yığını & Mimari

**Travel Trip Project**, güvenilirlik ve performans için endüstri standardı teknolojiler kullanılarak geliştirilmiştir.

| Teknoloji | Amaç | Neden Seçildi |
| :--- | :--- | :--- |
| **ASP.NET MVC** | Backend Framework | Temiz mimari ve yapılandırılmış web uygulamaları geliştirmek için güçlü altyapı sağlar. |
| **C#** | Ana Programlama Dili | Tip güvenli, güçlü ve performanslı backend geliştirme. |
| **SQL Server** | Veritabanı Yönetimi | Kurumsal seviyede veri bütünlüğü ve ilişkisel veri desteği. |
| **Bootstrap** | Frontend UI | Mobil uyumlu ve responsive tasarım sağlar. |
| **jQuery** | İstemci Tarafı Script | DOM işlemlerini kolaylaştırır ve kullanıcı deneyimini artırır. |
| **Entity Framework** | Veri Erişimi | C# ile SQL veritabanı arasında hızlı ve kolay veri yönetimi sağlar. |

---

## 📁 Proje Yapısı

Proje, geliştirici verimliliğini artıracak şekilde standart ASP.NET MVC klasör yapısını takip eder. 
```
Travel_Trip_Project/
├── 📁 App_Start/ # Uygulama yapılandırmaları ve routing
├── 📁 Controllers/ # Backend mantığı ve istek yönetimi
├── 📁 Models/ # Veri modelleri ve iş mantığı
├── 📁 Views/ # Razor/HTML arayüz dosyaları
├── 📁 Content/ # CSS ve stil dosyaları
├── 📁 Scripts/ # JavaScript kütüphaneleri
├── 📁 web/ # Public assetler ve şablonlar
├── 📁 Database/ # SQL scriptleri
├── 📄 Web.config # Ana uygulama yapılandırması
└── 📄 Global.asax # Uygulama seviyesinde olay yönetimi
```
---

## 📸 Ekran Görüntüleri

### 🌐 Kullanıcı Arayüzü (Vitrin)
Modern UI/UX prensiplerine uygun, tamamen responsive ve veritabanı destekli dinamik ön yüz.

<img width="100%" src="https://github.com/user-attachments/assets/41a23017-fdb6-4f92-8a33-e920db1005a5" />

<details>
<summary><strong>🌍 Tüm Kullanıcı Sayfalarını Görmek İçin Tıklayın</strong></summary>
<br>
<img width="100%" src="https://github.com/user-attachments/assets/8df95c80-bc79-46a3-883e-18e17bfe104a" />
<img width="100%" src="https://github.com/user-attachments/assets/c70c20df-40b1-42ec-ad9f-c3aa23ff4747" />
<img width="100%" src="https://github.com/user-attachments/assets/71b87f90-e9d9-400d-bc12-f7ca69a95c94" />
<img width="100%" src="https://github.com/user-attachments/assets/deeaa322-5d9e-4e74-a1a3-017a3e800ff2" />
</details>

<br>

### 📊 Yönetim Paneli (Admin Dashboard)
Yönetici için stratejik karar alma sürecini destekleyen; Chart.js grafik entegrasyonlu, canlı veritabanı istatistikleri ve anlık bildirim merkezi.

<img width="100%" src="https://github.com/user-attachments/assets/358395d9-af72-4ede-a49b-13571103c60d" />

<details>
<summary><strong>📸 Diğer Admin Paneli Modüllerini İncelemek İçin Tıklayın</strong></summary>
<br>

**Detaylı Sistem Modülleri:**
<img width="100%" src="https://github.com/user-attachments/assets/d6c811ad-7625-4122-a10d-b13dcc32bc73" />
<img width="100%" src="https://github.com/user-attachments/assets/0178f079-294b-486d-8596-31ab8ec4a797" />
<img width="100%" src="https://github.com/user-attachments/assets/9d958685-6c40-410f-8849-57293f901410" />
<img width="100%" src="https://github.com/user-attachments/assets/365d15ca-c61e-4f8b-89a6-5ed5c83ded3e" />
<img width="100%" src="https://github.com/user-attachments/assets/09d027a6-5ee1-40d4-ac0f-32ab85f8e1a7" />
<img width="100%" src="https://github.com/user-attachments/assets/6c9a24ce-83d5-47e8-9363-1e902440c5b0" />
<img width="100%" src="https://github.com/user-attachments/assets/9f6a8284-e06d-47eb-8b33-a16fa81109f0" />

</details>

---

## 🚀 Başlangıç

Projeyi lokal ortamda çalıştırmak için:

### Gereksinimler

* **Visual Studio 2022** veya üzeri (ASP.NET workload yüklü)
* **SQL Server**
* **SSMS**

### Kurulum

1. Repository’yi klonlayın
```bash
git clone https://github.com/berdanaksoy/Travel_Trip_Project.git
```

2. Veritabanı kurulumu

SSMS açın

TravelTripDb adında yeni veritabanı oluşturun

Web.config içerisinden Connection String ayarlayın

Package Manager Console'da "update-database" yazarak tabloları veritabanına aktarın.

Veriler için SSMS ile Database/script.sql dosyasını çalıştırın

NuGet paketlerini restore edin.

F5 ile uygulamayı çalıştırın.

## 🔧 Kullanım
Ziyaretçiler İçin

Destinasyonları keşfedin

Blogları okuyun

Yorum bırakın

İletişim formunu kullanın

Yöneticiler İçin

/Login/Login adresinden giriş yapın

Blog ekleyin / güncelleyin

Yorumları yönetin

Mesajları görüntüleyin


## 🤝 Katkıda Bulunma

ResumeProject’e katkılarınızı memnuniyetle karşılıyoruz!

### Nasıl Katkı Sağlanır

Fork alın

Yeni branch oluşturun

Geliştirme yapın

Test edin

Commit atın

Push edin

Pull Request açın
