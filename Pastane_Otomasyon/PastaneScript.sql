USE [master]
GO
/****** Object:  Database [PastaneProjesi]    Script Date: 10.03.2022 15:05:29 ******/
CREATE DATABASE [PastaneProjesi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PastaneProjesi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\PastaneProjesi.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PastaneProjesi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\PastaneProjesi_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PastaneProjesi] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PastaneProjesi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PastaneProjesi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PastaneProjesi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PastaneProjesi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PastaneProjesi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PastaneProjesi] SET ARITHABORT OFF 
GO
ALTER DATABASE [PastaneProjesi] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PastaneProjesi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PastaneProjesi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PastaneProjesi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PastaneProjesi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PastaneProjesi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PastaneProjesi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PastaneProjesi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PastaneProjesi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PastaneProjesi] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PastaneProjesi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PastaneProjesi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PastaneProjesi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PastaneProjesi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PastaneProjesi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PastaneProjesi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PastaneProjesi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PastaneProjesi] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PastaneProjesi] SET  MULTI_USER 
GO
ALTER DATABASE [PastaneProjesi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PastaneProjesi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PastaneProjesi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PastaneProjesi] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PastaneProjesi] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PastaneProjesi] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [PastaneProjesi] SET QUERY_STORE = OFF
GO
USE [PastaneProjesi]
GO
/****** Object:  Table [dbo].[AdminGiris]    Script Date: 10.03.2022 15:05:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminGiris](
	[AdminNo] [int] IDENTITY(1,1) NOT NULL,
	[AdminAdSoyad] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[AdminEposta] [varchar](50) NULL,
	[AdminTelefon] [nchar](11) NULL,
 CONSTRAINT [PK_AdminGiris] PRIMARY KEY CLUSTERED 
(
	[AdminNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KullaniciGirisi]    Script Date: 10.03.2022 15:05:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KullaniciGirisi](
	[MusteriNo] [int] IDENTITY(1,1) NOT NULL,
	[MusteriAd] [varchar](50) NOT NULL,
	[KullaniciSifre] [varchar](50) NOT NULL,
	[EMail] [varchar](50) NOT NULL,
	[Telefon] [varchar](11) NOT NULL,
 CONSTRAINT [PK_KullanıcıGirisi] PRIMARY KEY CLUSTERED 
(
	[MusteriNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Satici]    Script Date: 10.03.2022 15:05:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Satici](
	[SaticiNo] [int] IDENTITY(1,1) NOT NULL,
	[SaticiAdSoyad] [varchar](50) NULL,
	[SaticiAdres] [varchar](50) NULL,
	[Saticiİl] [varchar](50) NULL,
	[Saticiİlce] [varchar](50) NULL,
 CONSTRAINT [PK_Satici] PRIMARY KEY CLUSTERED 
(
	[SaticiNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Siparis]    Script Date: 10.03.2022 15:05:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Siparis](
	[SiparisNo] [int] IDENTITY(1,1) NOT NULL,
	[SiparisAdi] [varchar](50) NULL,
	[SiparisAdres] [varchar](50) NULL,
	[SiparisFiyat] [money] NULL,
	[Tutar] [money] NULL,
	[MusteriNo] [int] NOT NULL,
 CONSTRAINT [PK_Siparis] PRIMARY KEY CLUSTERED 
(
	[SiparisNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Siparis_Details]    Script Date: 10.03.2022 15:05:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Siparis_Details](
	[UrunlerNo] [int] IDENTITY(1,1) NOT NULL,
	[SiparişNo] [int] NULL,
	[UrunAd] [varchar](50) NULL,
	[UrunAdet] [int] NULL,
 CONSTRAINT [PK_Urun_Details] PRIMARY KEY CLUSTERED 
(
	[UrunlerNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Urun]    Script Date: 10.03.2022 15:05:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Urun](
	[UrunNo] [int] IDENTITY(1,1) NOT NULL,
	[UrunAdi] [varchar](50) NULL,
	[UrunFiyat] [money] NULL,
	[KullanimTarihi] [date] NULL,
	[UretimTarihi] [date] NULL,
	[SaticiNo] [int] NULL,
	[Fotograf] [varchar](50) NULL,
 CONSTRAINT [PK_Urun] PRIMARY KEY CLUSTERED 
(
	[UrunNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AdminGiris] ON 

INSERT [dbo].[AdminGiris] ([AdminNo], [AdminAdSoyad], [Password], [AdminEposta], [AdminTelefon]) VALUES (1, N'Kübra Özyakışır', N'2525', N'kbrozyksr@gmail.com', N'05302448436')
SET IDENTITY_INSERT [dbo].[AdminGiris] OFF
GO
SET IDENTITY_INSERT [dbo].[KullaniciGirisi] ON 

INSERT [dbo].[KullaniciGirisi] ([MusteriNo], [MusteriAd], [KullaniciSifre], [EMail], [Telefon]) VALUES (2, N'saygın özer', N'123456', N'saygın@gmail.com', N'05326589852')
INSERT [dbo].[KullaniciGirisi] ([MusteriNo], [MusteriAd], [KullaniciSifre], [EMail], [Telefon]) VALUES (3, N'melisa mert', N'123456', N'melisa@gmail.com', N'05426985874')
INSERT [dbo].[KullaniciGirisi] ([MusteriNo], [MusteriAd], [KullaniciSifre], [EMail], [Telefon]) VALUES (5, N'laledevri', N'123456', N' lale@gmail.com', N' 5329652589')
INSERT [dbo].[KullaniciGirisi] ([MusteriNo], [MusteriAd], [KullaniciSifre], [EMail], [Telefon]) VALUES (6, N'Özge Gülten', N'12', N'ozge@gmail.com', N'5321563256')
INSERT [dbo].[KullaniciGirisi] ([MusteriNo], [MusteriAd], [KullaniciSifre], [EMail], [Telefon]) VALUES (14, N'', N'', N' ', N' ')
SET IDENTITY_INSERT [dbo].[KullaniciGirisi] OFF
GO
SET IDENTITY_INSERT [dbo].[Satici] ON 

INSERT [dbo].[Satici] ([SaticiNo], [SaticiAdSoyad], [SaticiAdres], [Saticiİl], [Saticiİlce]) VALUES (1, N'Ahmet Saygın', N'Bebek Mah. Tepecikyolu Cad, Cevher Sok. 5C', N'İstanbul', N'Bebek')
INSERT [dbo].[Satici] ([SaticiNo], [SaticiAdSoyad], [SaticiAdres], [Saticiİl], [Saticiİlce]) VALUES (2, N'Lale Sevinc', N'Etiler Mah.Tepecik Yolu,Akgören Sokağı D:No:3/1', N'İstanbul', N'Etiler')
INSERT [dbo].[Satici] ([SaticiNo], [SaticiAdSoyad], [SaticiAdres], [Saticiİl], [Saticiİlce]) VALUES (11, N'Nazlı Güner', N'Atatürk Mahallesi no.52', N'İstanbul', N'Maltepe')
SET IDENTITY_INSERT [dbo].[Satici] OFF
GO
SET IDENTITY_INSERT [dbo].[Urun] ON 

INSERT [dbo].[Urun] ([UrunNo], [UrunAdi], [UrunFiyat], [KullanimTarihi], [UretimTarihi], [SaticiNo], [Fotograf]) VALUES (1, N'Yas Pasta', 150.0000, CAST(N'2022-05-15' AS Date), CAST(N'2022-04-14' AS Date), 1, N'C:\Users\kubra\OneDrive\Masaüstü\photo\p.jpg')
INSERT [dbo].[Urun] ([UrunNo], [UrunAdi], [UrunFiyat], [KullanimTarihi], [UretimTarihi], [SaticiNo], [Fotograf]) VALUES (2, N'Kurabiye', 200.0000, CAST(N'2022-04-14' AS Date), CAST(N'2022-03-15' AS Date), 11, N'C:\Users\kubra\OneDrive\Masaüstü\photo\k.jpg')
INSERT [dbo].[Urun] ([UrunNo], [UrunAdi], [UrunFiyat], [KullanimTarihi], [UretimTarihi], [SaticiNo], [Fotograf]) VALUES (3, N'Nihos Pasta', 250.0000, CAST(N'2022-01-21' AS Date), CAST(N'2022-02-22' AS Date), 11, N'C:\Users\kubra\OneDrive\Masaüstü\photo\ni.jpg')
INSERT [dbo].[Urun] ([UrunNo], [UrunAdi], [UrunFiyat], [KullanimTarihi], [UretimTarihi], [SaticiNo], [Fotograf]) VALUES (8, N'İzmir Bombası', 30.0000, CAST(N'2021-12-12' AS Date), CAST(N'2022-12-13' AS Date), 2, N'C:\Users\kubra\OneDrive\Masaüstü\photo\iz.jpg')
INSERT [dbo].[Urun] ([UrunNo], [UrunAdi], [UrunFiyat], [KullanimTarihi], [UretimTarihi], [SaticiNo], [Fotograf]) VALUES (9, N'Waffle', 45.0000, CAST(N'2022-05-13' AS Date), CAST(N'2022-05-15' AS Date), 2, N'C:\Users\kubra\OneDrive\Masaüstü\photo\w.jpg')
INSERT [dbo].[Urun] ([UrunNo], [UrunAdi], [UrunFiyat], [KullanimTarihi], [UretimTarihi], [SaticiNo], [Fotograf]) VALUES (14, N'Kek', 20.0000, CAST(N'2022-03-12' AS Date), CAST(N'2022-03-13' AS Date), 1, N'C:\Users\kubra\OneDrive\Masaüstü\photo\b.png')
SET IDENTITY_INSERT [dbo].[Urun] OFF
GO
ALTER TABLE [dbo].[Siparis]  WITH CHECK ADD  CONSTRAINT [FK_Siparis_KullaniciGirisi] FOREIGN KEY([MusteriNo])
REFERENCES [dbo].[KullaniciGirisi] ([MusteriNo])
GO
ALTER TABLE [dbo].[Siparis] CHECK CONSTRAINT [FK_Siparis_KullaniciGirisi]
GO
ALTER TABLE [dbo].[Siparis]  WITH CHECK ADD  CONSTRAINT [FK_Siparis_KullaniciGirisi1] FOREIGN KEY([MusteriNo])
REFERENCES [dbo].[KullaniciGirisi] ([MusteriNo])
GO
ALTER TABLE [dbo].[Siparis] CHECK CONSTRAINT [FK_Siparis_KullaniciGirisi1]
GO
ALTER TABLE [dbo].[Siparis_Details]  WITH CHECK ADD  CONSTRAINT [FK_Siparis_Details_Siparis] FOREIGN KEY([SiparişNo])
REFERENCES [dbo].[Siparis] ([SiparisNo])
GO
ALTER TABLE [dbo].[Siparis_Details] CHECK CONSTRAINT [FK_Siparis_Details_Siparis]
GO
ALTER TABLE [dbo].[Siparis_Details]  WITH CHECK ADD  CONSTRAINT [FK_Siparis_Details_Urun] FOREIGN KEY([UrunlerNo])
REFERENCES [dbo].[Urun] ([UrunNo])
GO
ALTER TABLE [dbo].[Siparis_Details] CHECK CONSTRAINT [FK_Siparis_Details_Urun]
GO
ALTER TABLE [dbo].[Urun]  WITH CHECK ADD  CONSTRAINT [FK_Urun_Satici] FOREIGN KEY([SaticiNo])
REFERENCES [dbo].[Satici] ([SaticiNo])
GO
ALTER TABLE [dbo].[Urun] CHECK CONSTRAINT [FK_Urun_Satici]
GO
USE [master]
GO
ALTER DATABASE [PastaneProjesi] SET  READ_WRITE 
GO
