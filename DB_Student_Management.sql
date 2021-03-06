USE [master]
GO
/****** Object:  Database [praktika]    Script Date: 20/12/2020 22:43:58 ******/
CREATE DATABASE [praktika]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'praktika', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\praktika.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'praktika_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\praktika_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [praktika] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [praktika].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [praktika] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [praktika] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [praktika] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [praktika] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [praktika] SET ARITHABORT OFF 
GO
ALTER DATABASE [praktika] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [praktika] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [praktika] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [praktika] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [praktika] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [praktika] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [praktika] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [praktika] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [praktika] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [praktika] SET  DISABLE_BROKER 
GO
ALTER DATABASE [praktika] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [praktika] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [praktika] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [praktika] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [praktika] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [praktika] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [praktika] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [praktika] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [praktika] SET  MULTI_USER 
GO
ALTER DATABASE [praktika] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [praktika] SET DB_CHAINING OFF 
GO
ALTER DATABASE [praktika] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [praktika] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [praktika] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [praktika] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [praktika] SET QUERY_STORE = OFF
GO
USE [praktika]
GO
/****** Object:  Table [dbo].[Grade]    Script Date: 20/12/2020 22:43:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grade](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Subject_id] [int] NOT NULL,
	[Student_id] [int] NOT NULL,
	[Grades] [int] NULL,
	[Group_id] [int] NOT NULL,
 CONSTRAINT [PK_Grade] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Group]    Script Date: 20/12/2020 22:43:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Group](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Groups] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 20/12/2020 22:43:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subject](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Group_id] [int] NULL,
	[Teacher_id] [int] NULL,
 CONSTRAINT [PK_Subject] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 20/12/2020 22:43:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[surname] [nvarchar](50) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[user_Type] [nvarchar](50) NOT NULL,
	[group_id] [int] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Grade] ON 

INSERT [dbo].[Grade] ([id], [Subject_id], [Student_id], [Grades], [Group_id]) VALUES (1, 36, 4, 10, 1)
SET IDENTITY_INSERT [dbo].[Grade] OFF
GO
SET IDENTITY_INSERT [dbo].[Group] ON 

INSERT [dbo].[Group] ([id], [Name]) VALUES (1, N'PI19D')
INSERT [dbo].[Group] ([id], [Name]) VALUES (2, N'PI19A')
INSERT [dbo].[Group] ([id], [Name]) VALUES (3, N'PI19B')
INSERT [dbo].[Group] ([id], [Name]) VALUES (4, N'PI19C')
SET IDENTITY_INSERT [dbo].[Group] OFF
GO
SET IDENTITY_INSERT [dbo].[Subject] ON 

INSERT [dbo].[Subject] ([id], [Name], [Group_id], [Teacher_id]) VALUES (36, N'Matematika', 1, 5)
INSERT [dbo].[Subject] ([id], [Name], [Group_id], [Teacher_id]) VALUES (37, N'Anglu', NULL, NULL)
INSERT [dbo].[Subject] ([id], [Name], [Group_id], [Teacher_id]) VALUES (38, N'Objektinis programavimas', 3, 5)
INSERT [dbo].[Subject] ([id], [Name], [Group_id], [Teacher_id]) VALUES (39, N'Kompiuterine grafika', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Subject] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([id], [name], [surname], [username], [password], [user_Type], [group_id]) VALUES (2, N'ADMIN', N'ADMIN', N'root', N'root', N'Admin', NULL)
INSERT [dbo].[Users] ([id], [name], [surname], [username], [password], [user_Type], [group_id]) VALUES (4, N'Herman', N'Pantiuchov', N'Herman', N'Pantiuchov', N'User', 1)
INSERT [dbo].[Users] ([id], [name], [surname], [username], [password], [user_Type], [group_id]) VALUES (5, N'Valentina', N'Kursokaite', N'Valentina', N'Kursokaite', N'Teacher', NULL)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Grade]  WITH CHECK ADD  CONSTRAINT [FK_Grade_Groups] FOREIGN KEY([Group_id])
REFERENCES [dbo].[Group] ([id])
GO
ALTER TABLE [dbo].[Grade] CHECK CONSTRAINT [FK_Grade_Groups]
GO
ALTER TABLE [dbo].[Grade]  WITH CHECK ADD  CONSTRAINT [FK_Grade_Subject] FOREIGN KEY([Subject_id])
REFERENCES [dbo].[Subject] ([id])
GO
ALTER TABLE [dbo].[Grade] CHECK CONSTRAINT [FK_Grade_Subject]
GO
ALTER TABLE [dbo].[Grade]  WITH CHECK ADD  CONSTRAINT [FK_Grade_User] FOREIGN KEY([Student_id])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[Grade] CHECK CONSTRAINT [FK_Grade_User]
GO
ALTER TABLE [dbo].[Subject]  WITH CHECK ADD  CONSTRAINT [FK_Subject_Groups] FOREIGN KEY([Group_id])
REFERENCES [dbo].[Group] ([id])
GO
ALTER TABLE [dbo].[Subject] CHECK CONSTRAINT [FK_Subject_Groups]
GO
ALTER TABLE [dbo].[Subject]  WITH CHECK ADD  CONSTRAINT [FK_Subject_User] FOREIGN KEY([Teacher_id])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[Subject] CHECK CONSTRAINT [FK_Subject_User]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_User_Groups] FOREIGN KEY([group_id])
REFERENCES [dbo].[Group] ([id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_User_Groups]
GO
USE [master]
GO
ALTER DATABASE [praktika] SET  READ_WRITE 
GO
