# UserSurvey.Web

## Proje Tanımı

UserSurvey.Web, kullanıcıların anket doldurabildiği, yönetici ve kullanıcı rolleriyle çalışan bir ASP.NET Core MVC web uygulamasıdır. Kullanıcılar kayıt olabilir, giriş yapabilir, profilini düzenleyebilir ve anketlere katılabilir. Yöneticiler ise anketleri ve kullanıcıları yönetebilir.

## Özellikler

- Kullanıcı ve yönetici rolleri
- Anket oluşturma, listeleme ve yanıtlama
- Kullanıcı kayıt, giriş ve profil yönetimi
- Yönetici paneli
- Entity Framework Core ile SQL Server veritabanı
- Migration ve seed data desteği

## Kurulum

1. **Projeyi klonlayın:**
   ```bash
   git clone <repo-url>
   cd UserSurvey.Web
   ```
2. **Bağımlılıkları yükleyin:**
   - Visual Studio veya .NET CLI ile restore işlemi otomatik yapılır.
   - Gerekirse:
     ```bash
     dotnet restore
     ```
3. **Veritabanı ayarlarını yapın:**
   - `UserInsightSurvey/appsettings.json` dosyasındaki `ConnectionStrings` bölümünü kendi veritabanınıza göre düzenleyin.

## Migration ve Veritabanı

- Migration dosyaları hazırdır. Yeni migration eklemek için:
  ```bash
  dotnet ef migrations add <MigrationAdi> -p UserInsightSurvey/UserInsightSurvey.csproj -s UserInsightSurvey/UserInsightSurvey.csproj
  ```
- Veritabanını güncellemek için:
  ```bash
  dotnet ef database update -p UserInsightSurvey/UserInsightSurvey.csproj -s UserInsightSurvey/UserInsightSurvey.csproj
  ```

## Çalıştırma

```bash
dotnet run --project UserInsightSurvey/UserInsightSurvey.csproj
```

veya Visual Studio ile F5 tuşuna basarak başlatabilirsiniz.

## Testler

- Şu anda test projesi bulunmamaktadır. Test altyapısı eklenmesi önerilir.

## Yol Haritası (Planlanan Özellikler)

- **E-posta Doğrulama:**
  - Kullanıcı kayıt olduktan sonra e-posta adresine doğrulama maili gönderilecek ve doğrulama yapılmadan giriş yapılamayacak.
- **Şifremi Unuttum:**
  - Kullanıcılar, şifrelerini unuttuklarında e-posta üzerinden şifre sıfırlama bağlantısı alabilecek.
- **Admin için CRUD Sayfaları:**
  - Admin panelinde kullanıcı, anket, soru ve seçenekler için tam kapsamlı CRUD (oluşturma, okuma, güncelleme, silme) işlemlerinin yapılabileceği sayfalar eklenecek.
