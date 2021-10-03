USE [master]
GO
/****** Object:  Database [COASAdate]    Script Date: 3/10/2021 00:52:54 ******/
CREATE DATABASE [COASAdate]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'COASAdate', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\COASAdate.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'COASAdate_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\COASAdate_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [COASAdate] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [COASAdate].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [COASAdate] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [COASAdate] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [COASAdate] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [COASAdate] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [COASAdate] SET ARITHABORT OFF 
GO
ALTER DATABASE [COASAdate] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [COASAdate] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [COASAdate] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [COASAdate] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [COASAdate] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [COASAdate] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [COASAdate] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [COASAdate] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [COASAdate] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [COASAdate] SET  ENABLE_BROKER 
GO
ALTER DATABASE [COASAdate] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [COASAdate] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [COASAdate] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [COASAdate] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [COASAdate] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [COASAdate] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [COASAdate] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [COASAdate] SET RECOVERY FULL 
GO
ALTER DATABASE [COASAdate] SET  MULTI_USER 
GO
ALTER DATABASE [COASAdate] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [COASAdate] SET DB_CHAINING OFF 
GO
ALTER DATABASE [COASAdate] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [COASAdate] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [COASAdate] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [COASAdate] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'COASAdate', N'ON'
GO
ALTER DATABASE [COASAdate] SET QUERY_STORE = OFF
GO
USE [COASAdate]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 3/10/2021 00:52:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Telefono] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 
GO
INSERT [dbo].[Usuarios] ([id], [UserName], [Nombre], [Email], [Telefono]) VALUES (1, N'firstUser', N'Natalia Natalia', N'natalia@hotmail.com', N'12345678')
GO
INSERT [dbo].[Usuarios] ([id], [UserName], [Nombre], [Email], [Telefono]) VALUES (2, N'ignacio1998', N'José Luis', N'joseignacio439@gmail.com', N'1170969187')
GO
INSERT [dbo].[Usuarios] ([id], [UserName], [Nombre], [Email], [Telefono]) VALUES (4, N'usuarioEditadoOk', N'Anoni Mato', N'prueba@gmail.com', N'')
GO
INSERT [dbo].[Usuarios] ([id], [UserName], [Nombre], [Email], [Telefono]) VALUES (5, N'testFinal', N'Pedro Raul', N'pedri@outlook.com.ar', N'+549 1120304050')
GO
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
USE [master]
GO
ALTER DATABASE [COASAdate] SET  READ_WRITE 
GO