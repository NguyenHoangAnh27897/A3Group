USE [a3group]
GO
/****** Object:  Table [dbo].[A3Group_About]    Script Date: 11/26/2018 2:46:38 AM ******/
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
/****** Object:  Table [dbo].[A3Group_Blogs]    Script Date: 11/26/2018 2:46:38 AM ******/
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
/****** Object:  Table [dbo].[A3Group_Contact]    Script Date: 11/26/2018 2:46:38 AM ******/
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
/****** Object:  Table [dbo].[A3Group_Differences]    Script Date: 11/26/2018 2:46:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[A3Group_Differences](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MainTitle] [nvarchar](50) NULL,
	[MainDescription] [nvarchar](500) NULL,
	[SubTitle1] [nvarchar](50) NULL,
	[SubDescription1] [nvarchar](500) NULL,
	[Image1] [nvarchar](100) NULL,
	[SubTitle2] [nvarchar](50) NULL,
	[SubDescription2] [nvarchar](500) NULL,
	[Image2] [nvarchar](100) NULL,
	[SubTitle3] [nvarchar](50) NULL,
	[SubDescription3] [nvarchar](500) NULL,
	[Image3] [nvarchar](100) NULL,
	[SubTitle4] [nvarchar](50) NULL,
	[SubDescription4] [nvarchar](500) NULL,
	[Image4] [nvarchar](100) NULL,
 CONSTRAINT [PK_A3Group_Differences] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[A3Group_Features]    Script Date: 11/26/2018 2:46:38 AM ******/
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
/****** Object:  Table [dbo].[A3Group_Prices]    Script Date: 11/26/2018 2:46:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[A3Group_Prices](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MainTitle] [nvarchar](25) NULL,
	[MainDescription] [nvarchar](500) NULL,
	[SubTitle1] [nvarchar](25) NULL,
	[Prices1] [int] NULL,
	[Description1] [nvarchar](500) NULL,
	[SubTitle2] [nvarchar](25) NULL,
	[Prices2] [int] NULL,
	[Description2] [nvarchar](500) NULL,
	[SubTitle3] [nvarchar](25) NULL,
	[Prices3] [int] NULL,
	[Description3] [nvarchar](500) NULL,
 CONSTRAINT [PK_A3Group_Prices] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[A3Group_Quotes]    Script Date: 11/26/2018 2:46:38 AM ******/
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
/****** Object:  Table [dbo].[A3Group_Services]    Script Date: 11/26/2018 2:46:38 AM ******/
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
/****** Object:  Table [dbo].[A3Group_Sliders]    Script Date: 11/26/2018 2:46:38 AM ******/
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
/****** Object:  Table [dbo].[A3Group_Team]    Script Date: 11/26/2018 2:46:38 AM ******/
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
/****** Object:  Table [dbo].[A3Group_Works]    Script Date: 11/26/2018 2:46:38 AM ******/
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

INSERT [dbo].[A3Group_Differences] ([id], [MainTitle], [MainDescription], [SubTitle1], [SubDescription1], [Image1], [SubTitle2], [SubDescription2], [Image2], [SubTitle3], [SubDescription3], [Image3], [SubTitle4], [SubDescription4], [Image4]) VALUES (1, N'Tại sao chúng tôi lại khác biệt', N'Vì chúng tôi mang lại sự khác biệt từ những điều đơn giản cốt lõi', N'Làm việc chuyên nghiệp', N'A3Group sở hữu những thành viên, nhân viên luôn tận tâm, nhiệt huyết để đem lại những trải nghiệm làm việc tốt nhất cho khách hàng cũng như đem cảm xúc thổi vào cho những sản phẩm công nghệ cứng nhắc.', NULL, N'Nhanh chóng, linh hoạt', N'Với các nhân viên đều nằm trong lứa tuổi trẻ, năng động, đầy nhiệt huyết A3Group sẽ đem đến cho khách hàng sự nhanh chóng trong mọi khâu hoạt động, khả năng linh hoạt thích ứng trong mọi trường hợp.', NULL, N'Nhân viên kinh nghiệm', N'Các nhân viên ở AGroup đều sẽ có những bài test để kiểm tra kĩ năng, kiến thức, cách thưc hoạt động độc lập, hoạt động nhóm cũng như tư duy giải quyết vấn đề nên A3Group tự tin về mặt kinh nghiệm đối với những nhân viên trực thuộc công ty', NULL, N'Dịch vụ khách hàng tốt hơn', N'Với phương châm sự hài lòng của khách hàng là cách mà công ty tiếp cận đến công nghê, A3Group luôn không ngừng cải tiến, nâng cao các quy trình hoạt động để đem lại lới ích tốt nhất cho khách hàng. Đồng thời cũng đặt khách hàng làm trung tâm trong quá trình làm việc để khách hàng có được sự trải nghiệm tốt nhất ở A3Group', NULL)
SET IDENTITY_INSERT [dbo].[A3Group_Differences] OFF
SET IDENTITY_INSERT [dbo].[A3Group_Features] ON 

