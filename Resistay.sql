USE [Resistay]
GO

/****** Object:  Table [dbo].[Annoucement]    Script Date: 5/17/2024 16:44:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Annoucement](
	[AnnoucemntId] [int] IDENTITY(1,1) NOT NULL,
	[Details] [varchar](max) NOT NULL,
	[Date] [varchar](max) NULL,
 CONSTRAINT [PK_Annoucement] PRIMARY KEY CLUSTERED 
(
	[AnnoucemntId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Complain]    Script Date: 5/17/2024 16:44:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Complain](
	[ComplainId] [int] IDENTITY(1,1) NOT NULL,
	[Detail] [varchar](max) NOT NULL,
	[Date] [varchar](max) NOT NULL,
	[StudentName] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Complain] PRIMARY KEY CLUSTERED 
(
	[ComplainId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Fees]    Script Date: 5/17/2024 16:44:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Fees](
	[ChallanId] [int] IDENTITY(1,1) NOT NULL,
	[StudentFees] [int] NOT NULL,
	[DueDate] [varchar](max) NOT NULL,
	[PaymentDate] [varchar](max) NULL,
	[StudentName] [varchar](max) NOT NULL,
	[ChallanNo] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Fees] PRIMARY KEY CLUSTERED 
(
	[ChallanId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Hostel]    Script Date: 5/17/2024 16:44:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Hostel](
	[HostelId] [int] IDENTITY(1,1) NOT NULL,
	[HostelName] [varchar](max) NOT NULL,
	[HostelStatus] [varchar](max) NOT NULL,
	[HostelType] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Hostel] PRIMARY KEY CLUSTERED 
(
	[HostelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/****** Object:  Table [dbo].[MessAttendance]    Script Date: 5/17/2024 16:44:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MessAttendance](
	[AttendanceId] [int] IDENTITY(1,1) NOT NULL,
	[Date] [varchar](max) NOT NULL,
	[StudentName] [varchar](max) NOT NULL,
	[Item] [varchar](max) NOT NULL,
 CONSTRAINT [PK_MessAttendance] PRIMARY KEY CLUSTERED 
(
	[AttendanceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/****** Object:  Table [dbo].[MessFood]    Script Date: 5/17/2024 16:44:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MessFood](
	[FoodId] [int] NOT NULL,
	[Price] [float] NOT NULL,
	[Item] [varchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Resident]    Script Date: 5/17/2024 16:44:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Resident](
	[ResidentId] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](max) NOT NULL,
	[Password] [varchar](max) NOT NULL,
	[Age] [int] NOT NULL,
	[Gender] [varchar](max) NOT NULL,
	[Cnic] [varchar](max) NOT NULL,
	[Role] [varchar](max) NOT NULL,
	[HostelName] [varchar](max) NULL,
 CONSTRAINT [PK_Resident] PRIMARY KEY CLUSTERED 
(
	[ResidentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Room]    Script Date: 5/17/2024 16:44:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Room](
	[RoomId] [int] IDENTITY(1,1) NOT NULL,
	[RoomNumber] [int] NOT NULL,
	[RoomStatus] [varchar](max) NOT NULL,
	[HostelName] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
(
	[RoomId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Rt]    Script Date: 5/17/2024 16:44:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Rt](
	[RtId] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](max) NOT NULL,
	[Password] [nchar](10) NOT NULL,
	[Age] [int] NOT NULL,
	[Gender] [varchar](max) NOT NULL,
	[Cnic] [varchar](max) NOT NULL,
	[Role] [varchar](max) NOT NULL,
	[HostelName] [varchar](max) NOT NULL,
	[PhoneNo] [varchar](max) NOT NULL,
	[ResidentId] [int] NOT NULL,
 CONSTRAINT [PK_Rt] PRIMARY KEY CLUSTERED 
(
	[RtId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Rules]    Script Date: 5/17/2024 16:44:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Rules](
	[RulesId] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](max) NOT NULL,
	[Date] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Rules] PRIMARY KEY CLUSTERED 
(
	[RulesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Salary]    Script Date: 5/17/2024 16:44:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Salary](
	[CheckId] [int] IDENTITY(1,1) NOT NULL,
	[CheckAmount] [int] NOT NULL,
	[CheckNumber] [varchar](max) NOT NULL,
	[IssueDate] [varchar](max) NOT NULL,
	[RecievedDate] [varchar](max) NULL,
	[RtName] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Salary] PRIMARY KEY CLUSTERED 
(
	[CheckId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Student]    Script Date: 5/17/2024 16:44:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Student](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](max) NOT NULL,
	[Password] [varchar](max) NOT NULL,
	[Age] [int] NOT NULL,
	[Gender] [varchar](max) NOT NULL,
	[Cnic] [varchar](max) NOT NULL,
	[Role] [varchar](max) NOT NULL,
	[HostelName] [varchar](max) NULL,
	[RoomNumber] [int] NULL,
	[StudentStatus] [varchar](max) NOT NULL,
	[ResidentId] [int] NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Warden]    Script Date: 5/17/2024 16:44:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Warden](
	[WardenName] [varchar](max) NOT NULL,
	[wardenId] [int] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


