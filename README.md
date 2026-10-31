# MongoDbWinForms

Bu proje, **C# Windows Forms** kullanılarak geliştirdiğim basit bir müşteri yönetim uygulamasıdır. Uygulama, müşteri bilgilerini MongoDB veritabanına kaydetmemi ve kayıtlı müşterileri ekranda listelememi sağlar.

## Kullanılan Teknolojiler

- C#
- Windows Forms
- .NET Framework 4.7.2
- MongoDB
- MongoDB.Driver 3.13.0
- Visual Studio

## Proje Özellikleri

- Müşteri ekleme
- Müşteri listeleme
- Müşteri bilgilerini form üzerinde görüntüleme
- MongoDB koleksiyonuna kayıt ekleme
- Modern müşteri yönetim arayüzü
- Müşteri listesinde ID, ad, soyad, şehir, bakiye ve alışveriş sayısını gösterme
- Form alanlarını temizleme

## MongoDB Ayarları

Uygulama aşağıdaki bağlantı adresini kullanır:

```text
mongodb://localhost:27017
```

Veritabanı adı:

```text
MongoDbCustomer
```

Koleksiyon adı:

```text
Customers
```

Uygulamayı çalıştırmadan önce bilgisayarımda MongoDB Server servisinin çalıştığından emin olmam gerekir. MongoDB farklı bir portta çalışıyorsa `Services/MongoDbConnection.cs` dosyasındaki bağlantı adresini değiştirmem gerekir.

## Kurulum

1. MongoDB Server'ı bilgisayarıma kurup çalıştırırım.
2. Projeyi Visual Studio ile açarım.
3. NuGet paketlerinin geri yüklenmesini beklerim.
4. Projeyi derlerim.
5. Uygulamayı çalıştırırım.
6. Önce müşteri bilgilerini girip **Müşteri ekle** butonuna, kayıtları görmek için **Listele** butonuna basarım.

## Karşılaştığım Hatalar ve Çözümleri

### 1. `MongoClient` ve `IMongoDatabase` tanınmıyordu

MongoDB'nin yalnızca `MongoDB.Bson` paketini kullandığımı fark ettim. `MongoClient`, `IMongoDatabase` ve `IMongoCollection` sınıfları `MongoDB.Driver` paketinde bulunuyor.

Çözüm olarak:

- `MongoDB.Driver` paketini projeye ekledim.
- `MongoDbConnection.cs` dosyasına aşağıdaki using satırını ekledim:

```csharp
using MongoDB.Driver;
```

### 2. `IMongoCollenction(BsonDocument)` yazım hatası

Collection dönüş tipini yanlış yazmıştım. Doğru kullanım şu şekildedir:

```csharp
public IMongoCollection<BsonDocument> GetCustomersCollection()
```

Burada hem `Collection` yazımını düzelttim hem de `BsonDocument` tipini generic olarak kullandım.

### 3. `DnsClientWrapper` TypeInitializationException hatası

MongoDB istemcisi oluşturulurken `DnsClientWrapper` başlatıcı hatası aldım. Bu hata, MongoDB.Driver'ın ihtiyaç duyduğu `DnsClient.dll` dosyasının uygulama çıktı klasöründe bulunmamasından kaynaklanıyordu.

Çözüm olarak `DnsClient` bağımlılığını ekledim ve .NET Framework 4.7.2 ile uyumlu DLL'in uygulama çıktı klasöründe bulunmasını sağladım.

### 4. `Microsoft.Extensions.Logging.Abstractions` FileNotFoundException hatası

MongoDB.Driver çalışırken aşağıdaki assembly eksikliğiyle karşılaştım:

```text
Microsoft.Extensions.Logging.Abstractions, Version=2.0.0.0
```

Bu MongoDB.Driver'ın ihtiyaç duyduğu bir bağımlılıktı. Gerekli NuGet paketini ekleyip DLL'in uygulama klasörüne kopyalanmasını sağladım.

### 5. `System.Diagnostics.DiagnosticSource` sürüm uyuşmazlığı

Bir aşamada `System.Diagnostics.DiagnosticSource` için sürüm uyuşmazlığı aldım. Uygulama `6.0.0.1` sürümünü isterken elimdeki DLL `6.0.0.0` sürümündeydi.

Bu sorunu `App.config` dosyasına binding redirect ekleyerek çözdüm:

```xml
<dependentAssembly>
  <assemblyIdentity name="System.Diagnostics.DiagnosticSource"
					publicKeyToken="cc7b13ffcd2ddd51"
					culture="neutral" />
  <bindingRedirect oldVersion="0.0.0.0-6.0.0.1"
				   newVersion="6.0.0.0" />
</dependentAssembly>
```

### 6. Windows Forms Designer yükleme hatası

Modern arayüzü oluşturduktan sonra Windows Forms Designer açılırken `CodeDomDesignerLoader` hatası aldım.

Bunun için:

- Designer dosyasındaki zincirli property atamalarını tek tek atamalara çevirdim.
- `DataGridView` için yinelenen `BeginInit` ve `EndInit` çağrılarını düzelttim.
- Proje dosyasının geçerli XML formatında olduğundan emin oldum.
- Gerekirse Visual Studio'yu kapatıp `.vs` klasörünü temizleyerek projeyi tekrar yükledim.

### 7. Projenin Visual Studio'da `unloaded` görünmesi

Bir süre Solution Explorer'da proje `unloaded` olarak görünüyordu. Dosyalar diskte durmasına rağmen Visual Studio projeyi yükleyemiyordu.

Proje dosyasını kontrol ettim ve `MongoDbWinForms.csproj` dosyasındaki bozuk XML satırlarını düzelttim. Proje dosyasının XML yapısı düzeldikten sonra çözüm dosyasını tekrar yükleyebildim.

### 8. DataGridView sütunlarının tekrar etmesi

Müşteri listesinde aynı anda hem elle tanımlanan sütunlar hem de model sınıfından otomatik oluşturulan sütunlar görünüyordu. Bu yüzden `Customer...` şeklinde fazladan sütunlar oluşuyordu.

Çözüm olarak:

- `AutoGenerateColumns` özelliğini `false` yaptım.
- Sütunları müşteri modelindeki property'lere bağladım.
- Sütun başlıklarını Türkçeleştirdim.

Artık listede aşağıdaki sütunlar gösteriliyor:

- ID
- Ad
- Soyad
- Şehir
- Bakiye
- Alışveriş sayısı

## Proje Klasörleri

```text
MongoDbWinForms/
├── Entities/
│   └── Customer.cs
├── Services/
│   ├── MongoDbConnection.cs
│   └── CustomerOperations.cs
├── Form1.cs
├── Form1.Designer.cs
├── App.config
├── packages.config
└── MongoDbWinForms.csproj
```
