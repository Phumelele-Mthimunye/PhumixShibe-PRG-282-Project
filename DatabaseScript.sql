USE [master]
GO

/****** Object:  Database [FlightSimulation]    Script Date: 2020/10/02 13:21:37 ******/
CREATE DATABASE [FlightSimulation]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FlightSimulation', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\FlightSimulation.mdf' , SIZE = 7168KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'FlightSimulation_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\FlightSimulation_log.ldf' , SIZE = 6912KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FlightSimulation].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [FlightSimulation] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [FlightSimulation] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [FlightSimulation] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [FlightSimulation] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [FlightSimulation] SET ARITHABORT OFF 
GO

ALTER DATABASE [FlightSimulation] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [FlightSimulation] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [FlightSimulation] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [FlightSimulation] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [FlightSimulation] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [FlightSimulation] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [FlightSimulation] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [FlightSimulation] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [FlightSimulation] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [FlightSimulation] SET  DISABLE_BROKER 
GO

ALTER DATABASE [FlightSimulation] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [FlightSimulation] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [FlightSimulation] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [FlightSimulation] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [FlightSimulation] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [FlightSimulation] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [FlightSimulation] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [FlightSimulation] SET RECOVERY FULL 
GO

ALTER DATABASE [FlightSimulation] SET  MULTI_USER 
GO

ALTER DATABASE [FlightSimulation] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [FlightSimulation] SET DB_CHAINING OFF 
GO

ALTER DATABASE [FlightSimulation] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [FlightSimulation] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [FlightSimulation] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [FlightSimulation] SET QUERY_STORE = OFF
GO

ALTER DATABASE [FlightSimulation] SET  READ_WRITE 
GO


USE [FlightSimulation]
GO

/****** Object:  Table [dbo].[Users]    Script Date: 2020/10/02 13:22:39 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Users]') AND type in (N'U'))
DROP TABLE [dbo].[Users]
GO

USE [FlightSimulation]
GO

/****** Object:  Table [dbo].[Bomber]    Script Date: 2020/10/02 13:21:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Bomber](
	[BomberID] [int] IDENTITY(1,1) NOT NULL,
	[BomberName] [nchar](20) NULL,
	[BomberFuelSize] [int] NULL,
	[BomberInventorySize] [int] NULL,
	[BomberImage] [image] NULL,
 CONSTRAINT [PK_Bomber] PRIMARY KEY CLUSTERED 
(
	[BomberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

USE [FlightSimulation]
GO

/****** Object:  Table [dbo].[Objects]    Script Date: 2020/10/02 13:22:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Objects](
	[ObjectID] [int] IDENTITY(1,1) NOT NULL,
	[ObjectName] [nchar](20) NULL,
	[ObjectScore] [int] NULL,
	[ObjectImage] [image] NULL,
 CONSTRAINT [PK_Objects] PRIMARY KEY CLUSTERED 
(
	[ObjectID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

USE [FlightSimulation]
GO

/****** Object:  Table [dbo].[Plane]    Script Date: 2020/10/02 13:22:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Plane](
	[PlaneID] [int] IDENTITY(1,1) NOT NULL,
	[PlaneBMP] [image] NULL,
	[PlaneName] [nchar](30) NULL,
	[FuelCapacity] [int] NULL,
 CONSTRAINT [PK_Plane] PRIMARY KEY CLUSTERED 
(
	[PlaneID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

USE [FlightSimulation]
GO

/****** Object:  Table [dbo].[Report]    Script Date: 2020/10/02 13:22:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Report](
	[ReportNumber] [int] IDENTITY(1,1) NOT NULL,
	[DamagePercentage] [int] NULL,
	[StrikeTime] [smalldatetime] NULL,
	[BuildingsStruck] [nchar](200) NULL,
	[FuelUsage] [int] NULL,
	[InventoryBefore] [nchar](10) NULL,
	[InventoryUsed] [nchar](10) NULL,
	[FlightDuration] [int] NULL,
	[AverageSpeed] [int] NULL,
	[DistanceTraveled] [int] NULL,
 CONSTRAINT [PK_Report] PRIMARY KEY CLUSTERED 
(
	[ReportNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

