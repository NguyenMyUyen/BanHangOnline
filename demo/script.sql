USE [sanpham]
GO
/****** Object:  Table [dbo].[LOAISP]    Script Date: 4/19/2021 11:25:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAISP](
	[MALOAISP] [int] IDENTITY(1,1) NOT NULL,
	[TENLOAISP] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MALOAISP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 4/19/2021 11:25:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[MaSP] [int] IDENTITY(1,1) NOT NULL,
	[TenSP] [nvarchar](50) NULL,
	[TenThuongHieu] [nvarchar](50) NULL,
	[Sale] [float] NULL,
	[DonGia] [float] NULL,
	[MALOAISP] [int] NULL,
	[HinhAnh] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_LSP_LSP] FOREIGN KEY([MALOAISP])
REFERENCES [dbo].[LOAISP] ([MALOAISP])
GO
ALTER TABLE [dbo].[SANPHAM] CHECK CONSTRAINT [FK_LSP_LSP]
GO
