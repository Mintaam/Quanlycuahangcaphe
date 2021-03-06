USE [master]
GO
/****** Object:  Database [qlBH1]    Script Date: 20-Dec-16 5:21:18 PM ******/
CREATE DATABASE [qlBH1] ON  PRIMARY 
( NAME = N'qlBH1', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\qlBH1.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'qlBH1_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\qlBH1_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [qlBH1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [qlBH1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [qlBH1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [qlBH1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [qlBH1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [qlBH1] SET ARITHABORT OFF 
GO
ALTER DATABASE [qlBH1] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [qlBH1] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [qlBH1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [qlBH1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [qlBH1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [qlBH1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [qlBH1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [qlBH1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [qlBH1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [qlBH1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [qlBH1] SET  ENABLE_BROKER 
GO
ALTER DATABASE [qlBH1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [qlBH1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [qlBH1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [qlBH1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [qlBH1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [qlBH1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [qlBH1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [qlBH1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [qlBH1] SET  MULTI_USER 
GO
ALTER DATABASE [qlBH1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [qlBH1] SET DB_CHAINING OFF 
GO
USE [qlBH1]
GO
/****** Object:  Table [dbo].[BAN]    Script Date: 20-Dec-16 5:21:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAN](
	[MaBan] [nvarchar](255) NOT NULL,
	[TenBan] [nvarchar](255) NULL,
	[TinhTrang] [nvarchar](255) NULL,
 CONSTRAINT [BAN$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[MaBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETHANGHOA]    Script Date: 20-Dec-16 5:21:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETHANGHOA](
	[MaNCC] [nvarchar](255) NOT NULL,
	[MaHH] [nvarchar](255) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
 CONSTRAINT [CHITIETHANGHOA$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC,
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETHOADON]    Script Date: 20-Dec-16 5:21:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETHOADON](
	[MaHD] [nvarchar](255) NOT NULL,
	[MaMon] [nvarchar](255) NOT NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [int] NULL,
 CONSTRAINT [CHITIETHOADON$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETPHIEUNHAP]    Script Date: 20-Dec-16 5:21:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUNHAP](
	[MaPN] [nvarchar](255) NOT NULL,
	[MaHH] [nvarchar](255) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
 CONSTRAINT [CHITIETPHIEUNHAP$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC,
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HANGHOA]    Script Date: 20-Dec-16 5:21:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HANGHOA](
	[MaHH] [nvarchar](255) NOT NULL,
	[TenHH] [nvarchar](255) NULL,
	[LoaiHH] [nvarchar](255) NULL,
 CONSTRAINT [HANGHOA$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 20-Dec-16 5:21:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MaHD] [nvarchar](255) NOT NULL,
	[MaNV] [nvarchar](255) NULL,
	[MaBan] [nvarchar](255) NULL,
	[NgayLap] [datetime2](0) NULL,
 CONSTRAINT [HOADON$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 20-Dec-16 5:21:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[MaNCC] [nvarchar](255) NOT NULL,
	[TenNCC] [nvarchar](255) NULL,
	[DiaChi] [nvarchar](255) NULL,
	[Sdt] [int] NULL,
	[E-Mail] [nvarchar](255) NULL,
 CONSTRAINT [NHACUNGCAP$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 20-Dec-16 5:21:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [nvarchar](255) NOT NULL,
	[TenNV] [nvarchar](255) NULL,
	[ChucVu] [nvarchar](255) NULL,
	[NgayVaoLam] [datetime2](0) NULL,
	[DiaChi] [nvarchar](255) NULL,
	[Sdt] [int] NULL,
	[E-Mail] [nvarchar](255) NULL,
 CONSTRAINT [NHANVIEN$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 20-Dec-16 5:21:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[MaPN] [nvarchar](255) NOT NULL,
	[MaNV] [nvarchar](255) NULL,
	[NgayNhap] [datetime2](0) NULL,
 CONSTRAINT [PHIEUNHAP$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 20-Dec-16 5:21:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[MaNV] [nvarchar](255) NOT NULL,
	[MatKhau] [nvarchar](255) NULL,
 CONSTRAINT [TAIKHOAN$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[THUCDON]    Script Date: 20-Dec-16 5:21:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THUCDON](
	[MaMon] [nvarchar](255) NOT NULL,
	[TenMon] [nvarchar](255) NULL,
	[DonGia] [int] NULL,
 CONSTRAINT [THUCDON$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[BAN] ([MaBan], [TenBan], [TinhTrang]) VALUES (N'MB001', N'Bàn 1', N'Đã có khách')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [TinhTrang]) VALUES (N'MB002', N'Bàn 3', N'Trống')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [TinhTrang]) VALUES (N'MB003', N'Bàn 2', N'Trống')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [TinhTrang]) VALUES (N'MB004', N'Bàn 4', N'Đã có khách')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [TinhTrang]) VALUES (N'MB005', N'Bàn 5', N'Đã có khách')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [TinhTrang]) VALUES (N'MB006', N'Bàn 6', N'Đã có khách')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [TinhTrang]) VALUES (N'MB007', N'Bàn 7', N'Trống')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [TinhTrang]) VALUES (N'MB008', N'Bàn 8', N'Trống')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [TinhTrang]) VALUES (N'MB009', N'Bàn 9', N'Đã có khách')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [TinhTrang]) VALUES (N'MB010', N'Bàn 10', N'Trống')
INSERT [dbo].[CHITIETHANGHOA] ([MaNCC], [MaHH], [SoLuong], [DonGia]) VALUES (N'NCC1', N'HH02', 3, 4500000)
INSERT [dbo].[CHITIETHANGHOA] ([MaNCC], [MaHH], [SoLuong], [DonGia]) VALUES (N'NCC10', N'HH01', 2, 2500000)
INSERT [dbo].[CHITIETHANGHOA] ([MaNCC], [MaHH], [SoLuong], [DonGia]) VALUES (N'NCC2', N'HH04', 3, 5000000)
INSERT [dbo].[CHITIETHANGHOA] ([MaNCC], [MaHH], [SoLuong], [DonGia]) VALUES (N'NCC3', N'HH10', 1, 6580000)
INSERT [dbo].[CHITIETHANGHOA] ([MaNCC], [MaHH], [SoLuong], [DonGia]) VALUES (N'NCC4', N'HH08', 4, 2350000)
INSERT [dbo].[CHITIETHANGHOA] ([MaNCC], [MaHH], [SoLuong], [DonGia]) VALUES (N'NCC5', N'HH03', 6, 3570000)
INSERT [dbo].[CHITIETHANGHOA] ([MaNCC], [MaHH], [SoLuong], [DonGia]) VALUES (N'NCC6', N'HH05', 3, 1260000)
INSERT [dbo].[CHITIETHANGHOA] ([MaNCC], [MaHH], [SoLuong], [DonGia]) VALUES (N'NCC7', N'HH07', 2, 2550000)
INSERT [dbo].[CHITIETHANGHOA] ([MaNCC], [MaHH], [SoLuong], [DonGia]) VALUES (N'NCC8', N'HH03', 2, 4560000)
INSERT [dbo].[CHITIETHANGHOA] ([MaNCC], [MaHH], [SoLuong], [DonGia]) VALUES (N'NCC9', N'HH04', 1, 2300000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaMon], [SoLuong], [ThanhTien]) VALUES (N'HD0001', N'TS01', 3, 90000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaMon], [SoLuong], [ThanhTien]) VALUES (N'HD0002', N'DM02', 2, 70000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaMon], [SoLuong], [ThanhTien]) VALUES (N'HD0003', N'CD04', 1, 68000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaMon], [SoLuong], [ThanhTien]) VALUES (N'HD0004', N'CF01', 2, 125000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaMon], [SoLuong], [ThanhTien]) VALUES (N'HD0005', N'SD04', 4, 35000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaMon], [SoLuong], [ThanhTien]) VALUES (N'HD0006', N'TX02', 3, 46000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaMon], [SoLuong], [ThanhTien]) VALUES (N'HD0007', N'TS01', 2, 55000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaMon], [SoLuong], [ThanhTien]) VALUES (N'HD0008', N'CC02', 5, 60000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaMon], [SoLuong], [ThanhTien]) VALUES (N'HD0009', N'LT03', 1, 23000)
INSERT [dbo].[CHITIETHOADON] ([MaHD], [MaMon], [SoLuong], [ThanhTien]) VALUES (N'HD0010', N'NN01', 2, 120000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPN], [MaHH], [SoLuong], [DonGia]) VALUES (N'PN0001', N'HH01', 8, 9800000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPN], [MaHH], [SoLuong], [DonGia]) VALUES (N'PN0002', N'HH02', 5, 2450000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPN], [MaHH], [SoLuong], [DonGia]) VALUES (N'PN0003', N'HH03', 7, 7680000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPN], [MaHH], [SoLuong], [DonGia]) VALUES (N'PN0004', N'HH04', 3, 1280000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPN], [MaHH], [SoLuong], [DonGia]) VALUES (N'PN0005', N'HH10', 5, 4580000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPN], [MaHH], [SoLuong], [DonGia]) VALUES (N'PN0006', N'HH09', 2, 3580000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPN], [MaHH], [SoLuong], [DonGia]) VALUES (N'PN0007', N'HH07', 1, 1245000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPN], [MaHH], [SoLuong], [DonGia]) VALUES (N'PN0008', N'HH08', 6, 1250000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPN], [MaHH], [SoLuong], [DonGia]) VALUES (N'PN0009', N'HH06', 5, 4580000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPN], [MaHH], [SoLuong], [DonGia]) VALUES (N'PN0010', N'HH05', 7, 3400000)
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [LoaiHH]) VALUES (N'HH01', N'Cà phê', N'hương liệu')
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [LoaiHH]) VALUES (N'HH02', N'Trà xanh', N'hương liệu')
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [LoaiHH]) VALUES (N'HH03', N'Ly', N'vật liệu')
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [LoaiHH]) VALUES (N'HH04', N'Sữa', N'hương liệu')
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [LoaiHH]) VALUES (N'HH05', N'Khăn giấy', N'vật liệu')
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [LoaiHH]) VALUES (N'HH06', N'Đá viên', N'hương liệu')
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [LoaiHH]) VALUES (N'HH07', N'Bàn ghế', N'vật liệu')
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [LoaiHH]) VALUES (N'HH08', N'Ống hút', N'vật liệu')
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [LoaiHH]) VALUES (N'HH09', N'Nước ngọt', N'hương liệu')
INSERT [dbo].[HANGHOA] ([MaHH], [TenHH], [LoaiHH]) VALUES (N'HH10', N'Đường', N'hương liệu')
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaBan], [NgayLap]) VALUES (N'HD0001', N'NV0003', N'MB003', CAST(0x00000000463C0B0000 AS DateTime2))
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaBan], [NgayLap]) VALUES (N'HD0002', N'NV0001', N'MB004', CAST(0x00000000403C0B0000 AS DateTime2))
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaBan], [NgayLap]) VALUES (N'HD0003', N'NV0002', N'MB009', CAST(0x000000002B3C0B0000 AS DateTime2))
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaBan], [NgayLap]) VALUES (N'HD0004', N'NV0001', N'MB005', CAST(0x000000002C3C0B0000 AS DateTime2))
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaBan], [NgayLap]) VALUES (N'HD0005', N'NV0001', N'MB006', CAST(0x00000000273C0B0000 AS DateTime2))
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaBan], [NgayLap]) VALUES (N'HD0006', N'NV0003', N'MB007', CAST(0x00000000283C0B0000 AS DateTime2))
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaBan], [NgayLap]) VALUES (N'HD0007', N'NV0005', N'MB002', CAST(0x000000002D3C0B0000 AS DateTime2))
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaBan], [NgayLap]) VALUES (N'HD0008', N'NV0004', N'MB001', CAST(0x00000000403C0B0000 AS DateTime2))
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaBan], [NgayLap]) VALUES (N'HD0009', N'NV0002', N'MB010', CAST(0x00000000373C0B0000 AS DateTime2))
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaBan], [NgayLap]) VALUES (N'HD0010', N'NV0005', N'MB008', CAST(0x000000002A3C0B0000 AS DateTime2))
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [Sdt], [E-Mail]) VALUES (N'NCC1', N'Hương Việt', N'Bảo Lộc', 12146512, N'cfbl@gmail.com')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [Sdt], [E-Mail]) VALUES (N'NCC10', N'Giấy Paper', N'Cần Thơ', 12574949, N'paperich347@gmail.com')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [Sdt], [E-Mail]) VALUES (N'NCC2', N'Trung Nguyên', N'SG', 16446845, N'TN@gmail.com')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [Sdt], [E-Mail]) VALUES (N'NCC3', N'Phố Vip', N'HCM', 26744859, N'px9757@gmail.com')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [Sdt], [E-Mail]) VALUES (N'NCC4', N'Nhà Xinh', N'LĐ', 26749565, N'mailinh@gmail.com')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [Sdt], [E-Mail]) VALUES (N'NCC5', N'Coffee House', N'Han Quốc', 90653792, N'hagdiem964@gmail.com')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [Sdt], [E-Mail]) VALUES (N'NCC6', N'Nhựa Thành An', N'Hà Giang', 14264846, N'thanhan97@gmail.com')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [Sdt], [E-Mail]) VALUES (N'NCC7', N'Hoa Sen Vàng', N'Hà Tiên', 97341326, N'vengen574@gmail.com')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [Sdt], [E-Mail]) VALUES (N'NCC8', N'Pepsi', N'Mỹ', 64829625, N'hendhfy@gmail.com')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [Sdt], [E-Mail]) VALUES (N'NCC9', N'Hạ Mai', N'HCM', 23648595, N'maiha548@gmail.com')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [ChucVu], [NgayVaoLam], [DiaChi], [Sdt], [E-Mail]) VALUES (N'NV0001', N'Nguyễn Minh Tâm', N'Quản lý', CAST(0x000000002A3C0B0000 AS DateTime2), N'Mỹ Tho', 1267247068, N'junist96@gmail.com')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [ChucVu], [NgayVaoLam], [DiaChi], [Sdt], [E-Mail]) VALUES (N'NV0002', N'Ngô Thị Phượng Huyền', N'Pha chế', CAST(0x00000000383C0B0000 AS DateTime2), N'Cai Lậy', 1154545545, N'rgfsvd@gmail.com')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [ChucVu], [NgayVaoLam], [DiaChi], [Sdt], [E-Mail]) VALUES (N'NV0003', N'Nguyễn Ngọc Hạnh', N'Phục vụ', CAST(0x000000003F3C0B0000 AS DateTime2), N'Chợ Gạo', 1254455678, N'ngng@gmail.com')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [ChucVu], [NgayVaoLam], [DiaChi], [Sdt], [E-Mail]) VALUES (N'NV0004', N'Lâm Minh Ngọc', N'Bảo vệ', CAST(0x00000000363C0B0000 AS DateTime2), N'Vĩnh Phúc', 907887629, N'ngocmh34@gmail.com')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [ChucVu], [NgayVaoLam], [DiaChi], [Sdt], [E-Mail]) VALUES (N'NV0005', N'Võ Ngọc Mai', N'Tiếp tân', CAST(0x00000000363C0B0000 AS DateTime2), N'Cần Thơ', 902635478, N'mainge657@gmail.com')
INSERT [dbo].[PHIEUNHAP] ([MaPN], [MaNV], [NgayNhap]) VALUES (N'PN0001', N'NV0003', CAST(0x00000000483C0B0000 AS DateTime2))
INSERT [dbo].[PHIEUNHAP] ([MaPN], [MaNV], [NgayNhap]) VALUES (N'PN0002', N'NV0002', CAST(0x00000000303C0B0000 AS DateTime2))
INSERT [dbo].[PHIEUNHAP] ([MaPN], [MaNV], [NgayNhap]) VALUES (N'PN0003', N'NV0003', CAST(0x000000002C3C0B0000 AS DateTime2))
INSERT [dbo].[PHIEUNHAP] ([MaPN], [MaNV], [NgayNhap]) VALUES (N'PN0004', N'NV0001', CAST(0x00000000483C0B0000 AS DateTime2))
INSERT [dbo].[PHIEUNHAP] ([MaPN], [MaNV], [NgayNhap]) VALUES (N'PN0005', N'NV0005', CAST(0x000000003E3C0B0000 AS DateTime2))
INSERT [dbo].[PHIEUNHAP] ([MaPN], [MaNV], [NgayNhap]) VALUES (N'PN0006', N'NV0004', CAST(0x000000002D3C0B0000 AS DateTime2))
INSERT [dbo].[PHIEUNHAP] ([MaPN], [MaNV], [NgayNhap]) VALUES (N'PN0007', N'NV0004', CAST(0x00000000393C0B0000 AS DateTime2))
INSERT [dbo].[PHIEUNHAP] ([MaPN], [MaNV], [NgayNhap]) VALUES (N'PN0008', N'NV0002', CAST(0x00000000423C0B0000 AS DateTime2))
INSERT [dbo].[PHIEUNHAP] ([MaPN], [MaNV], [NgayNhap]) VALUES (N'PN0009', N'NV0002', CAST(0x00000000343C0B0000 AS DateTime2))
INSERT [dbo].[PHIEUNHAP] ([MaPN], [MaNV], [NgayNhap]) VALUES (N'PN0010', N'NV0001', CAST(0x000000002E3C0B0000 AS DateTime2))
INSERT [dbo].[TAIKHOAN] ([MaNV], [MatKhau]) VALUES (N'NV0001', N'123456789')
INSERT [dbo].[TAIKHOAN] ([MaNV], [MatKhau]) VALUES (N'NV0002', N'96969696')
INSERT [dbo].[TAIKHOAN] ([MaNV], [MatKhau]) VALUES (N'NV0003', N'13321456')
INSERT [dbo].[TAIKHOAN] ([MaNV], [MatKhau]) VALUES (N'NV0004', N'27793965')
INSERT [dbo].[TAIKHOAN] ([MaNV], [MatKhau]) VALUES (N'NV0005', N'12568367')
INSERT [dbo].[THUCDON] ([MaMon], [TenMon], [DonGia]) VALUES (N'CC02', N'Cacao sữa đá', 12000)
INSERT [dbo].[THUCDON] ([MaMon], [TenMon], [DonGia]) VALUES (N'CD04', N'Cookie đá xay', 20000)
INSERT [dbo].[THUCDON] ([MaMon], [TenMon], [DonGia]) VALUES (N'CF01', N'Cà phê truyền thống', 10000)
INSERT [dbo].[THUCDON] ([MaMon], [TenMon], [DonGia]) VALUES (N'DM02', N'Đá me ngọt', 12000)
INSERT [dbo].[THUCDON] ([MaMon], [TenMon], [DonGia]) VALUES (N'LT03', N'Lipton đá', 10000)
INSERT [dbo].[THUCDON] ([MaMon], [TenMon], [DonGia]) VALUES (N'NN01', N'Nước ngọt', 10000)
INSERT [dbo].[THUCDON] ([MaMon], [TenMon], [DonGia]) VALUES (N'SD04', N'Soda', 13000)
INSERT [dbo].[THUCDON] ([MaMon], [TenMon], [DonGia]) VALUES (N'ST03', N'Sinh tố nhiệt đới', 15000)
INSERT [dbo].[THUCDON] ([MaMon], [TenMon], [DonGia]) VALUES (N'TS01', N'Trà sữa đặc biệt', 30000)
INSERT [dbo].[THUCDON] ([MaMon], [TenMon], [DonGia]) VALUES (N'TX02', N'Trà xanh nóng', 15000)
SET ANSI_PADDING ON

GO
/****** Object:  Index [CHITIETHANGHOA$CHITIETHANGHOAMaHH]    Script Date: 20-Dec-16 5:21:19 PM ******/
CREATE NONCLUSTERED INDEX [CHITIETHANGHOA$CHITIETHANGHOAMaHH] ON [dbo].[CHITIETHANGHOA]
(
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [CHITIETHANGHOA$HANGHOACHITIETHANGHOA]    Script Date: 20-Dec-16 5:21:19 PM ******/
CREATE NONCLUSTERED INDEX [CHITIETHANGHOA$HANGHOACHITIETHANGHOA] ON [dbo].[CHITIETHANGHOA]
(
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [CHITIETHANGHOA$NHACUNGCAPCHITIETHANGHOA]    Script Date: 20-Dec-16 5:21:19 PM ******/
CREATE NONCLUSTERED INDEX [CHITIETHANGHOA$NHACUNGCAPCHITIETHANGHOA] ON [dbo].[CHITIETHANGHOA]
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [CHITIETHOADON$CHITIETHOADONMaHD]    Script Date: 20-Dec-16 5:21:19 PM ******/
CREATE NONCLUSTERED INDEX [CHITIETHOADON$CHITIETHOADONMaHD] ON [dbo].[CHITIETHOADON]
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [CHITIETHOADON$HOADONCHITIETHOADON]    Script Date: 20-Dec-16 5:21:19 PM ******/
CREATE NONCLUSTERED INDEX [CHITIETHOADON$HOADONCHITIETHOADON] ON [dbo].[CHITIETHOADON]
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [CHITIETHOADON$THUCDONCHITIETHOADON]    Script Date: 20-Dec-16 5:21:19 PM ******/
CREATE NONCLUSTERED INDEX [CHITIETHOADON$THUCDONCHITIETHOADON] ON [dbo].[CHITIETHOADON]
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [CHITIETPHIEUNHAP$CHITIETPHIEUNHAPMaHH]    Script Date: 20-Dec-16 5:21:19 PM ******/
CREATE NONCLUSTERED INDEX [CHITIETPHIEUNHAP$CHITIETPHIEUNHAPMaHH] ON [dbo].[CHITIETPHIEUNHAP]
(
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [CHITIETPHIEUNHAP$HANGHOACHITIETPHIEUNHAP]    Script Date: 20-Dec-16 5:21:19 PM ******/
CREATE NONCLUSTERED INDEX [CHITIETPHIEUNHAP$HANGHOACHITIETPHIEUNHAP] ON [dbo].[CHITIETPHIEUNHAP]
(
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [CHITIETPHIEUNHAP$PHIEUNHAPCHITIETPHIEUNHAP]    Script Date: 20-Dec-16 5:21:19 PM ******/
CREATE NONCLUSTERED INDEX [CHITIETPHIEUNHAP$PHIEUNHAPCHITIETPHIEUNHAP] ON [dbo].[CHITIETPHIEUNHAP]
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [HOADON$BANHOADON]    Script Date: 20-Dec-16 5:21:19 PM ******/
CREATE NONCLUSTERED INDEX [HOADON$BANHOADON] ON [dbo].[HOADON]
(
	[MaBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [HOADON$HOADONMaNV]    Script Date: 20-Dec-16 5:21:19 PM ******/
CREATE NONCLUSTERED INDEX [HOADON$HOADONMaNV] ON [dbo].[HOADON]
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [HOADON$NHANVIENHOADON]    Script Date: 20-Dec-16 5:21:19 PM ******/
CREATE NONCLUSTERED INDEX [HOADON$NHANVIENHOADON] ON [dbo].[HOADON]
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [PHIEUNHAP$NHANVIENPHIEUNHAP]    Script Date: 20-Dec-16 5:21:19 PM ******/
CREATE NONCLUSTERED INDEX [PHIEUNHAP$NHANVIENPHIEUNHAP] ON [dbo].[PHIEUNHAP]
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [PHIEUNHAP$PHIEUNHAPMaNV]    Script Date: 20-Dec-16 5:21:19 PM ******/
CREATE NONCLUSTERED INDEX [PHIEUNHAP$PHIEUNHAPMaNV] ON [dbo].[PHIEUNHAP]
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [TAIKHOAN$NHANVIENTAIKHOAN]    Script Date: 20-Dec-16 5:21:19 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [TAIKHOAN$NHANVIENTAIKHOAN] ON [dbo].[TAIKHOAN]
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CHITIETHANGHOA]  WITH NOCHECK ADD  CONSTRAINT [CHITIETHANGHOA$HANGHOACHITIETHANGHOA] FOREIGN KEY([MaHH])
REFERENCES [dbo].[HANGHOA] ([MaHH])
GO
ALTER TABLE [dbo].[CHITIETHANGHOA] CHECK CONSTRAINT [CHITIETHANGHOA$HANGHOACHITIETHANGHOA]
GO
ALTER TABLE [dbo].[CHITIETHANGHOA]  WITH NOCHECK ADD  CONSTRAINT [CHITIETHANGHOA$NHACUNGCAPCHITIETHANGHOA] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NHACUNGCAP] ([MaNCC])
GO
ALTER TABLE [dbo].[CHITIETHANGHOA] CHECK CONSTRAINT [CHITIETHANGHOA$NHACUNGCAPCHITIETHANGHOA]
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH NOCHECK ADD  CONSTRAINT [CHITIETHOADON$HOADONCHITIETHOADON] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOADON] ([MaHD])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [CHITIETHOADON$HOADONCHITIETHOADON]
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH NOCHECK ADD  CONSTRAINT [CHITIETHOADON$THUCDONCHITIETHOADON] FOREIGN KEY([MaMon])
REFERENCES [dbo].[THUCDON] ([MaMon])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [CHITIETHOADON$THUCDONCHITIETHOADON]
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP]  WITH NOCHECK ADD  CONSTRAINT [CHITIETPHIEUNHAP$HANGHOACHITIETPHIEUNHAP] FOREIGN KEY([MaHH])
REFERENCES [dbo].[HANGHOA] ([MaHH])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP] CHECK CONSTRAINT [CHITIETPHIEUNHAP$HANGHOACHITIETPHIEUNHAP]
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP]  WITH NOCHECK ADD  CONSTRAINT [CHITIETPHIEUNHAP$PHIEUNHAPCHITIETPHIEUNHAP] FOREIGN KEY([MaPN])
REFERENCES [dbo].[PHIEUNHAP] ([MaPN])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP] CHECK CONSTRAINT [CHITIETPHIEUNHAP$PHIEUNHAPCHITIETPHIEUNHAP]
GO
ALTER TABLE [dbo].[HOADON]  WITH NOCHECK ADD  CONSTRAINT [HOADON$BANHOADON] FOREIGN KEY([MaBan])
REFERENCES [dbo].[BAN] ([MaBan])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [HOADON$BANHOADON]
GO
ALTER TABLE [dbo].[HOADON]  WITH NOCHECK ADD  CONSTRAINT [HOADON$NHANVIENHOADON] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [HOADON$NHANVIENHOADON]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH NOCHECK ADD  CONSTRAINT [PHIEUNHAP$NHANVIENPHIEUNHAP] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [PHIEUNHAP$NHANVIENPHIEUNHAP]
GO
ALTER TABLE [dbo].[TAIKHOAN]  WITH NOCHECK ADD  CONSTRAINT [TAIKHOAN$NHANVIENTAIKHOAN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[TAIKHOAN] CHECK CONSTRAINT [TAIKHOAN$NHANVIENTAIKHOAN]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[BAN].[MaBan]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BAN', @level2type=N'COLUMN',@level2name=N'MaBan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[BAN].[TenBan]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BAN', @level2type=N'COLUMN',@level2name=N'TenBan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[BAN].[TinhTrang]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BAN', @level2type=N'COLUMN',@level2name=N'TinhTrang'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[BAN]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BAN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[BAN].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BAN', @level2type=N'CONSTRAINT',@level2name=N'BAN$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[CHITIETHANGHOA].[MaNCC]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CHITIETHANGHOA', @level2type=N'COLUMN',@level2name=N'MaNCC'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[CHITIETHANGHOA].[MaHH]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CHITIETHANGHOA', @level2type=N'COLUMN',@level2name=N'MaHH'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[CHITIETHANGHOA].[SoLuong]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CHITIETHANGHOA', @level2type=N'COLUMN',@level2name=N'SoLuong'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[CHITIETHANGHOA].[DonGia]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CHITIETHANGHOA', @level2type=N'COLUMN',@level2name=N'DonGia'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[CHITIETHANGHOA]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CHITIETHANGHOA'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[CHITIETHANGHOA].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CHITIETHANGHOA', @level2type=N'CONSTRAINT',@level2name=N'CHITIETHANGHOA$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[CHITIETHANGHOA].[CHITIETHANGHOAMaHH]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CHITIETHANGHOA', @level2type=N'INDEX',@level2name=N'CHITIETHANGHOA$CHITIETHANGHOAMaHH'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[CHITIETHANGHOA].[HANGHOACHITIETHANGHOA]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CHITIETHANGHOA', @level2type=N'INDEX',@level2name=N'CHITIETHANGHOA$HANGHOACHITIETHANGHOA'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[CHITIETHANGHOA].[NHACUNGCAPCHITIETHANGHOA]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CHITIETHANGHOA', @level2type=N'INDEX',@level2name=N'CHITIETHANGHOA$NHACUNGCAPCHITIETHANGHOA'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[CHITIETHANGHOA].[HANGHOACHITIETHANGHOA]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CHITIETHANGHOA', @level2type=N'CONSTRAINT',@level2name=N'CHITIETHANGHOA$HANGHOACHITIETHANGHOA'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[CHITIETHANGHOA].[NHACUNGCAPCHITIETHANGHOA]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CHITIETHANGHOA', @level2type=N'CONSTRAINT',@level2name=N'CHITIETHANGHOA$NHACUNGCAPCHITIETHANGHOA'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[CHITIETHOADON].[MaHD]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CHITIETHOADON', @level2type=N'COLUMN',@level2name=N'MaHD'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[CHITIETHOADON].[MaMon]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CHITIETHOADON', @level2type=N'COLUMN',@level2name=N'MaMon'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[CHITIETHOADON].[SoLuong]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CHITIETHOADON', @level2type=N'COLUMN',@level2name=N'SoLuong'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[CHITIETHOADON].[ThanhTien]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CHITIETHOADON', @level2type=N'COLUMN',@level2name=N'ThanhTien'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[CHITIETHOADON]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CHITIETHOADON'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[CHITIETHOADON].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CHITIETHOADON', @level2type=N'CONSTRAINT',@level2name=N'CHITIETHOADON$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[CHITIETHOADON].[CHITIETHOADONMaHD]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CHITIETHOADON', @level2type=N'INDEX',@level2name=N'CHITIETHOADON$CHITIETHOADONMaHD'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[CHITIETHOADON].[HOADONCHITIETHOADON]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CHITIETHOADON', @level2type=N'INDEX',@level2name=N'CHITIETHOADON$HOADONCHITIETHOADON'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[CHITIETHOADON].[THUCDONCHITIETHOADON]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CHITIETHOADON', @level2type=N'INDEX',@level2name=N'CHITIETHOADON$THUCDONCHITIETHOADON'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[CHITIETHOADON].[HOADONCHITIETHOADON]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CHITIETHOADON', @level2type=N'CONSTRAINT',@level2name=N'CHITIETHOADON$HOADONCHITIETHOADON'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[CHITIETHOADON].[THUCDONCHITIETHOADON]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CHITIETHOADON', @level2type=N'CONSTRAINT',@level2name=N'CHITIETHOADON$THUCDONCHITIETHOADON'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[CHITIETPHIEUNHAP].[MaPN]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CHITIETPHIEUNHAP', @level2type=N'COLUMN',@level2name=N'MaPN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[CHITIETPHIEUNHAP].[MaHH]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CHITIETPHIEUNHAP', @level2type=N'COLUMN',@level2name=N'MaHH'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[CHITIETPHIEUNHAP].[SoLuong]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CHITIETPHIEUNHAP', @level2type=N'COLUMN',@level2name=N'SoLuong'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[CHITIETPHIEUNHAP].[DonGia]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CHITIETPHIEUNHAP', @level2type=N'COLUMN',@level2name=N'DonGia'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[CHITIETPHIEUNHAP]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CHITIETPHIEUNHAP'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[CHITIETPHIEUNHAP].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CHITIETPHIEUNHAP', @level2type=N'CONSTRAINT',@level2name=N'CHITIETPHIEUNHAP$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[CHITIETPHIEUNHAP].[CHITIETPHIEUNHAPMaHH]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CHITIETPHIEUNHAP', @level2type=N'INDEX',@level2name=N'CHITIETPHIEUNHAP$CHITIETPHIEUNHAPMaHH'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[CHITIETPHIEUNHAP].[HANGHOACHITIETPHIEUNHAP]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CHITIETPHIEUNHAP', @level2type=N'INDEX',@level2name=N'CHITIETPHIEUNHAP$HANGHOACHITIETPHIEUNHAP'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[CHITIETPHIEUNHAP].[PHIEUNHAPCHITIETPHIEUNHAP]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CHITIETPHIEUNHAP', @level2type=N'INDEX',@level2name=N'CHITIETPHIEUNHAP$PHIEUNHAPCHITIETPHIEUNHAP'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[CHITIETPHIEUNHAP].[HANGHOACHITIETPHIEUNHAP]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CHITIETPHIEUNHAP', @level2type=N'CONSTRAINT',@level2name=N'CHITIETPHIEUNHAP$HANGHOACHITIETPHIEUNHAP'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[CHITIETPHIEUNHAP].[PHIEUNHAPCHITIETPHIEUNHAP]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CHITIETPHIEUNHAP', @level2type=N'CONSTRAINT',@level2name=N'CHITIETPHIEUNHAP$PHIEUNHAPCHITIETPHIEUNHAP'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[HANGHOA].[MaHH]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'HANGHOA', @level2type=N'COLUMN',@level2name=N'MaHH'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[HANGHOA].[TenHH]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'HANGHOA', @level2type=N'COLUMN',@level2name=N'TenHH'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[HANGHOA].[LoaiHH]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'HANGHOA', @level2type=N'COLUMN',@level2name=N'LoaiHH'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[HANGHOA]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'HANGHOA'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[HANGHOA].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'HANGHOA', @level2type=N'CONSTRAINT',@level2name=N'HANGHOA$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[HOADON].[MaHD]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'HOADON', @level2type=N'COLUMN',@level2name=N'MaHD'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[HOADON].[MaNV]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'HOADON', @level2type=N'COLUMN',@level2name=N'MaNV'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[HOADON].[MaBan]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'HOADON', @level2type=N'COLUMN',@level2name=N'MaBan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[HOADON].[NgayLap]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'HOADON', @level2type=N'COLUMN',@level2name=N'NgayLap'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[HOADON]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'HOADON'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[HOADON].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'HOADON', @level2type=N'CONSTRAINT',@level2name=N'HOADON$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[HOADON].[BANHOADON]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'HOADON', @level2type=N'INDEX',@level2name=N'HOADON$BANHOADON'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[HOADON].[HOADONMaNV]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'HOADON', @level2type=N'INDEX',@level2name=N'HOADON$HOADONMaNV'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[HOADON].[NHANVIENHOADON]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'HOADON', @level2type=N'INDEX',@level2name=N'HOADON$NHANVIENHOADON'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[HOADON].[BANHOADON]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'HOADON', @level2type=N'CONSTRAINT',@level2name=N'HOADON$BANHOADON'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[HOADON].[NHANVIENHOADON]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'HOADON', @level2type=N'CONSTRAINT',@level2name=N'HOADON$NHANVIENHOADON'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[NHACUNGCAP].[MaNCC]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NHACUNGCAP', @level2type=N'COLUMN',@level2name=N'MaNCC'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[NHACUNGCAP].[TenNCC]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NHACUNGCAP', @level2type=N'COLUMN',@level2name=N'TenNCC'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[NHACUNGCAP].[DiaChi]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NHACUNGCAP', @level2type=N'COLUMN',@level2name=N'DiaChi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[NHACUNGCAP].[Sdt]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NHACUNGCAP', @level2type=N'COLUMN',@level2name=N'Sdt'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[NHACUNGCAP].[E-Mail]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NHACUNGCAP', @level2type=N'COLUMN',@level2name=N'E-Mail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[NHACUNGCAP]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NHACUNGCAP'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[NHACUNGCAP].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NHACUNGCAP', @level2type=N'CONSTRAINT',@level2name=N'NHACUNGCAP$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[NHANVIEN].[MaNV]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NHANVIEN', @level2type=N'COLUMN',@level2name=N'MaNV'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[NHANVIEN].[TenNV]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NHANVIEN', @level2type=N'COLUMN',@level2name=N'TenNV'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[NHANVIEN].[ChucVu]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NHANVIEN', @level2type=N'COLUMN',@level2name=N'ChucVu'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[NHANVIEN].[NgayVaoLam]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NHANVIEN', @level2type=N'COLUMN',@level2name=N'NgayVaoLam'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[NHANVIEN].[DiaChi]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NHANVIEN', @level2type=N'COLUMN',@level2name=N'DiaChi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[NHANVIEN].[Sdt]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NHANVIEN', @level2type=N'COLUMN',@level2name=N'Sdt'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[NHANVIEN].[E-Mail]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NHANVIEN', @level2type=N'COLUMN',@level2name=N'E-Mail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[NHANVIEN]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NHANVIEN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[NHANVIEN].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NHANVIEN', @level2type=N'CONSTRAINT',@level2name=N'NHANVIEN$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[PHIEUNHAP].[MaPN]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PHIEUNHAP', @level2type=N'COLUMN',@level2name=N'MaPN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[PHIEUNHAP].[MaNV]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PHIEUNHAP', @level2type=N'COLUMN',@level2name=N'MaNV'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[PHIEUNHAP].[NgayNhap]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PHIEUNHAP', @level2type=N'COLUMN',@level2name=N'NgayNhap'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[PHIEUNHAP]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PHIEUNHAP'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[PHIEUNHAP].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PHIEUNHAP', @level2type=N'CONSTRAINT',@level2name=N'PHIEUNHAP$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[PHIEUNHAP].[NHANVIENPHIEUNHAP]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PHIEUNHAP', @level2type=N'INDEX',@level2name=N'PHIEUNHAP$NHANVIENPHIEUNHAP'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[PHIEUNHAP].[PHIEUNHAPMaNV]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PHIEUNHAP', @level2type=N'INDEX',@level2name=N'PHIEUNHAP$PHIEUNHAPMaNV'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[PHIEUNHAP].[NHANVIENPHIEUNHAP]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PHIEUNHAP', @level2type=N'CONSTRAINT',@level2name=N'PHIEUNHAP$NHANVIENPHIEUNHAP'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[TAIKHOAN].[MaNV]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TAIKHOAN', @level2type=N'COLUMN',@level2name=N'MaNV'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[TAIKHOAN].[MatKhau]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TAIKHOAN', @level2type=N'COLUMN',@level2name=N'MatKhau'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[TAIKHOAN]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TAIKHOAN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[TAIKHOAN].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TAIKHOAN', @level2type=N'CONSTRAINT',@level2name=N'TAIKHOAN$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[TAIKHOAN].[NHANVIENTAIKHOAN]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TAIKHOAN', @level2type=N'INDEX',@level2name=N'TAIKHOAN$NHANVIENTAIKHOAN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[TAIKHOAN].[NHANVIENTAIKHOAN]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TAIKHOAN', @level2type=N'CONSTRAINT',@level2name=N'TAIKHOAN$NHANVIENTAIKHOAN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[THUCDON].[MaMon]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'THUCDON', @level2type=N'COLUMN',@level2name=N'MaMon'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[THUCDON].[TenMon]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'THUCDON', @level2type=N'COLUMN',@level2name=N'TenMon'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[THUCDON].[DonGia]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'THUCDON', @level2type=N'COLUMN',@level2name=N'DonGia'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[THUCDON]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'THUCDON'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'CSDL_tam.[THUCDON].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'THUCDON', @level2type=N'CONSTRAINT',@level2name=N'THUCDON$PrimaryKey'
GO
USE [master]
GO
ALTER DATABASE [qlBH1] SET  READ_WRITE 
GO
