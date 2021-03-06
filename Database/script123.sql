USE [BHDT]
GO
/****** Object:  Table [dbo].[CT_DonHang]    Script Date: 4/24/2021 3:27:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_DonHang](
	[MaDDH] [int] NOT NULL,
	[MaSP] [int] NOT NULL,
	[TenSP] [nvarchar](225) NULL,
	[UuDai] [float] NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [CT_don_pk] PRIMARY KEY CLUSTERED 
(
	[MaDDH] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CT_UuDai]    Script Date: 4/24/2021 3:27:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_UuDai](
	[MaLoaiUuDai] [int] NOT NULL,
	[MaSP] [int] NOT NULL,
	[TenLoaiUuDai] [nvarchar](50) NOT NULL,
	[UuDai] [float] NOT NULL,
 CONSTRAINT [CT_UuDai_pk] PRIMARY KEY CLUSTERED 
(
	[MaLoaiUuDai] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DonHang]    Script Date: 4/24/2021 3:27:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonHang](
	[MaDDH] [int] IDENTITY(1,1) NOT NULL,
	[NgayDat] [datetime] NULL,
	[TinhTrangGiaoHang] [bit] NULL,
	[NgayGiao] [datetime] NULL,
	[DaThanhToan] [bit] NULL,
	[MaKH] [int] NULL,
	[MaUuDai] [int] NULL,
	[TongTien] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 4/24/2021 3:27:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](100) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[Email] [nvarchar](100) NULL,
	[SDT] [varchar](12) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 4/24/2021 3:27:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[MaLoaiSP] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](100) NULL,
	[Icon] [nvarchar](max) NULL,
	[BiDanh] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiUuDai]    Script Date: 4/24/2021 3:27:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiUuDai](
	[MaLoaiUuDai] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiUuDai] [nvarchar](50) NOT NULL,
	[UuDai] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiUuDai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaSanXuat]    Script Date: 4/24/2021 3:27:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaSanXuat](
	[MaNSX] [int] IDENTITY(1,1) NOT NULL,
	[TenNSX] [nvarchar](100) NULL,
	[ThongTin] [nvarchar](225) NULL,
	[Logo] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNSX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 4/24/2021 3:27:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [int] IDENTITY(1,1) NOT NULL,
	[TenSP] [nvarchar](225) NULL,
	[DonGia] [decimal](18, 0) NULL,
	[NgayCapNhap] [datetime] NULL,
	[CauHinh] [nvarchar](max) NULL,
	[Mota] [nvarchar](max) NULL,
	[HinhAnh] [nvarchar](max) NULL,
	[Moi] [int] NULL,
	[MaNSX] [int] NULL,
	[MaLoaiSP] [int] NULL,
	[DaXoa] [bit] NULL,
	[UuDai] [float] NULL,
	[HinhAnh1] [nvarchar](max) NULL,
	[HinhAnh2] [nvarchar](max) NULL,
	[HinhAnh3] [nvarchar](max) NULL,
	[HinhAnh4] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 4/24/2021 3:27:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[MATK] [int] IDENTITY(1,1) NOT NULL,
	[TENDN] [varchar](20) NULL,
	[MATKHAU] [varchar](32) NULL,
	[NGAYDANGKY] [datetime] NULL,
	[TRANGTHAI] [bit] NULL,
	[MaKH] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MATK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[User]    Script Date: 4/24/2021 3:27:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](30) NOT NULL,
	[PassWord] [nvarchar](30) NOT NULL,
	[Email] [nvarchar](50) NULL,
	[Phone] [nvarchar](20) NULL,
	[Allowed] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[User] ADD  DEFAULT ((0)) FOR [Allowed]
GO
ALTER TABLE [dbo].[CT_DonHang]  WITH CHECK ADD  CONSTRAINT [FK_CTDH_DDH] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[CT_DonHang] CHECK CONSTRAINT [FK_CTDH_DDH]
GO
ALTER TABLE [dbo].[CT_DonHang]  WITH CHECK ADD  CONSTRAINT [FK_CTDH_DDH1] FOREIGN KEY([MaDDH])
REFERENCES [dbo].[DonHang] ([MaDDH])
GO
ALTER TABLE [dbo].[CT_DonHang] CHECK CONSTRAINT [FK_CTDH_DDH1]
GO
ALTER TABLE [dbo].[CT_UuDai]  WITH CHECK ADD  CONSTRAINT [FK_CTUD_LUD] FOREIGN KEY([MaLoaiUuDai])
REFERENCES [dbo].[LoaiUuDai] ([MaLoaiUuDai])
GO
ALTER TABLE [dbo].[CT_UuDai] CHECK CONSTRAINT [FK_CTUD_LUD]
GO
ALTER TABLE [dbo].[CT_UuDai]  WITH CHECK ADD  CONSTRAINT [FK_CTUD_SP] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[CT_UuDai] CHECK CONSTRAINT [FK_CTUD_SP]
GO
ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD  CONSTRAINT [FK_DonDatHang_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DonHang] CHECK CONSTRAINT [FK_DonDatHang_KhachHang]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FL_SanPham_LoaiSP] FOREIGN KEY([MaLoaiSP])
REFERENCES [dbo].[LoaiSanPham] ([MaLoaiSP])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FL_SanPham_LoaiSP]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FL_SanPham_NhaSanXuat] FOREIGN KEY([MaNSX])
REFERENCES [dbo].[NhaSanXuat] ([MaNSX])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FL_SanPham_NhaSanXuat]
GO
ALTER TABLE [dbo].[TAIKHOAN]  WITH CHECK ADD  CONSTRAINT [FK_TAIKHOAN_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[TAIKHOAN] CHECK CONSTRAINT [FK_TAIKHOAN_KhachHang]
GO
