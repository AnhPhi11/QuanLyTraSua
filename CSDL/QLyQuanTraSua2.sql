USE [QLTraSua2]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 07-30-2022 5:28:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaCV] [nvarchar](20) NOT NULL,
	[TenCV] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTHD]    Script Date: 07-30-2022 5:28:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHD](
	[maHD] [nvarchar](10) NOT NULL,
	[maSP] [nvarchar](10) NOT NULL,
	[maSize] [nvarchar](5) NOT NULL,
	[TenSP] [nvarchar](50) NULL,
	[TenSize] [nvarchar](30) NULL,
	[SoLuong] [int] NULL,
	[GiaBan] [int] NULL,
	[ThanhTien] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[maHD] ASC,
	[maSP] ASC,
	[maSize] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTSP]    Script Date: 07-30-2022 5:28:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTSP](
	[MaCTSP] [nvarchar](50) NULL,
	[maSP] [nvarchar](10) NOT NULL,
	[maSize] [nvarchar](5) NOT NULL,
	[giaban] [int] NULL,
	[soluong] [int] NULL,
	[Hinh] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[maSP] ASC,
	[maSize] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 07-30-2022 5:28:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [nvarchar](10) NOT NULL,
	[NgayLap] [datetime] NULL,
	[ThanhTien] [int] NULL,
	[maNV] [nvarchar](10) NULL,
	[maKH] [nvarchar](10) NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 07-30-2022 5:28:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nvarchar](10) NOT NULL,
	[HoTenKH] [nvarchar](100) NULL,
	[SDT] [nvarchar](10) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiSP]    Script Date: 07-30-2022 5:28:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSP](
	[MaLoai] [nvarchar](20) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 07-30-2022 5:28:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [nvarchar](10) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[SDT] [nvarchar](10) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[Email] [nvarchar](50) NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 07-30-2022 5:28:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nvarchar](10) NOT NULL,
	[HoTenNV] [nvarchar](100) NULL,
	[NgSinh] [date] NULL,
	[DiaChi] [nvarchar](100) NULL,
	[SDT] [nvarchar](10) NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[ChucVu] [nvarchar](20) NULL,
	[NgayVaoLam] [date] NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 07-30-2022 5:28:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [nvarchar](10) NOT NULL,
	[TenSP] [nvarchar](50) NULL,
	[GiaNhap] [int] NULL,
	[maNCC] [nvarchar](10) NULL,
	[maLoai] [nvarchar](20) NULL,
	[Hinh] [nvarchar](max) NULL,
	[TrangThai] [int] NULL,
	[SoLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Size]    Script Date: 07-30-2022 5:28:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Size](
	[MaSize] [nvarchar](5) NOT NULL,
	[TenSize] [nvarchar](30) NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSize] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 07-30-2022 5:28:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenTK] [nvarchar](30) NOT NULL,
	[MatKhau] [nvarchar](30) NULL,
	[LoaiTK] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[TenTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[ChucVu] ([MaCV], [TenCV]) VALUES (N'CV01', N'Quản Lí')
INSERT [dbo].[ChucVu] ([MaCV], [TenCV]) VALUES (N'CV02', N'Nhân Viên')
INSERT [dbo].[CTHD] ([maHD], [maSP], [maSize], [TenSP], [TenSize], [SoLuong], [GiaBan], [ThanhTien]) VALUES (N'HD02', N'SP01', N'SZ01', N'Trà Đào', N'M', 1, 48000, 48000)
INSERT [dbo].[CTHD] ([maHD], [maSP], [maSize], [TenSP], [TenSize], [SoLuong], [GiaBan], [ThanhTien]) VALUES (N'HD03', N'SP01', N'SZ01', N'Trà Đào', N'M', 1, 48000, 48000)
INSERT [dbo].[CTHD] ([maHD], [maSP], [maSize], [TenSP], [TenSize], [SoLuong], [GiaBan], [ThanhTien]) VALUES (N'HD03', N'SP01', N'SZ02', N'Trà Đào', N'L', 2, 58000, 116000)
INSERT [dbo].[CTHD] ([maHD], [maSP], [maSize], [TenSP], [TenSize], [SoLuong], [GiaBan], [ThanhTien]) VALUES (N'HD04', N'SP01', N'SZ01', N'Trà Đào', N'M', 31, 48000, 1488000)
INSERT [dbo].[CTHD] ([maHD], [maSP], [maSize], [TenSP], [TenSize], [SoLuong], [GiaBan], [ThanhTien]) VALUES (N'HD04', N'SP01', N'SZ02', N'Trà Đào', N'L', 2, 58000, 116000)
INSERT [dbo].[CTHD] ([maHD], [maSP], [maSize], [TenSP], [TenSize], [SoLuong], [GiaBan], [ThanhTien]) VALUES (N'HD05', N'SP01', N'SZ01', N'Trà Đào', N'M', 3, 48000, 144000)
INSERT [dbo].[CTHD] ([maHD], [maSP], [maSize], [TenSP], [TenSize], [SoLuong], [GiaBan], [ThanhTien]) VALUES (N'HD06', N'SP01', N'SZ01', N'Trà Đào', N'M', 1, 48000, 48000)
INSERT [dbo].[CTHD] ([maHD], [maSP], [maSize], [TenSP], [TenSize], [SoLuong], [GiaBan], [ThanhTien]) VALUES (N'HD06', N'SP01', N'SZ02', N'Trà Đào', N'L', 2, 58000, 116000)
INSERT [dbo].[CTHD] ([maHD], [maSP], [maSize], [TenSP], [TenSize], [SoLuong], [GiaBan], [ThanhTien]) VALUES (N'HD07', N'SP01', N'SZ01', N'Trà Đào', N'M', 2, 48000, 96000)
INSERT [dbo].[CTHD] ([maHD], [maSP], [maSize], [TenSP], [TenSize], [SoLuong], [GiaBan], [ThanhTien]) VALUES (N'HD07', N'SP01', N'SZ02', N'Trà Đào', N'L', 1, 58000, 58000)
INSERT [dbo].[CTHD] ([maHD], [maSP], [maSize], [TenSP], [TenSize], [SoLuong], [GiaBan], [ThanhTien]) VALUES (N'HD08', N'SP01', N'SZ01', N'Trà Đào', N'M', 2, 48000, 96000)
INSERT [dbo].[CTHD] ([maHD], [maSP], [maSize], [TenSP], [TenSize], [SoLuong], [GiaBan], [ThanhTien]) VALUES (N'HD08', N'SP01', N'SZ02', N'Trà Đào', N'L', 1, 58000, 58000)
INSERT [dbo].[CTHD] ([maHD], [maSP], [maSize], [TenSP], [TenSize], [SoLuong], [GiaBan], [ThanhTien]) VALUES (N'HD09', N'SP01', N'SZ01', N'Trà Đào', N'M', 1, 48000, 48000)
INSERT [dbo].[CTHD] ([maHD], [maSP], [maSize], [TenSP], [TenSize], [SoLuong], [GiaBan], [ThanhTien]) VALUES (N'HD09', N'SP01', N'SZ02', N'Trà Đào', N'L', 1, 58000, 58000)
INSERT [dbo].[CTHD] ([maHD], [maSP], [maSize], [TenSP], [TenSize], [SoLuong], [GiaBan], [ThanhTien]) VALUES (N'HD10', N'SP01', N'SZ01', N'Trà Đào', N'M', 3, 48000, 144000)
INSERT [dbo].[CTHD] ([maHD], [maSP], [maSize], [TenSP], [TenSize], [SoLuong], [GiaBan], [ThanhTien]) VALUES (N'HD10', N'SP01', N'SZ02', N'Trà Đào', N'L', 2, 58000, 116000)
INSERT [dbo].[CTSP] ([MaCTSP], [maSP], [maSize], [giaban], [soluong], [Hinh]) VALUES (N'SP01.SZ01', N'SP01', N'SZ01', 24000, 30, N'tradao.png')
INSERT [dbo].[CTSP] ([MaCTSP], [maSP], [maSize], [giaban], [soluong], [Hinh]) VALUES (N'SP01.SZ02', N'SP01', N'SZ02', 34000, 28, N'tradao.png')
INSERT [dbo].[CTSP] ([MaCTSP], [maSP], [maSize], [giaban], [soluong], [Hinh]) VALUES (N'SP01.SZ03', N'SP01', N'SZ03', 44000, 30, N'tradao.png')
INSERT [dbo].[CTSP] ([MaCTSP], [maSP], [maSize], [giaban], [soluong], [Hinh]) VALUES (N'SP02.SZ01', N'SP02', N'SZ01', 45000, 30, N'tradao.png')
INSERT [dbo].[CTSP] ([MaCTSP], [maSP], [maSize], [giaban], [soluong], [Hinh]) VALUES (N'SP02.SZ02', N'SP02', N'SZ02', 55000, 30, N'tradao.png')
INSERT [dbo].[CTSP] ([MaCTSP], [maSP], [maSize], [giaban], [soluong], [Hinh]) VALUES (N'SP02.SZ03', N'SP02', N'SZ03', 65000, 20, N'tradao.png')
INSERT [dbo].[CTSP] ([MaCTSP], [maSP], [maSize], [giaban], [soluong], [Hinh]) VALUES (N'SP03.SZ01', N'SP03', N'SZ01', 60000, 30, N'cafeda.jpg')
INSERT [dbo].[CTSP] ([MaCTSP], [maSP], [maSize], [giaban], [soluong], [Hinh]) VALUES (N'SP03.SZ02', N'SP03', N'SZ02', 70000, 30, N'cafeda.jpg')
INSERT [dbo].[CTSP] ([MaCTSP], [maSP], [maSize], [giaban], [soluong], [Hinh]) VALUES (N'SP03.SZ03', N'SP03', N'SZ03', 80000, 30, N'cafeda.jpg')
INSERT [dbo].[CTSP] ([MaCTSP], [maSP], [maSize], [giaban], [soluong], [Hinh]) VALUES (N'SP04.SZ01', N'SP04', N'SZ01', 57000, 50, N'hongtrasua.png')
INSERT [dbo].[CTSP] ([MaCTSP], [maSP], [maSize], [giaban], [soluong], [Hinh]) VALUES (N'SP04.SZ02', N'SP04', N'SZ02', 67000, 20, N'hongtrasua.png')
INSERT [dbo].[CTSP] ([MaCTSP], [maSP], [maSize], [giaban], [soluong], [Hinh]) VALUES (N'SP04.SZ03', N'SP04', N'SZ03', 77000, 30, N'hongtrasua.png')
INSERT [dbo].[CTSP] ([MaCTSP], [maSP], [maSize], [giaban], [soluong], [Hinh]) VALUES (N'SP05.SZ01', N'SP05', N'SZ01', 36000, 30, N'cafesua.jpg')
INSERT [dbo].[CTSP] ([MaCTSP], [maSP], [maSize], [giaban], [soluong], [Hinh]) VALUES (N'SP05.SZ02', N'SP05', N'SZ02', 46000, 30, N'cafesua.jpg')
INSERT [dbo].[CTSP] ([MaCTSP], [maSP], [maSize], [giaban], [soluong], [Hinh]) VALUES (N'SP05.SZ03', N'SP05', N'SZ03', 56000, 30, N'cafesua.jpg')
INSERT [dbo].[CTSP] ([MaCTSP], [maSP], [maSize], [giaban], [soluong], [Hinh]) VALUES (N'SP06.SZ01', N'SP06', N'SZ01', 24000, 30, N'cafeda.jpg')
INSERT [dbo].[CTSP] ([MaCTSP], [maSP], [maSize], [giaban], [soluong], [Hinh]) VALUES (N'SP06.SZ02', N'SP06', N'SZ02', 34000, 30, N'cafeda.jpg')
INSERT [dbo].[CTSP] ([MaCTSP], [maSP], [maSize], [giaban], [soluong], [Hinh]) VALUES (N'SP06.SZ03', N'SP06', N'SZ03', 44000, 30, N'cafeda.jpg')
INSERT [dbo].[CTSP] ([MaCTSP], [maSP], [maSize], [giaban], [soluong], [Hinh]) VALUES (N'SP07.SZ01', N'SP07', N'SZ01', 60000, 50, N'cafetrung.png')
INSERT [dbo].[CTSP] ([MaCTSP], [maSP], [maSize], [giaban], [soluong], [Hinh]) VALUES (N'SP07.SZ02', N'SP07', N'SZ02', 70000, 30, N'cafetrung.png')
INSERT [dbo].[CTSP] ([MaCTSP], [maSP], [maSize], [giaban], [soluong], [Hinh]) VALUES (N'SP07.SZ03', N'SP07', N'SZ03', 80000, 30, N'cafetrung.png')
INSERT [dbo].[CTSP] ([MaCTSP], [maSP], [maSize], [giaban], [soluong], [Hinh]) VALUES (N'SP08.SZ01', N'SP08', N'SZ01', 21000, 30, N'sting.png')
INSERT [dbo].[CTSP] ([MaCTSP], [maSP], [maSize], [giaban], [soluong], [Hinh]) VALUES (N'SP08.SZ02', N'SP08', N'SZ02', 31000, 20, N'sting.png')
INSERT [dbo].[CTSP] ([MaCTSP], [maSP], [maSize], [giaban], [soluong], [Hinh]) VALUES (N'SP08.SZ03', N'SP08', N'SZ03', 41000, 30, N'sting.png')
INSERT [dbo].[CTSP] ([MaCTSP], [maSP], [maSize], [giaban], [soluong], [Hinh]) VALUES (N'SP09.SZ01', N'SP09', N'SZ01', 21000, 20, N'1')
INSERT [dbo].[CTSP] ([MaCTSP], [maSP], [maSize], [giaban], [soluong], [Hinh]) VALUES (N'SP09.SZ02', N'SP09', N'SZ02', 31000, 10, N'1')
INSERT [dbo].[CTSP] ([MaCTSP], [maSP], [maSize], [giaban], [soluong], [Hinh]) VALUES (N'SP09.SZ03', N'SP09', N'SZ03', 36000, 20, N'1')
INSERT [dbo].[CTSP] ([MaCTSP], [maSP], [maSize], [giaban], [soluong], [Hinh]) VALUES (N'SP10.SZ01', N'SP10', N'SZ01', 18000, 30, N'0')
INSERT [dbo].[CTSP] ([MaCTSP], [maSP], [maSize], [giaban], [soluong], [Hinh]) VALUES (N'SP10.SZ02', N'SP10', N'SZ02', 28000, 20, N'0')
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [ThanhTien], [maNV], [maKH], [TrangThai]) VALUES (N'HD01', CAST(N'2021-01-21 06:32:00.000' AS DateTime), 210000, N'NV01', N'KH01', 1)
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [ThanhTien], [maNV], [maKH], [TrangThai]) VALUES (N'HD02', CAST(N'2022-07-28 00:27:03.000' AS DateTime), 48000, N'NV01', N'KH01', 1)
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [ThanhTien], [maNV], [maKH], [TrangThai]) VALUES (N'HD03', CAST(N'2022-07-28 20:15:30.000' AS DateTime), 96000, N'NV02', N'KH01', 1)
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [ThanhTien], [maNV], [maKH], [TrangThai]) VALUES (N'HD04', CAST(N'2022-07-28 21:17:28.000' AS DateTime), 1604000, N'NV02', N'KH08', 1)
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [ThanhTien], [maNV], [maKH], [TrangThai]) VALUES (N'HD05', CAST(N'2022-07-28 21:35:32.000' AS DateTime), 144000, N'NV01', N'KH06', 0)
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [ThanhTien], [maNV], [maKH], [TrangThai]) VALUES (N'HD06', CAST(N'2022-07-28 21:48:39.000' AS DateTime), 164000, N'NV06', N'KH11', 0)
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [ThanhTien], [maNV], [maKH], [TrangThai]) VALUES (N'HD07', CAST(N'2022-07-29 10:35:18.000' AS DateTime), 154000, N'NV01', N'KH03', 1)
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [ThanhTien], [maNV], [maKH], [TrangThai]) VALUES (N'HD08', CAST(N'2022-07-29 10:38:38.000' AS DateTime), 154000, N'NV02', N'KH03', 1)
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [ThanhTien], [maNV], [maKH], [TrangThai]) VALUES (N'HD09', CAST(N'2022-07-29 10:40:57.000' AS DateTime), 106000, N'NV02', N'KH01', 1)
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [ThanhTien], [maNV], [maKH], [TrangThai]) VALUES (N'HD10', CAST(N'2022-07-29 11:03:16.000' AS DateTime), 260000, N'NV02', N'KH01', 0)
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [SDT], [DiaChi], [TrangThai]) VALUES (N'KH01', N'Lê Đức Minh', N'0909111222', N'TPHCM', 1)
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [SDT], [DiaChi], [TrangThai]) VALUES (N'KH02', N'Trần Phi Long', N'0909111333', N'Đồng Nai', 1)
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [SDT], [DiaChi], [TrangThai]) VALUES (N'KH03', N'Nguyễn Công Thành', N'0909222222', N'Long An', 1)
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [SDT], [DiaChi], [TrangThai]) VALUES (N'KH04', N'Đào Lâm Quang Qui', N'0909331222', N'Long An', 1)
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [SDT], [DiaChi], [TrangThai]) VALUES (N'KH05', N'Lý Tuấn Thành', N'0908111222', N'Đồng Tháp', 1)
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [SDT], [DiaChi], [TrangThai]) VALUES (N'KH06', N'Nguyễn Nhật Trường', N'0909123456', N'TPHCM', 1)
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [SDT], [DiaChi], [TrangThai]) VALUES (N'KH07', N'Nguyễn Trung Nghĩa', N'0791231231', N'Đồng Nai', 1)
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [SDT], [DiaChi], [TrangThai]) VALUES (N'KH08', N'Phạm Thị Bội Ngọc', N'0794564561', N'Tiền Giang', 1)
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [SDT], [DiaChi], [TrangThai]) VALUES (N'KH09', N'Huỳnh Hữu Nghĩa', N'0761234566', N'Tiền Giang', 1)
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [SDT], [DiaChi], [TrangThai]) VALUES (N'KH10', N'Trần Thanh Lâm', N'0791471623', N'Vũng Tàu', 1)
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [SDT], [DiaChi], [TrangThai]) VALUES (N'KH11', N'Lê Hồ Việt Quang', N'0791471624', N'TPHCM', 1)
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [SDT], [DiaChi], [TrangThai]) VALUES (N'KH12', N'Nguyen Van A', N'123123123', N'test', 1)
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [SDT], [DiaChi], [TrangThai]) VALUES (N'KH13', N'Nguyen Van B', N'0791243343', N'Dong Nai', 0)
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [SDT], [DiaChi], [TrangThai]) VALUES (N'KH14', N'Nguyen Van C', N'0791232132', N'HCM', 1)
INSERT [dbo].[LoaiSP] ([MaLoai], [TenLoai], [TrangThai]) VALUES (N'LoaiSP01', N'Trà', 1)
INSERT [dbo].[LoaiSP] ([MaLoai], [TenLoai], [TrangThai]) VALUES (N'LoaiSP02', N'Cafe', 1)
INSERT [dbo].[LoaiSP] ([MaLoai], [TenLoai], [TrangThai]) VALUES (N'LoaiSP03', N'Nước Giải Khát', 1)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [DiaChi], [Email], [TrangThai]) VALUES (N'NCC01', N'Trà Chính Sơn', N'0243586456', N'257 Quan Nhân, quận Thanh Xuân, Hà Nội. ', N'trachinhson@gmail.com', 1)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [DiaChi], [Email], [TrangThai]) VALUES (N'NCC02', N'Đại Lý Nước Giải Khát Cẩm', N'0283865182', N'Hoà Hưng, Phường 12, Quận 10, Thành phố Hồ Chí Minh. ', N'nuocgiaikhatcam@gmail.com', 1)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [DiaChi], [Email], [TrangThai]) VALUES (N'NCC03', N'Test', N'0792323232', N'Test2', N'test@gmail.com', 0)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgSinh], [DiaChi], [SDT], [GioiTinh], [ChucVu], [NgayVaoLam], [TrangThai]) VALUES (N'NV01', N'Nguyễn Văn Anh Tuấn', CAST(N'2002-01-19' AS Date), N'TPHCM', N'0982527982', N'Nam', N'CV01', CAST(N'2021-01-21' AS Date), 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgSinh], [DiaChi], [SDT], [GioiTinh], [ChucVu], [NgayVaoLam], [TrangThai]) VALUES (N'NV02', N'Nguyễn Anh Phi', CAST(N'2002-08-11' AS Date), N'Đà Nẵng', N'0973776072', N'Nam', N'CV01', CAST(N'2021-01-21' AS Date), 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgSinh], [DiaChi], [SDT], [GioiTinh], [ChucVu], [NgayVaoLam], [TrangThai]) VALUES (N'NV03', N'Nguyễn Thanh Thủy', CAST(N'1999-02-16' AS Date), N'Cà Mau', N'0917749254', N'Nữ', N'CV02', CAST(N'2021-01-21' AS Date), 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgSinh], [DiaChi], [SDT], [GioiTinh], [ChucVu], [NgayVaoLam], [TrangThai]) VALUES (N'NV04', N'Lê Thị Duyên', CAST(N'2004-01-29' AS Date), N'Đà Lạt', N'0904770053', N'Nữ', N'CV02', CAST(N'2021-01-21' AS Date), 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgSinh], [DiaChi], [SDT], [GioiTinh], [ChucVu], [NgayVaoLam], [TrangThai]) VALUES (N'NV05', N'Trần Thị Ngọc Bich', CAST(N'1996-01-19' AS Date), N'Hà Nội', N'0974880788', N'Nữ', N'CV02', CAST(N'2021-01-30' AS Date), 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgSinh], [DiaChi], [SDT], [GioiTinh], [ChucVu], [NgayVaoLam], [TrangThai]) VALUES (N'NV06', N'Lê Thị Ngọc Nhi', CAST(N'1999-01-11' AS Date), N'Nam Định', N'0983888611', N'Nữ', N'CV02', CAST(N'2021-02-25' AS Date), 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgSinh], [DiaChi], [SDT], [GioiTinh], [ChucVu], [NgayVaoLam], [TrangThai]) VALUES (N'NV07', N'Nguyễn Ngọc Phụng', CAST(N'2000-02-12' AS Date), N'Bình Định', N'0984603663', N'Nữ', N'CV02', CAST(N'2021-06-11' AS Date), 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgSinh], [DiaChi], [SDT], [GioiTinh], [ChucVu], [NgayVaoLam], [TrangThai]) VALUES (N'NV08', N'Lê Thanh Thủy', CAST(N'2003-03-13' AS Date), N'Tây Ninh', N'0986375176', N'Nữ', N'CV02', CAST(N'2021-04-15' AS Date), 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [NgSinh], [DiaChi], [SDT], [GioiTinh], [ChucVu], [NgayVaoLam], [TrangThai]) VALUES (N'NV09', N'Nguyen Van B', CAST(N'2002-01-31' AS Date), N'HCM', N'0791231234', N'Nam', N'CV01', CAST(N'2022-07-25' AS Date), 0)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [maNCC], [maLoai], [Hinh], [TrangThai], [SoLuong]) VALUES (N'SP01', N'Trà Đào', 16000, N'NCC01', N'LoaiSP01', N'tradao.png', 1, 84)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [maNCC], [maLoai], [Hinh], [TrangThai], [SoLuong]) VALUES (N'SP02', N'Trà Sữa Truyền Thống', 15000, N'NCC01', N'LoaiSP01', N'trasuatruyenthong.jpg', 1, 80)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [maNCC], [maLoai], [Hinh], [TrangThai], [SoLuong]) VALUES (N'SP03', N'Trà Sữa Đường Đen', 20000, N'NCC01', N'LoaiSP01', N'trasuaduongden.png', 1, 90)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [maNCC], [maLoai], [Hinh], [TrangThai], [SoLuong]) VALUES (N'SP04', N'Hồng Trà Sữa', 19000, N'NCC01', N'LoaiSP01', N'hongtrasua.png', 1, 100)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [maNCC], [maLoai], [Hinh], [TrangThai], [SoLuong]) VALUES (N'SP05', N'Cafe Sữa Đá', 12000, N'NCC01', N'LoaiSP02', N'cafesua.jpg', 1, 90)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [maNCC], [maLoai], [Hinh], [TrangThai], [SoLuong]) VALUES (N'SP06', N'Cafe Đá', 8000, N'NCC02', N'LoaiSP02', N'cafeda.jpg', 1, 90)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [maNCC], [maLoai], [Hinh], [TrangThai], [SoLuong]) VALUES (N'SP07', N'Cafe Trứng', 20000, N'NCC01', N'LoaiSP02', N'cafetrung.png', 1, 80)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [maNCC], [maLoai], [Hinh], [TrangThai], [SoLuong]) VALUES (N'SP08', N'Sting', 8000, N'NCC02', N'LoaiSP03', N'sting.png', 1, 80)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [maNCC], [maLoai], [Hinh], [TrangThai], [SoLuong]) VALUES (N'SP09', N'7UP', 7000, N'NCC02', N'LoaiSP03', N'sting.png', 1, 85)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [maNCC], [maLoai], [Hinh], [TrangThai], [SoLuong]) VALUES (N'SP10', N'tét', 6000, N'', N'', N'sting.png', 0, 50)
INSERT [dbo].[Size] ([MaSize], [TenSize], [TrangThai]) VALUES (N'SZ01', N'M', 1)
INSERT [dbo].[Size] ([MaSize], [TenSize], [TrangThai]) VALUES (N'SZ02', N'L', 1)
INSERT [dbo].[Size] ([MaSize], [TenSize], [TrangThai]) VALUES (N'SZ03', N'XL', 1)
INSERT [dbo].[TaiKhoan] ([TenTK], [MatKhau], [LoaiTK]) VALUES (N'admin', N'123', 0)
INSERT [dbo].[TaiKhoan] ([TenTK], [MatKhau], [LoaiTK]) VALUES (N'phi', N'123', 0)
INSERT [dbo].[TaiKhoan] ([TenTK], [MatKhau], [LoaiTK]) VALUES (N'tuan', N'123', 1)
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_HD] FOREIGN KEY([maHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [FK_CTHD_HD]
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_S] FOREIGN KEY([maSize])
REFERENCES [dbo].[Size] ([MaSize])
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [FK_CTHD_S]
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_SP] FOREIGN KEY([maSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [FK_CTHD_SP]
GO
ALTER TABLE [dbo].[CTSP]  WITH CHECK ADD  CONSTRAINT [FK_CT_S] FOREIGN KEY([maSize])
REFERENCES [dbo].[Size] ([MaSize])
GO
ALTER TABLE [dbo].[CTSP] CHECK CONSTRAINT [FK_CT_S]
GO
ALTER TABLE [dbo].[CTSP]  WITH CHECK ADD  CONSTRAINT [FK_CT_SP] FOREIGN KEY([maSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[CTSP] CHECK CONSTRAINT [FK_CT_SP]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HD_KH] FOREIGN KEY([maKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HD_KH]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HD_NV] FOREIGN KEY([maNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HD_NV]
GO
