USE master;
GO
IF EXISTS (SELECT * FROM sys.databases WHERE name = 'KutuphaneDB')
BEGIN
    ALTER DATABASE KutuphaneDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE KutuphaneDB;
END
GO

CREATE DATABASE KutuphaneDB COLLATE Turkish_CI_AS;
GO

USE KutuphaneDB;
GO


CREATE TABLE Kitaplar (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Ad NVARCHAR(100) NOT NULL,
    Yazar NVARCHAR(100) NOT NULL,
    Kategori NVARCHAR(50),
    Durum NVARCHAR(20) DEFAULT N'Mevcut',
    AlanUye NVARCHAR(100),
    VerilisTarihi NVARCHAR(20),
    TeslimTarihi NVARCHAR(20),
    Ozet NVARCHAR(MAX)
);


CREATE TABLE Uyeler (
    Id INT PRIMARY KEY IDENTITY(1,1),
    AdSoyad NVARCHAR(100) NOT NULL,
    Telefon NVARCHAR(20),
    Eposta NVARCHAR(100),
    KayitTarihi DATETIME DEFAULT GETDATE()
);


CREATE TABLE OduncIslemleri (
    Id INT PRIMARY KEY IDENTITY(1,1),
    KitapIsmi NVARCHAR(100),
    UyeIsmi NVARCHAR(100),
    IslemTarihi NVARCHAR(20),
    IadeTarihi NVARCHAR(20),
    IslemTipi NVARCHAR(20)
);

