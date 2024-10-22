USE [Du_An]
GO
/****** Object:  Table [dbo].[diem]    Script Date: 5/17/2024 9:10:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[diem](
	[id] [int] NOT NULL,
	[masv] [nchar](10) NULL,
	[tensv] [nvarchar](max) NULL,
	[monhoc] [nvarchar](max) NULL,
	[lop] [nvarchar](max) NULL,
	[diem1] [float] NULL,
	[diem2] [float] NULL,
	[diem3] [float] NULL,
	[diemtb] [float] NULL,
	[ketqua] [nvarchar](50) NULL,
 CONSTRAINT [PK_diem] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[giangvien]    Script Date: 5/17/2024 9:10:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[giangvien](
	[anh] [image] NULL,
	[magv] [nchar](10) NOT NULL,
	[tengv] [nvarchar](50) NULL,
	[sdt] [nvarchar](50) NULL,
	[ngaysinh] [date] NULL,
	[tenkhoa] [nvarchar](50) NULL,
	[monday] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[matkhau] [nvarchar](50) NULL,
 CONSTRAINT [PK_giangvien] PRIMARY KEY CLUSTERED 
(
	[magv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hoc_phan]    Script Date: 5/17/2024 9:10:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hoc_phan](
	[mahp] [nchar](10) NOT NULL,
	[tenhp] [nvarchar](50) NULL,
	[namhoc] [nchar](10) NULL,
	[sotinchi] [int] NULL,
 CONSTRAINT [PK_hoc_phan] PRIMARY KEY CLUSTERED 
(
	[mahp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hocphi]    Script Date: 5/17/2024 9:10:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hocphi](
	[mathu] [int] NOT NULL,
	[kyhoc] [nvarchar](50) NULL,
	[hocphi] [int] NULL,
 CONSTRAINT [PK_hocphi] PRIMARY KEY CLUSTERED 
(
	[mathu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[khoa]    Script Date: 5/17/2024 9:10:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khoa](
	[makhoa] [nchar](10) NOT NULL,
	[tenkhoa] [nvarchar](50) NULL,
 CONSTRAINT [PK_khoa] PRIMARY KEY CLUSTERED 
(
	[makhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lop]    Script Date: 5/17/2024 9:10:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lop](
	[malop] [nchar](10) NOT NULL,
	[tenlop] [nvarchar](max) NULL,
	[tenkhoa] [nvarchar](max) NULL,
	[khoahoc] [nvarchar](max) NULL,
 CONSTRAINT [PK_lop] PRIMARY KEY CLUSTERED 
(
	[malop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sinhvien]    Script Date: 5/17/2024 9:10:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sinhvien](
	[anh] [image] NULL,
	[masv] [nvarchar](50) NOT NULL,
	[tensv] [nvarchar](50) NULL,
	[gioitinh] [nvarchar](50) NULL,
	[ngaysinh] [date] NULL,
	[sdt] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[tenlop] [nvarchar](50) NULL,
	[tenkhoa] [nvarchar](50) NULL,
	[matkhau] [nvarchar](10) NULL,
 CONSTRAINT [PK_sinhvien] PRIMARY KEY CLUSTERED 
(
	[masv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
