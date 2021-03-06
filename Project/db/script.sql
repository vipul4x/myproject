USE [master]
GO
/****** Object:  Database [Colour_Shuffling_GP] ******/
CREATE DATABASE [Colour_Shuffling_GP] ON  PRIMARY 
( NAME = N'Colour_Shuffling_GP', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Colour_Shuffling_GP.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Colour_Shuffling_GP_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Colour_Shuffling_GP_log.LDF' , SIZE = 504KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Colour_Shuffling_GP] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Colour_Shuffling_GP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Colour_Shuffling_GP] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Colour_Shuffling_GP] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Colour_Shuffling_GP] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Colour_Shuffling_GP] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Colour_Shuffling_GP] SET ARITHABORT OFF
GO
ALTER DATABASE [Colour_Shuffling_GP] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [Colour_Shuffling_GP] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Colour_Shuffling_GP] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Colour_Shuffling_GP] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Colour_Shuffling_GP] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Colour_Shuffling_GP] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Colour_Shuffling_GP] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Colour_Shuffling_GP] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Colour_Shuffling_GP] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Colour_Shuffling_GP] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Colour_Shuffling_GP] SET  ENABLE_BROKER
GO
ALTER DATABASE [Colour_Shuffling_GP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Colour_Shuffling_GP] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Colour_Shuffling_GP] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Colour_Shuffling_GP] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Colour_Shuffling_GP] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Colour_Shuffling_GP] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [Colour_Shuffling_GP] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [Colour_Shuffling_GP] SET  READ_WRITE
GO
ALTER DATABASE [Colour_Shuffling_GP] SET RECOVERY FULL
GO
ALTER DATABASE [Colour_Shuffling_GP] SET  MULTI_USER
GO
ALTER DATABASE [Colour_Shuffling_GP] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Colour_Shuffling_GP] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'Colour_Shuffling_GP', N'ON'
GO
USE [Colour_Shuffling_GP]
GO
/****** Object:  Table [dbo].[User_Master]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User_Master](
	[User_Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NULL,
	[Name] [varchar](50) NULL,
	[Address] [varchar](1000) NULL,
	[PhoneNumber] [varchar](50) NULL,
	[EmailId] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Status] [bit] NULL,
	[CId] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[User_Master] ON
INSERT [dbo].[User_Master] ([User_Id], [Username], [Name], [Address], [PhoneNumber], [EmailId], [Password], [Status], [CId]) VALUES (1, N'admin', N'Nivruti', N'Ghansoli', N'9632587410', N'nivrutikore@gmail.com', N'12345', 1, 2)
INSERT [dbo].[User_Master] ([User_Id], [Username], [Name], [Address], [PhoneNumber], [EmailId], [Password], [Status], [CId]) VALUES (2, N'manali', N'manali', N'kk', N'9087654321', N'manali@gmail.com', N'123456', 1, 2)
INSERT [dbo].[User_Master] ([User_Id], [Username], [Name], [Address], [PhoneNumber], [EmailId], [Password], [Status], [CId]) VALUES (3, N'anshuman', N'Anshuman Rao', N'Mumai', N'9632587410', N'anshu@gmail.com', N'123456', 1, 3)
INSERT [dbo].[User_Master] ([User_Id], [Username], [Name], [Address], [PhoneNumber], [EmailId], [Password], [Status], [CId]) VALUES (4, N'chintan', N'chintan', N'c', N'9892203255', N'chintan.parekh99@gmail.com', N'chintan', 1, 5)
SET IDENTITY_INSERT [dbo].[User_Master] OFF
/****** Object:  Table [dbo].[User_Images]    : ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User_Images](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[User_Id] [int] NULL,
	[ImageBytes] [image] NULL,
	[StartX] [varchar](50) NULL,
	[StartY] [varchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ColorMaster]    1 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ColorMaster](
	[CId] [int] IDENTITY(1,1) NOT NULL,
	[Colorname] [nvarchar](100) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ColorMaster] ON
INSERT [dbo].[ColorMaster] ([CId], [Colorname]) VALUES (1, N'Indigo')
INSERT [dbo].[ColorMaster] ([CId], [Colorname]) VALUES (2, N'Red')
INSERT [dbo].[ColorMaster] ([CId], [Colorname]) VALUES (3, N'Blue')
INSERT [dbo].[ColorMaster] ([CId], [Colorname]) VALUES (4, N'Green')
INSERT [dbo].[ColorMaster] ([CId], [Colorname]) VALUES (5, N'Orange')
INSERT [dbo].[ColorMaster] ([CId], [Colorname]) VALUES (6, N'Violet')
SET IDENTITY_INSERT [dbo].[ColorMaster] OFF