INSERT [dbo].[A3Group_Features] ([id], [MainTitle], [MainDescription], [SubTitle], [SubDescription], [Strengths], [Image]) VALUES (1, N'Đôi nét về A3 Solution', N'A3 Group được thành lập năm 2018 bởi một nhóm các kỹ sư công nghệ thông tin nhằm tạo ra một liên minh về IT, tập hợp những mảng chính của công nghệ thông tin để phát triển và biến nó thành mô hình doanh nghiệp lớn mạnh. bao gồm các mảng tích hợp', N'Chúng tôi là IT', N'Có rất nhiều loại hình công việc trong ngành công nghệ thông tin từ nhân viên kinh doanh đến thiết kế web, tùy thuộc vào các điểm mạnh và sự am hiểu mà chúng tôi tìm được cho mình nhưng đối sách phù hợp. Sau đây là một vài lựa chọn tiêu biểu', NULL, NULL)
SET IDENTITY_INSERT [dbo].[A3Group_Features] OFF
SET IDENTITY_INSERT [dbo].[A3Group_Prices] ON 

INSERT [dbo].[A3Group_Prices] ([id], [MainTitle], [MainDescription], [SubTitle1], [Prices1], [Description1], [SubTitle2], [Prices2], [Description2], [SubTitle3], [Prices3], [Description3]) VALUES (1, N'Chi phí của chúng tôi', N'Bảng chi tiết cho các gói thanh toán tiện lợi ở A3Group', N'Cá nhân', 44, N'', N'Bình thường', 59, N'', N'Doanh nghiệp', 69, N'')
SET IDENTITY_INSERT [dbo].[A3Group_Prices] OFF
SET IDENTITY_INSERT [dbo].[A3Group_Quotes] ON 

INSERT [dbo].[A3Group_Quotes] ([id], [Quote], [Name], [Roles]) VALUES (1, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[A3Group_Quotes] OFF
SET IDENTITY_INSERT [dbo].[A3Group_Services] ON 

INSERT [dbo].[A3Group_Services] ([id], [MainTitle], [MainDescription], [SubTitle1], [SubDescription1], [SubTitle2], [SubDescription2], [SubTitle3], [SubDescription3], [SubTitle4], [SubDescription4], [SubTitle5], [SubDescription5], [SubTitle6], [SubDescription6]) VALUES (1, N'Dịch vụ của chúng tôi', N'Công nghệ thông tin đã giúp thay đổi thế giới, và là những người tiếp nhận ngọn lửa ấy chúng tôi muốn mang đến cho người dùng những trải nghiệm tuyệt vời nhất về công nghệ không chỉ giới hạn tại một dịch vụ bất kỳ mà là tổng thể của các dịch vụ, hổ trợ cho người dùng tốt nhất về tất cả các mặt của công nghệ thông tin trong doanh nghiệp, dịch vụ kinh doanh và đời sống.', N'Cho thuê IT', N'Với đội ngũ nhân viên chuyên ngành IT với kinh nghiệm đi làm lâu năm sẽ đáp ứng được những nhu cầu mà khách hàng cần khi đến thuê nhân viên của chúng tôi.', N'Thiết kế website', N'A3Group luôn mong muốn đem cảm xúc đến cho những sản phẩm công nghệ mà chúng tôi tạo ra nên từ thiết kế website là 1 trong những lĩnh vực mà chúng tôi quan tâm nhiều nhất.', N'Thiết kế phần mềm ', N'Để đáp ứng được nhu cầu công nghệ ngày càng cao, A3Group đã phát triển mạnh mẽ hơn ở mảng thiết kế phần mềm đem lại khả năng sử dụng tốt nhất cho khách hàng.', N'Thiết kế hệ thống', N'Hỗ trợ thiết kế, xây dựng, đi dây cũng như bảo trì toàn bộ hệ thống của khách hàng 1 cách tận tình và chu đáo, đảm bảo khách hàng có không gian hoạt động và trải nghiệm tốt nhất', N'Domain & Hosting', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt.', N'Thiết kế đồ họa', N'Những mẫu thiết kế độc đáo, đầy màu sắc thể hiện được cảm xúc cũng như những chất riêng của A3Group')
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
