USE [master]
GO

/****** Object:  Database [VEHICULOS_DB]    Script Date: 19/11/2021 17:25:27 ******/
CREATE DATABASE [VEHICULOS_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VEHICULOS_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\VEHICULOS_DB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'VEHICULOS_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\VEHICULOS_DB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VEHICULOS_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [VEHICULOS_DB] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [VEHICULOS_DB] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [VEHICULOS_DB] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [VEHICULOS_DB] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [VEHICULOS_DB] SET ARITHABORT OFF 
GO

ALTER DATABASE [VEHICULOS_DB] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [VEHICULOS_DB] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [VEHICULOS_DB] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [VEHICULOS_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [VEHICULOS_DB] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [VEHICULOS_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [VEHICULOS_DB] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [VEHICULOS_DB] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [VEHICULOS_DB] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [VEHICULOS_DB] SET  ENABLE_BROKER 
GO

ALTER DATABASE [VEHICULOS_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [VEHICULOS_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [VEHICULOS_DB] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [VEHICULOS_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [VEHICULOS_DB] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [VEHICULOS_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [VEHICULOS_DB] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [VEHICULOS_DB] SET RECOVERY FULL 
GO

ALTER DATABASE [VEHICULOS_DB] SET  MULTI_USER 
GO

ALTER DATABASE [VEHICULOS_DB] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [VEHICULOS_DB] SET DB_CHAINING OFF 
GO

ALTER DATABASE [VEHICULOS_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [VEHICULOS_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [VEHICULOS_DB] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [VEHICULOS_DB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [VEHICULOS_DB] SET QUERY_STORE = OFF
GO

ALTER DATABASE [VEHICULOS_DB] SET  READ_WRITE 
GO

USE [VEHICULOS_DB]
GO
/****** Object:  Table [dbo].[VEHICULOS_STOCK]    Script Date: 19/11/2021 17:40:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VEHICULOS_STOCK](
	[CHASIS] [int] NOT NULL,
	[MODELO] [varchar](20) NOT NULL,
	[COLOR] [varchar](20) NOT NULL,
	[USADO] [bit] NOT NULL,
	[ORIGEN] [varchar](20) NULL,
	[PRECIO] [int] NOT NULL,
 CONSTRAINT [PK_VEHICULOS_STOCK] PRIMARY KEY CLUSTERED 
(
	[CHASIS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VEHICULOS_VENDIDOS]    Script Date: 19/11/2021 17:40:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VEHICULOS_VENDIDOS](
	[CHASIS] [int] NOT NULL,
	[MODELO] [varchar](20) NOT NULL,
	[COLOR] [varchar](20) NOT NULL,
	[USADO] [bit] NOT NULL,
	[ORIGEN] [varchar](20) NULL,
	[PRECIO] [int] NOT NULL,
 CONSTRAINT [PK_VEHICULOS_VENDIDOS] PRIMARY KEY CLUSTERED 
(
	[CHASIS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

