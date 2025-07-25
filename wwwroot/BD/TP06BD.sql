USE [master]
GO
/****** Object:  Database [BaseDatosTP06]    Script Date: 23/7/2025 13:05:48 ******/
CREATE DATABASE [BaseDatosTP06]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BaseDatosTP06', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\BaseDatosTP06.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BaseDatosTP06_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\BaseDatosTP06_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [BaseDatosTP06] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BaseDatosTP06].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BaseDatosTP06] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BaseDatosTP06] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BaseDatosTP06] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BaseDatosTP06] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BaseDatosTP06] SET ARITHABORT OFF 
GO
ALTER DATABASE [BaseDatosTP06] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BaseDatosTP06] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BaseDatosTP06] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BaseDatosTP06] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BaseDatosTP06] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BaseDatosTP06] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BaseDatosTP06] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BaseDatosTP06] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BaseDatosTP06] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BaseDatosTP06] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BaseDatosTP06] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BaseDatosTP06] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BaseDatosTP06] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BaseDatosTP06] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BaseDatosTP06] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BaseDatosTP06] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BaseDatosTP06] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BaseDatosTP06] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BaseDatosTP06] SET  MULTI_USER 
GO
ALTER DATABASE [BaseDatosTP06] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BaseDatosTP06] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BaseDatosTP06] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BaseDatosTP06] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BaseDatosTP06] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BaseDatosTP06] SET QUERY_STORE = OFF
GO
USE [BaseDatosTP06]
GO
/****** Object:  Table [dbo].[DatoFamiliar]    Script Date: 23/7/2025 13:05:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatoFamiliar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Parentesco] [varchar](50) NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_DatoFamiliar] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DatoInteres]    Script Date: 23/7/2025 13:05:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatoInteres](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NULL,
	[TipoInteres] [int] NULL,
	[Interes] [varchar](50) NULL,
 CONSTRAINT [PK_DatoInteres] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 23/7/2025 13:05:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Contraseña] [varchar](50) NULL,
	[FechaNacimiento] [date] NULL,
	[Foto] [varchar](50) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DatoFamiliar] ON 

INSERT [dbo].[DatoFamiliar] ([Id], [IdUsuario], [Nombre], [Apellido], [Parentesco], [Descripcion]) VALUES (1, 1, N'Pablo', N'Drucker', N'Padre', N'Pelado crack')
INSERT [dbo].[DatoFamiliar] ([Id], [IdUsuario], [Nombre], [Apellido], [Parentesco], [Descripcion]) VALUES (2, 2, N'Marisa', N'Jaitt', N'Madre', N'Doctora')
INSERT [dbo].[DatoFamiliar] ([Id], [IdUsuario], [Nombre], [Apellido], [Parentesco], [Descripcion]) VALUES (3, 3, N'Ejemplo', N'Ejemplo apellido', N'Padre', N'lorem')
SET IDENTITY_INSERT [dbo].[DatoFamiliar] OFF
GO
SET IDENTITY_INSERT [dbo].[DatoInteres] ON 

INSERT [dbo].[DatoInteres] ([Id], [IdUsuario], [TipoInteres], [Interes]) VALUES (1, 1, 1, N'Basquet')
INSERT [dbo].[DatoInteres] ([Id], [IdUsuario], [TipoInteres], [Interes]) VALUES (2, 2, 4, N'Helado de ddl')
INSERT [dbo].[DatoInteres] ([Id], [IdUsuario], [TipoInteres], [Interes]) VALUES (3, 1, 2, N'La casa de papel')
INSERT [dbo].[DatoInteres] ([Id], [IdUsuario], [TipoInteres], [Interes]) VALUES (4, 2, 2, N'Outer Banks')
INSERT [dbo].[DatoInteres] ([Id], [IdUsuario], [TipoInteres], [Interes]) VALUES (5, 3, 1, N'Ejemplo')
SET IDENTITY_INSERT [dbo].[DatoInteres] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([Id], [Nombre], [Apellido], [Email], [Contraseña], [FechaNacimiento], [Foto]) VALUES (1, N'Federico', N'Drucker', N'federicodrucker@gmail.com', N'fede12345', CAST(N'2008-11-18' AS Date), N'fede.jpg')
INSERT [dbo].[Usuario] ([Id], [Nombre], [Apellido], [Email], [Contraseña], [FechaNacimiento], [Foto]) VALUES (2, N'Gaton', N'Daiksel', N'gastidaiksel@gmail.com', N'gasti12345', CAST(N'2008-01-01' AS Date), N'gasti.jpg')
INSERT [dbo].[Usuario] ([Id], [Nombre], [Apellido], [Email], [Contraseña], [FechaNacimiento], [Foto]) VALUES (3, N'Ejemlo', N'Apellido Ejemplo', N'a', N'a', CAST(N'0001-01-01' AS Date), N'ejemplo.jpg')
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
ALTER TABLE [dbo].[DatoFamiliar]  WITH CHECK ADD  CONSTRAINT [FK_DatoFamiliar_Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([Id])
GO
ALTER TABLE [dbo].[DatoFamiliar] CHECK CONSTRAINT [FK_DatoFamiliar_Usuario]
GO
ALTER TABLE [dbo].[DatoInteres]  WITH CHECK ADD  CONSTRAINT [FK_DatoInteres_Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([Id])
GO
ALTER TABLE [dbo].[DatoInteres] CHECK CONSTRAINT [FK_DatoInteres_Usuario]
GO
USE [master]
GO
ALTER DATABASE [BaseDatosTP06] SET  READ_WRITE 
GO
