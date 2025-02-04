USE [master]
GO
/****** Object:  Database [Januar2023]    Script Date: 13-Jul-23 13:11:00 ******/
CREATE DATABASE [Januar2023]
GO
ALTER DATABASE [Januar2023] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Januar2023] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Januar2023] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Januar2023] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Januar2023] SET ARITHABORT OFF 
GO
ALTER DATABASE [Januar2023] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Januar2023] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Januar2023] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Januar2023] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Januar2023] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Januar2023] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Januar2023] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Januar2023] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Januar2023] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Januar2023] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Januar2023] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Januar2023] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Januar2023] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Januar2023] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Januar2023] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Januar2023] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Januar2023] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Januar2023] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Januar2023] SET  MULTI_USER 
GO
ALTER DATABASE [Januar2023] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Januar2023] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Januar2023] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Januar2023] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Januar2023] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Januar2023] SET QUERY_STORE = OFF
GO
USE [Januar2023]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [Januar2023]
GO
/****** Object:  Table [dbo].[Angazovanje]    Script Date: 13-Jul-23 13:11:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Angazovanje](
	[predmetId] [int] NOT NULL,
	[profesorId] [int] NOT NULL,
	[datum] [varchar](50) NOT NULL,
	[emailKorisnika] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Angazovanje] PRIMARY KEY CLUSTERED 
(
	[predmetId] ASC,
	[profesorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Predmet]    Script Date: 13-Jul-23 13:11:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Predmet](
	[predmetId] [int] IDENTITY(1,1) NOT NULL,
	[sifraPredmeta] [varchar](50) NOT NULL,
	[nazivPredmeta] [varchar](50) NOT NULL,
	[kodPredmeta] [varchar](10) NOT NULL,
	[brojESPB] [int] NOT NULL,
 CONSTRAINT [PK_Predmet] PRIMARY KEY CLUSTERED 
(
	[predmetId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profesor]    Script Date: 13-Jul-23 13:11:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesor](
	[profesorId] [int] IDENTITY(1,1) NOT NULL,
	[ime] [varchar](50) NOT NULL,
	[prezime] [varchar](50) NOT NULL,
	[zvanje] [int] NOT NULL,
	[emailKorisnika] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Profesor] PRIMARY KEY CLUSTERED 
(
	[profesorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Angazovanje] ([predmetId], [profesorId], [datum], [emailKorisnika]) VALUES (16, 1, N'03-Jul-23', N'fico@gmail.com')
INSERT [dbo].[Angazovanje] ([predmetId], [profesorId], [datum], [emailKorisnika]) VALUES (16, 2, N'04-Jul-23', N'fico@gmail.com')
INSERT [dbo].[Angazovanje] ([predmetId], [profesorId], [datum], [emailKorisnika]) VALUES (16, 3, N'12-Jul-23', N'fico@gmail.com')
INSERT [dbo].[Angazovanje] ([predmetId], [profesorId], [datum], [emailKorisnika]) VALUES (17, 1, N'12-Jul-23', N'fico@gmail.com')
INSERT [dbo].[Angazovanje] ([predmetId], [profesorId], [datum], [emailKorisnika]) VALUES (17, 2, N'12-Jul-23', N'fico@gmail.com')
INSERT [dbo].[Angazovanje] ([predmetId], [profesorId], [datum], [emailKorisnika]) VALUES (17, 3, N'12-Jul-23', N'fico@gmail.com')
INSERT [dbo].[Angazovanje] ([predmetId], [profesorId], [datum], [emailKorisnika]) VALUES (18, 1, N'12-Jul-23', N'fico@gmail.com')
INSERT [dbo].[Angazovanje] ([predmetId], [profesorId], [datum], [emailKorisnika]) VALUES (18, 2, N'12-Jul-23', N'fico@gmail.com')
INSERT [dbo].[Angazovanje] ([predmetId], [profesorId], [datum], [emailKorisnika]) VALUES (18, 3, N'12-Jul-23', N'fico@gmail.com')
INSERT [dbo].[Angazovanje] ([predmetId], [profesorId], [datum], [emailKorisnika]) VALUES (20, 1002, N'12-Jul-23', N'fico@gmail.com')
INSERT [dbo].[Angazovanje] ([predmetId], [profesorId], [datum], [emailKorisnika]) VALUES (21, 1003, N'12-Jul-23', N'fico@gmail.com')
INSERT [dbo].[Angazovanje] ([predmetId], [profesorId], [datum], [emailKorisnika]) VALUES (21, 1004, N'17-Apr-23', N'fico@gmail.com')
INSERT [dbo].[Angazovanje] ([predmetId], [profesorId], [datum], [emailKorisnika]) VALUES (22, 1003, N'12-Jul-23', N'fico@gmail.com')
INSERT [dbo].[Angazovanje] ([predmetId], [profesorId], [datum], [emailKorisnika]) VALUES (22, 1004, N'17-Apr-23', N'fico@gmail.com')
INSERT [dbo].[Angazovanje] ([predmetId], [profesorId], [datum], [emailKorisnika]) VALUES (22, 1005, N'17-Apr-23', N'fico@gmail.com')
GO
SET IDENTITY_INSERT [dbo].[Predmet] ON 

INSERT [dbo].[Predmet] ([predmetId], [sifraPredmeta], [nazivPredmeta], [kodPredmeta], [brojESPB]) VALUES (16, N'ps', N'projektovanje softvera', N'1', 6)
INSERT [dbo].[Predmet] ([predmetId], [sifraPredmeta], [nazivPredmeta], [kodPredmeta], [brojESPB]) VALUES (17, N'p1', N'programiranje 1', N'pro1', 4)
INSERT [dbo].[Predmet] ([predmetId], [sifraPredmeta], [nazivPredmeta], [kodPredmeta], [brojESPB]) VALUES (18, N'nj', N'napredne java tehnologije', N'nj1', 4)
INSERT [dbo].[Predmet] ([predmetId], [sifraPredmeta], [nazivPredmeta], [kodPredmeta], [brojESPB]) VALUES (20, N'epos', N'Elektronsko poslovanje', N'epos1', 6)
INSERT [dbo].[Predmet] ([predmetId], [sifraPredmeta], [nazivPredmeta], [kodPredmeta], [brojESPB]) VALUES (21, N'na', N'numericka analiza', N'na1', 5)
INSERT [dbo].[Predmet] ([predmetId], [sifraPredmeta], [nazivPredmeta], [kodPredmeta], [brojESPB]) VALUES (22, N'm1', N'matematika 1', N'mata1', 6)
SET IDENTITY_INSERT [dbo].[Predmet] OFF
GO
SET IDENTITY_INSERT [dbo].[Profesor] ON 

INSERT [dbo].[Profesor] ([profesorId], [ime], [prezime], [zvanje], [emailKorisnika]) VALUES (1, N'Dule', N'Savic', 2, N'fico@gmail.com')
INSERT [dbo].[Profesor] ([profesorId], [ime], [prezime], [zvanje], [emailKorisnika]) VALUES (2, N'Ilija', N'Antovic', 2, N'fico@gmail.com')
INSERT [dbo].[Profesor] ([profesorId], [ime], [prezime], [zvanje], [emailKorisnika]) VALUES (3, N'Milos', N'Milic', 2, N'fico@gmail.com')
INSERT [dbo].[Profesor] ([profesorId], [ime], [prezime], [zvanje], [emailKorisnika]) VALUES (1002, N'Dusan', N'Barac', 2, N'fico@gmail.com')
INSERT [dbo].[Profesor] ([profesorId], [ime], [prezime], [zvanje], [emailKorisnika]) VALUES (1003, N'Rade', N'Lazovic', 2, N'fico@gmail.com')
INSERT [dbo].[Profesor] ([profesorId], [ime], [prezime], [zvanje], [emailKorisnika]) VALUES (1004, N'Vukasin', N'Brkovic', 0, N'fico@gmail.com')
INSERT [dbo].[Profesor] ([profesorId], [ime], [prezime], [zvanje], [emailKorisnika]) VALUES (1005, N'Dusan', N'Dzamic', 1, N'fico@gmail.com')
SET IDENTITY_INSERT [dbo].[Profesor] OFF
GO
ALTER TABLE [dbo].[Angazovanje]  WITH CHECK ADD  CONSTRAINT [FK_Angazovanje_Predmet] FOREIGN KEY([predmetId])
REFERENCES [dbo].[Predmet] ([predmetId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Angazovanje] CHECK CONSTRAINT [FK_Angazovanje_Predmet]
GO
ALTER TABLE [dbo].[Angazovanje]  WITH CHECK ADD  CONSTRAINT [FK_Angazovanje_Profesor] FOREIGN KEY([profesorId])
REFERENCES [dbo].[Profesor] ([profesorId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Angazovanje] CHECK CONSTRAINT [FK_Angazovanje_Profesor]
GO
USE [master]
GO
ALTER DATABASE [Januar2023] SET  READ_WRITE 
GO
