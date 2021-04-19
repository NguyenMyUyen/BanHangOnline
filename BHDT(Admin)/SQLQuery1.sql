CREATE DATABASE BHDT;
GO
USE [BHDT]
GO
ALTER TABLE [dbo].[ThanhVien] DROP CONSTRAINT [FL_ThanhVien_ToTable]
GO
ALTER TABLE [dbo].[SanPham] DROP CONSTRAINT [FL_SanPham_NhaSanXuat]
GO
ALTER TABLE [dbo].[SanPham] DROP CONSTRAINT [FL_SanPham_NhaCungCap]
GO
ALTER TABLE [dbo].[SanPham] DROP CONSTRAINT [FL_SanPham_LoaiSP]
GO
ALTER TABLE [dbo].[PhieuNhap] DROP CONSTRAINT [FL_PhieuNhap_ToTable]
GO
ALTER TABLE [dbo].[KhachHang] DROP CONSTRAINT [FL_KhachHang_ToTable]
GO
ALTER TABLE [dbo].[DonDatHang] DROP CONSTRAINT [FK_DonDatHang_KhachHang]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] DROP CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap]
GO
ALTER TABLE [dbo].[ChiTietDonDatHang] DROP CONSTRAINT [FK_DonDatHang_SanPham]
GO
ALTER TABLE [dbo].[ChiTietDonDatHang] DROP CONSTRAINT [FK_DonDatHang_DonDatHang]
GO
ALTER TABLE [dbo].[BinhLuan] DROP CONSTRAINT [FK_BinhLuan_ThanhVien]
GO
ALTER TABLE [dbo].[BinhLuan] DROP CONSTRAINT [FK_BinhLuan_SanPham]
GO
/****** Object:  Table [dbo].[ThanhVien]    Script Date: 4/13/2021 10:51:26 AM ******/
DROP TABLE [dbo].[ThanhVien]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 4/13/2021 10:51:26 AM ******/
DROP TABLE [dbo].[SanPham]
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 4/13/2021 10:51:26 AM ******/
DROP TABLE [dbo].[PhieuNhap]
GO
/****** Object:  Table [dbo].[NhaSanXuat]    Script Date: 4/13/2021 10:51:26 AM ******/
DROP TABLE [dbo].[NhaSanXuat]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 4/13/2021 10:51:26 AM ******/
DROP TABLE [dbo].[NhaCungCap]
GO
/****** Object:  Table [dbo].[LoaiThanhVien]    Script Date: 4/13/2021 10:51:26 AM ******/
DROP TABLE [dbo].[LoaiThanhVien]
GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 4/13/2021 10:51:26 AM ******/
DROP TABLE [dbo].[LoaiSanPham]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 4/13/2021 10:51:26 AM ******/
DROP TABLE [dbo].[KhachHang]
GO
/****** Object:  Table [dbo].[DonDatHang]    Script Date: 4/13/2021 10:51:26 AM ******/
DROP TABLE [dbo].[DonDatHang]
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 4/13/2021 10:51:26 AM ******/
DROP TABLE [dbo].[ChiTietPhieuNhap]
GO
/****** Object:  Table [dbo].[ChiTietDonDatHang]    Script Date: 4/13/2021 10:51:26 AM ******/
DROP TABLE [dbo].[ChiTietDonDatHang]
GO
/****** Object:  Table [dbo].[BinhLuan]    Script Date: 4/13/2021 10:51:26 AM ******/
DROP TABLE [dbo].[BinhLuan]
GO
/****** Object:  Table [dbo].[BinhLuan]    Script Date: 4/13/2021 10:51:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BinhLuan](
	[MaBL] [int] IDENTITY(1,1) NOT NULL,
	[NoiDungBL] [nvarchar](max) NULL,
	[MaTV] [int] NULL,
	[MaSP] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietDonDatHang]    Script Date: 4/13/2021 10:51:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonDatHang](
	[MaChiTietDDH] [int] IDENTITY(1,1) NOT NULL,
	[MaDDH] [int] NULL,
	[MaSP] [int] NULL,
	[TenSP] [nvarchar](225) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [decimal](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChiTietDDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 4/13/2021 10:51:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE  [dbo].[User]
(
	UserId INT IDENTITY PRIMARY KEY,
	UserName NVARCHAR(30) NOT NULL,
	[PassWord] NVARCHAR(30) NOT NULL,
	Email NVARCHAR(50),
	Phone NVARCHAR(20),
	Allowed INT DEFAULT(0)
)
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[MaChiTietPhieuNhap] [int] IDENTITY(1,1) NOT NULL,
	[MaPN] [int] NULL,
	[MaSP] [int] NULL,
	[DonGiaNhap] [decimal](18, 0) NULL,
	[SoLuongNhap] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChiTietPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DonDatHang]    Script Date: 4/13/2021 10:51:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonDatHang](
	[MaDDH] [int] IDENTITY(1,1) NOT NULL,
	[NgayDat] [datetime] NULL,
	[TinhTrangGiaoHang] [bit] NULL,
	[NgayGiao] [datetime] NULL,
	[DaThanhToan] [bit] NULL,
	[MaKH] [int] NULL,
	[UuDai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 4/13/2021 10:51:26 AM ******/
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
	[MaTV] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 4/13/2021 10:51:26 AM ******/
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
/****** Object:  Table [dbo].[LoaiThanhVien]    Script Date: 4/13/2021 10:51:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiThanhVien](
	[MaLoaiTV] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
	[UuDai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiTV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 4/13/2021 10:51:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [int] IDENTITY(1,1) NOT NULL,
	[TenNCC] [nvarchar](100) NULL,
	[Diachi] [nvarchar](100) NULL,
	[Email] [nvarchar](225) NULL,
	[SDT] [varchar](12) NULL,
	[Fax] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhaSanXuat]    Script Date: 4/13/2021 10:51:26 AM ******/
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
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 4/13/2021 10:51:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPN] [int] IDENTITY(1,1) NOT NULL,
	[MaNCC] [int] NULL,
	[NgayNhap] [datetime] NULL,
	[DaXoa] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 4/13/2021 10:51:26 AM ******/
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
	[SoLuongton] [int] NULL,
	[LuotXem] [int] NULL,
	[LuotBinhChon] [int] NULL,
	[SoLanMua] [int] NULL,
	[Moi] [int] NULL,
	[MaNCC] [int] NULL,
	[MaNSX] [int] NULL,
	[MaLoaiSP] [int] NULL,
	[DaXoa] [bit] NULL,
	[Sale] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThanhVien]    Script Date: 4/13/2021 10:51:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ThanhVien](
	[MaTV] [int] IDENTITY(1,1) NOT NULL,
	[MaLoaiTV] [int] NULL,
	[TaiKhoan] [nvarchar](100) NULL,
	[MatKhau] [nvarchar](100) NULL,
	[HoTen] [nvarchar](100) NULL,
	[DiaChi] [nvarchar](225) NULL,
	[Email] [nvarchar](225) NULL,
	[SDT] [varchar](12) NULL,
	[CauHoi] [nvarchar](max) NULL,
	[CauTraLoi] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[BinhLuan]  WITH CHECK ADD  CONSTRAINT [FK_BinhLuan_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BinhLuan] CHECK CONSTRAINT [FK_BinhLuan_SanPham]
GO
ALTER TABLE [dbo].[BinhLuan]  WITH CHECK ADD  CONSTRAINT [FK_BinhLuan_ThanhVien] FOREIGN KEY([MaTV])
REFERENCES [dbo].[ThanhVien] ([MaTV])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BinhLuan] CHECK CONSTRAINT [FK_BinhLuan_ThanhVien]
GO
ALTER TABLE [dbo].[ChiTietDonDatHang]  WITH CHECK ADD  CONSTRAINT [FK_DonDatHang_DonDatHang] FOREIGN KEY([MaDDH])
REFERENCES [dbo].[DonDatHang] ([MaDDH])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietDonDatHang] CHECK CONSTRAINT [FK_DonDatHang_DonDatHang]
GO
ALTER TABLE [dbo].[ChiTietDonDatHang]  WITH CHECK ADD  CONSTRAINT [FK_DonDatHang_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietDonDatHang] CHECK CONSTRAINT [FK_DonDatHang_SanPham]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap] FOREIGN KEY([MaPN])
REFERENCES [dbo].[PhieuNhap] ([MaPN])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_SanPham]
GO
ALTER TABLE [dbo].[DonDatHang]  WITH CHECK ADD  CONSTRAINT [FK_DonDatHang_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DonDatHang] CHECK CONSTRAINT [FK_DonDatHang_KhachHang]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FL_KhachHang_ToTable] FOREIGN KEY([MaTV])
REFERENCES [dbo].[ThanhVien] ([MaTV])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FL_KhachHang_ToTable]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FL_PhieuNhap_ToTable] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FL_PhieuNhap_ToTable]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FL_SanPham_LoaiSP] FOREIGN KEY([MaLoaiSP])
REFERENCES [dbo].[LoaiSanPham] ([MaLoaiSP])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FL_SanPham_LoaiSP]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FL_SanPham_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FL_SanPham_NhaCungCap]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FL_SanPham_NhaSanXuat] FOREIGN KEY([MaNSX])
REFERENCES [dbo].[NhaSanXuat] ([MaNSX])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FL_SanPham_NhaSanXuat]
GO
ALTER TABLE [dbo].[ThanhVien]  WITH CHECK ADD  CONSTRAINT [FL_ThanhVien_ToTable] FOREIGN KEY([MaLoaiTV])
REFERENCES [dbo].[LoaiThanhVien] ([MaLoaiTV])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ThanhVien] CHECK CONSTRAINT [FL_ThanhVien_ToTable]
GO