INSERT INTO Kitaplar (Ad, Yazar, Kategori, Ozet) VALUES 
(N'Nutuk', N'Mustafa Kemal Atatürk', N'Türk Edebiyatı', N'Türkiye Cumhuriyeti kuruluş süreci.'),
(N'Sefiller', N'Victor Hugo', N'Dünya Klasikleri', N'Jean Valjean mücadelesi.'),
(N'Suç ve Ceza', N'Dostoyevski', N'Dünya Klasikleri', N'Raskolnikov vicdan azabı.'),
(N'1984', N'George Orwell', N'Bilim Kurgu', N'Distopik dünya.'),
(N'Simyacı', N'Paulo Coelho', N'Macera', N'Kişisel menkıbe.'),
(N'Kürk Mantolu Madonna', N'Sabahattin Ali', N'Türk Edebiyatı', N'Unutulmaz aşk.'),
(N'Çalıkuşu', N'Reşat Nuri Güntekin', N'Türk Edebiyatı', N'Feride''nin hikayesi.'),
(N'Tutunamayanlar', N'Oğuz Atay', N'Türk Edebiyatı', N'Selim Işık ve Turgut Özben.'),
(N'İnce Memed', N'Yaşar Kemal', N'Türk Edebiyatı', N'Eşkiyalık ve adalet.'),
(N'Saatleri Ayarlama Enstitüsü', N'Ahmet Hamdi Tanpınar', N'Türk Edebiyatı', N'Doğu-Batı çatışması.'),
(N'Kuyucaklı Yusuf', N'Sabahattin Ali', N'Türk Edebiyatı', N'Kasaba hayatı.'),
(N'Dokuzuncu Hariciye Koğuşu', N'Peyami Safa', N'Türk Edebiyatı', N'Psikolojik roman.'),
(N'Aşk-ı Memnu', N'Halid Ziya Uşaklıgil', N'Türk Edebiyatı', N'Yasak aşk.'),
(N'Yaban', N'Yakup Kadri Karaosmanoğlu', N'Türk Edebiyatı', N'Köylü-Aydın çatışması.'),
(N'Eylül', N'Mehmet Rauf', N'Türk Edebiyatı', N'İlk psikolojik roman.'),
(N'Şeker Portakalı', N'Jose Mauro de Vasconcelos', N'Dünya Klasikleri', N'Zeze''nin dünyası.'),
(N'Küçük Prens', N'Antoine de Saint-Exupéry', N'Dünya Klasikleri', N'Masalsı hikaye.'),
(N'Hayvan Çiftliği', N'George Orwell', N'Modern Edebiyat', N'Siyasi hiciv.'),
(N'Dönüşüm', N'Franz Kafka', N'Dünya Klasikleri', N'Gregor Samsa.'),
(N'Beyaz Diş', N'Jack London', N'Macera', N'Doğa ve kurt.'),
(N'Martin Eden', N'Jack London', N'Dünya Klasikleri', N'Yazarın mücadelesi.'),
(N'Fareler ve İnsanlar', N'John Steinbeck', N'Dünya Klasikleri', N'Dostluk hikayesi.'),
(N'Gazap Üzümleri', N'John Steinbeck', N'Dünya Klasikleri', N'Ekonomik buhran.'),
(N'Karamazov Kardeşler', N'Dostoyevski', N'Dünya Klasikleri', N'Baba-oğul çatışması.'),
(N'Budala', N'Dostoyevski', N'Dünya Klasikleri', N'Mışkin''in saflığı.'),
(N'Ölü Canlar', N'Nikolay Gogol', N'Dünya Klasikleri', N'Rus toplumu eleştirisi.'),
(N'Savaş ve Barış', N'Lev Tolstoy', N'Dünya Klasikleri', N'Napolyon savaşları.'),
(N'Anna Karenina', N'Lev Tolstoy', N'Dünya Klasikleri', N'Toplumsal trajedi.'),
(N'Diriliş', N'Lev Tolstoy', N'Dünya Klasikleri', N'Manevi uyanış.'),
(N'Babalar ve Oğullar', N'İvan Turgenyev', N'Dünya Klasikleri', N'Nihilizm.'),
(N'Madame Bovary', N'Gustave Flaubert', N'Dünya Klasikleri', N'Hayaller ve gerçekler.'),
(N'Vadideki Zambak', N'Honoré de Balzac', N'Dünya Klasikleri', N'Aşk ve sadakat.'),
(N'Goriot Baba', N'Honoré de Balzac', N'Dünya Klasikleri', N'Fedakar baba.'),
(N'Kırmızı ve Siyah', N'Stendhal', N'Dünya Klasikleri', N'Hırs ve yükseliş.'),
(N'Yüzyıllık Yalnızlık', N'Gabriel García Márquez', N'Dünya Klasikleri', N'Macondo hikayesi.'),
(N'Kolera Günlerinde Aşk', N'Gabriel García Márquez', N'Dünya Klasikleri', N'Ebedi aşk.'),
(N'Don Kişot', N'Miguel de Cervantes', N'Dünya Klasikleri', N'Yel değirmenleri.'),
(N'Faust', N'Goethe', N'Dünya Klasikleri', N'Bilgi arayışı.'),
(N'Genç Werther''in Acıları', N'Goethe', N'Dünya Klasikleri', N'Karşılıksız aşk.'),
(N'Böyle Buyurdu Zerdüşt', N'Friedrich Nietzsche', N'Modern Edebiyat', N'Üstinsan.'),
(N'Devlet', N'Platon', N'Dünya Klasikleri', N'İdeal toplum.'),
(N'Sokrates''in Savunması', N'Platon', N'Dünya Klasikleri', N'Adalet mücadelesi.'),
(N'Prens', N'Niccolò Machiavelli', N'Dünya Klasikleri', N'Siyaset sanatı.'),
(N'Toplum Sözleşmesi', N'Jean-Jacques Rousseau', N'Dünya Klasikleri', N'Özgürlük.'),
(N'Utopia', N'Thomas More', N'Dünya Klasikleri', N'Hayali ada.'),
(N'Denemeler', N'Montaigne', N'Dünya Klasikleri', N'Kişisel gözlemler.'),
(N'Hamlet', N'William Shakespeare', N'Dünya Klasikleri', N'İntikam.'),
(N'Macbeth', N'William Shakespeare', N'Dünya Klasikleri', N'Hırs ve vicdan.'),
(N'Romeo ve Juliet', N'William Shakespeare', N'Dünya Klasikleri', N'Trajik aşk.'),
(N'Othello', N'William Shakespeare', N'Dünya Klasikleri', N'Kıskançlık.'),
(N'İlahi Komedya', N'Dante Alighieri', N'Dünya Klasikleri', N'Manevi yolculuk.'),
(N'Robinson Crusoe', N'Daniel Defoe', N'Macera', N'Issız ada.'),
(N'Gulliver''in Gezileri', N'Jonathan Swift', N'Macera', N'Fantastik yolculuk.'),
(N'Oliver Twist', N'Charles Dickens', N'Dünya Klasikleri', N'Yetimhane hayatı.'),
(N'İki Şehrin Hikayesi', N'Charles Dickens', N'Dünya Klasikleri', N'Fransız devrimi.'),
(N'Büyük Umutlar', N'Charles Dickens', N'Dünya Klasikleri', N'Pip''in hikayesi.'),
(N'Moby Dick', N'Herman Melville', N'Macera', N'Beyaz balina.'),
(N'Define Adası', N'Robert Louis Stevenson', N'Macera', N'Korsanlar.'),
(N'Dracula', N'Bram Stoker', N'Polisiye', N'Vampir efsanesi.'),
(N'Frankenstein', N'Mary Shelley', N'Dünya Klasikleri', N'Canavar ve yaratıcısı.'),
(N'Sherlock Holmes', N'Arthur Conan Doyle', N'Polisiye', N'Zeki dedektif.'),
(N'Arsen Lüpen', N'Maurice Leblanc', N'Polisiye', N'Kibar hırsız.'),
(N'Yüzüklerin Efendisi', N'J.R.R. Tolkien', N'Macera', N'Orta Dünya.'),
(N'Hobbit', N'J.R.R. Tolkien', N'Macera', N'Bilbo Baggins.'),
(N'Harry Potter', N'J.K. Rowling', N'Macera', N'Büyücülük okulu.'),
(N'Da Vinci Şifresi', N'Dan Brown', N'Polisiye', N'Gizem ve semboller.'),
(N'Melekler ve Şeytanlar', N'Dan Brown', N'Polisiye', N'İlluminati.'),
(N'Olasılıksız', N'Adam Fawer', N'Macera', N'İhtimaller dünyası.'),
(N'Empati', N'Adam Fawer', N'Macera', N'Duyguların gücü.');

INSERT INTO Uyeler (AdSoyad, Telefon, Eposta) VALUES 
(N'Ahmet Yılmaz', N'5551112233', N'ahmet@mail.com'),
(N'Ayşe Demir', N'5442223344', N'ayse@mail.com'),
(N'Mehmet Kaya', N'5323334455', N'mehmet@mail.com'),
(N'Fatma Şahin', N'5054445566', N'fatma@mail.com'),
(N'Caner Öz', N'5515556677', N'caner@mail.com');