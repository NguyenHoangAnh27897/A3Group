USE [master]
GO
/****** Object:  Database [a3group]    Script Date: 11/25/2018 10:56:01 PM ******/
CREATE DATABASE [a3group]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'a3group', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\a3group.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'a3group_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\a3group_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [a3group] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [a3group].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [a3group] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [a3group] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [a3group] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [a3group] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [a3group] SET ARITHABORT OFF 
GO
ALTER DATABASE [a3group] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [a3group] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [a3group] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [a3group] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [a3group] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [a3group] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [a3group] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [a3group] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [a3group] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [a3group] SET  DISABLE_BROKER 
GO
ALTER DATABASE [a3group] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [a3group] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [a3group] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [a3group] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [a3group] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [a3group] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [a3group] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [a3group] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [a3group] SET  MULTI_USER 
GO
ALTER DATABASE [a3group] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [a3group] SET DB_CHAINING OFF 
GO
ALTER DATABASE [a3group] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [a3group] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [a3group] SET DELAYED_DURABILITY = DISABLED 
GO
USE [a3group]
GO
/****** Object:  Table [dbo].[A3Group_About]    Script Date: 11/25/2018 10:56:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[A3Group_About](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MainTitle] [nvarchar](30) NULL,
	[MainDescription] [nvarchar](500) NULL,
	[SubTitle1] [nvarchar](50) NULL,
	[SubDescription1] [nvarchar](500) NULL,
	[SubTitle2] [nvarchar](50) NULL,
	[SubDescription2] [nvarchar](500) NULL,
	[SubTitle3] [nvarchar](50) NULL,
	[SubDescription3] [nvarchar](500) NULL,
	[SubTitle4] [nvarchar](50) NULL,
	[SubDescription4] [nvarchar](500) NULL,
 CONSTRAINT [PK_A3Group_MainAbout] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[A3Group_Blogs]    Script Date: 11/25/2018 10:56:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[A3Group_Blogs](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MainTitle] [nvarchar](25) NULL,
	[MainDescription] [nvarchar](500) NULL,
	[Images] [nvarchar](300) NULL,
	[Works] [nvarchar](50) NULL,
	[SubTitle] [nvarchar](50) NULL,
 CONSTRAINT [PK_A3Group_Blogs] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[A3Group_Contact]    Script Date: 11/25/2018 10:56:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[A3Group_Contact](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MainTitle] [nvarchar](25) NULL,
	[MainDescription] [nvarchar](500) NULL,
	[Address] [nvarchar](150) NULL,
	[Phone] [nvarchar](150) NULL,
	[Email] [nvarchar](150) NULL,
 CONSTRAINT [PK_A3Group_Contact] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[A3Group_Differences]    Script Date: 11/25/2018 10:56:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[A3Group_Differences](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MainTitle] [nvarchar](50) NULL,
	[MainDescription] [nvarchar](500) NULL,
	[Title1] [nvarchar](20) NULL,
	[Description1] [nvarchar](500) NULL,
	[Title2] [nvarchar](20) NULL,
	[Description2] [nvarchar](500) NULL,
	[Title3] [nvarchar](20) NULL,
	[Description3] [nvarchar](500) NULL,
	[Title4] [nvarchar](20) NULL,
	[Description4] [nvarchar](500) NULL,
 CONSTRAINT [PK_A3Group_Differences] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[A3Group_Features]    Script Date: 11/25/2018 10:56:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[A3Group_Features](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MainTitle] [nvarchar](100) NULL,
	[MainDescription] [nvarchar](500) NULL,
	[SubTitle] [nvarchar](100) NULL,
	[SubDescription] [nvarchar](500) NULL,
	[Strengths] [nvarchar](max) NULL,
	[Image] [nvarchar](100) NULL,
 CONSTRAINT [PK_A3Group_Feature] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[A3Group_Prices]    Script Date: 11/25/2018 10:56:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[A3Group_Prices](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MainTitle] [nvarchar](25) NULL,
	[MainDescription] [nvarchar](500) NULL,
	[SubTitle] [nvarchar](25) NULL,
	[Prices] [nvarchar](20) NULL,
	[Ultilities] [nvarchar](500) NULL,
 CONSTRAINT [PK_A3Group_Prices] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[A3Group_Quotes]    Script Date: 11/25/2018 10:56:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[A3Group_Quotes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Quote] [nvarchar](500) NULL,
	[Name] [nvarchar](50) NULL,
	[Roles] [nvarchar](50) NULL,
 CONSTRAINT [PK_A3Group_Quotes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[A3Group_Services]    Script Date: 11/25/2018 10:56:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[A3Group_Services](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MainTitle] [nvarchar](50) NULL,
	[MainDescription] [nvarchar](500) NULL,
	[SubTitle1] [nvarchar](30) NULL,
	[SubDescription1] [nvarchar](200) NULL,
	[SubTitle2] [nvarchar](30) NULL,
	[SubDescription2] [nvarchar](200) NULL,
	[SubTitle3] [nvarchar](30) NULL,
	[SubDescription3] [nvarchar](200) NULL,
	[SubTitle4] [nvarchar](30) NULL,
	[SubDescription4] [nvarchar](200) NULL,
	[SubTitle5] [nvarchar](30) NULL,
	[SubDescription5] [nvarchar](200) NULL,
	[SubTitle6] [nvarchar](30) NULL,
	[SubDescription6] [nvarchar](200) NULL,
 CONSTRAINT [PK_A3Group_Services] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[A3Group_Sliders]    Script Date: 11/25/2018 10:56:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[A3Group_Sliders](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](30) NULL,
	[Slogan] [nvarchar](30) NULL,
	[Description] [nvarchar](250) NULL,
	[Video] [nvarchar](150) NULL,
 CONSTRAINT [PK_A3Group_Slider] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[A3Group_Team]    Script Date: 11/25/2018 10:56:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[A3Group_Team](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MainTitle] [nvarchar](25) NULL,
	[MainDescription] [nvarchar](500) NULL,
	[Images] [nvarchar](300) NULL,
	[Names] [nvarchar](50) NULL,
	[Roles] [nvarchar](50) NULL,
 CONSTRAINT [PK_A3Group_Team] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[A3Group_Works]    Script Date: 11/25/2018 10:56:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[A3Group_Works](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MainTitle] [nvarchar](25) NULL,
	[MainDescription] [nvarchar](500) NULL,
	[Images] [nvarchar](300) NULL,
	[Name] [nvarchar](100) NULL,
 CONSTRAINT [PK_A3Group_Works] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[A3Group_About] ON 

INSERT [dbo].[A3Group_About] ([id], [MainTitle], [MainDescription], [SubTitle1], [SubDescription1], [SubTitle2], [SubDescription2], [SubTitle3], [SubDescription3], [SubTitle4], [SubDescription4]) VALUES (1, N'Chào mừng bạn đến với A3 Group', N'Chào mừng bạn đến với A3 Group', N'Công nghệ phần cứng', N'Bao gồm kiểm tra, nghiên cứu và quản lý việc cài đặt các linh kiện phần cứng của máy tính đảm bảo tính hiệu quả, an toàn để đảm bảo hệ thống máy tính hoạt động nhanh nhất và hiệu quả cao nhất.', N'Công nghệ phần mềm', N'Bao gồm làm công việc nghiên cứu, thiết kế, phát triển và duy trì hệ thống phần mềm, đồng thời phát triển phần cứng cho các mục đích y tế, khoa học và công nghiệp.

', N'Cở sở dữ liệu', N'Là sự kết hợp giữa phần cứng, phần mềm và mạng truyền thông, nhằm thu thập, tạo và phân phối các dữ liệu thông tin và tri thức hữu ích trong một tổ chức cụ thể.', N'Mạng máy tính và truyền thông', N'Với vai trò thiết kế và xây dựng các hệ thống mạng đạt tiêu chuẩn cao cho doanh nghiệp và tổ chức ứng dụng công nghệ thông tin, xây dựng và bảo trì hệ thống mạng.')
SET IDENTITY_INSERT [dbo].[A3Group_About] OFF
SET IDENTITY_INSERT [dbo].[A3Group_Blogs] ON 

INSERT [dbo].[A3Group_Blogs] ([id], [MainTitle], [MainDescription], [Images], [Works], [SubTitle]) VALUES (1, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[A3Group_Blogs] OFF
SET IDENTITY_INSERT [dbo].[A3Group_Contact] ON 

INSERT [dbo].[A3Group_Contact] ([id], [MainTitle], [MainDescription], [Address], [Phone], [Email]) VALUES (1, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[A3Group_Contact] OFF
SET IDENTITY_INSERT [dbo].[A3Group_Differences] ON 

INSERT [dbo].[A3Group_Differences] ([id], [MainTitle], [MainDescription], [Title1], [Description1], [Title2], [Description2], [Title3], [Description3], [Title4], [Description4]) VALUES (1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[A3Group_Differences] OFF
SET IDENTITY_INSERT [dbo].[A3Group_Features] ON 

INSERT [dbo].[A3Group_Features] ([id], [MainTitle], [MainDescription], [SubTitle], [SubDescription], [Strengths], [Image]) VALUES (1, N'Đôi nét về A3 Solution', N'A3 Group được thành lập năm 2018 bởi một nhóm các kỹ sư công nghệ thông tin nhằm tạo ra một liên minh về IT, tập hợp những mảng chính của công nghệ thông tin để phát triển và biến nó thành mô hình doanh nghiệp lớn mạnh. bao gồm các mảng tích hợp', N'Chúng tôi là IT', N'', NULL, NULL)
SET IDENTITY_INSERT [dbo].[A3Group_Features] OFF
SET IDENTITY_INSERT [dbo].[A3Group_Prices] ON 

INSERT [dbo].[A3Group_Prices] ([id], [MainTitle], [MainDescription], [SubTitle], [Prices], [Ultilities]) VALUES (1, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[A3Group_Prices] OFF
SET IDENTITY_INSERT [dbo].[A3Group_Quotes] ON 

INSERT [dbo].[A3Group_Quotes] ([id], [Quote], [Name], [Roles]) VALUES (1, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[A3Group_Quotes] OFF
SET IDENTITY_INSERT [dbo].[A3Group_Services] ON 

INSERT [dbo].[A3Group_Services] ([id], [MainTitle], [MainDescription], [SubTitle1], [SubDescription1], [SubTitle2], [SubDescription2], [SubTitle3], [SubDescription3], [SubTitle4], [SubDescription4], [SubTitle5], [SubDescription5], [SubTitle6], [SubDescription6]) VALUES (1, N'c', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[A3Group_Services] OFF
SET IDENTITY_INSERT [dbo].[A3Group_Sliders] ON 

INSERT [dbo].[A3Group_Sliders] ([id], [Title], [Slogan], [Description], [Video]) VALUES (1, N'Chúng tôi là A3 Solution', N'Sáng tạo là thành công', N'Lấy khách hàng làm trung tâm, đó cách mà chúng tôi tiếp cận công nghệ', N'')
SET IDENTITY_INSERT [dbo].[A3Group_Sliders] OFF
SET IDENTITY_INSERT [dbo].[A3Group_Team] ON 

INSERT [dbo].[A3Group_Team] ([id], [MainTitle], [MainDescription], [Images], [Names], [Roles]) VALUES (1, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[A3Group_Team] OFF
SET IDENTITY_INSERT [dbo].[A3Group_Works] ON 

INSERT [dbo].[A3Group_Works] ([id], [MainTitle], [MainDescription], [Images], [Name]) VALUES (1, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[A3Group_Works] OFF
USE [master]
GO
ALTER DATABASE [a3group] SET  READ_WRITE 
GO
