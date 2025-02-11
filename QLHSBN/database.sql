USE [master]
GO
/****** Object:  Database [QLBN]    Script Date: 2/11/2025 5:25:07 PM ******/
CREATE DATABASE [QLBN]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLBN', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QLBN.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLBN_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QLBN_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QLBN] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLBN].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLBN] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLBN] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLBN] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLBN] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLBN] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLBN] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLBN] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLBN] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLBN] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLBN] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLBN] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLBN] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLBN] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLBN] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLBN] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLBN] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLBN] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLBN] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLBN] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLBN] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLBN] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLBN] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLBN] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLBN] SET  MULTI_USER 
GO
ALTER DATABASE [QLBN] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLBN] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLBN] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLBN] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLBN] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLBN] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QLBN] SET QUERY_STORE = ON
GO
ALTER DATABASE [QLBN] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QLBN]
GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 2/11/2025 5:25:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhanvien](
	[nhanvien_id] [int] IDENTITY(1,1) NOT NULL,
	[ma_nhanvien] [nvarchar](50) NOT NULL,
	[hoten] [nvarchar](50) NOT NULL,
	[chucvu] [nvarchar](50) NOT NULL,
	[ngaysinh] [datetime] NOT NULL,
	[sdt] [nvarchar](50) NOT NULL,
	[gioitinh] [nvarchar](50) NOT NULL,
	[hocvan] [nvarchar](50) NULL,
	[chuyenkhoa] [nvarchar](50) NULL,
	[exp] [int] NULL,
	[taikhoan] [nvarchar](50) NOT NULL,
	[matkhau] [nvarchar](50) NOT NULL,
	[ngaytao] [datetime] NOT NULL,
	[trangthai] [int] NOT NULL,
 CONSTRAINT [PK_nhanvien] PRIMARY KEY CLUSTERED 
(
	[nhanvien_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hsbn]    Script Date: 2/11/2025 5:25:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hsbn](
	[hs_id] [int] IDENTITY(1,1) NOT NULL,
	[ma_hs] [nvarchar](50) NOT NULL,
	[hoten] [nvarchar](50) NOT NULL,
	[ngaysinh] [datetime] NOT NULL,
	[bhyt] [nvarchar](50) NOT NULL,
	[sdt] [nvarchar](50) NULL,
	[cccd] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[gioitinh] [nvarchar](50) NULL,
	[nhanvien_id] [int] NOT NULL,
	[ngaytao] [datetime] NOT NULL,
	[trangthai] [int] NOT NULL,
 CONSTRAINT [PK_hsbn] PRIMARY KEY CLUSTERED 
(
	[hs_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dangkykham]    Script Date: 2/11/2025 5:25:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dangkykham](
	[hsdk_khamid] [int] IDENTITY(1,1) NOT NULL,
	[hs_id] [int] NOT NULL,
	[nhanvien_id] [int] NULL,
	[dichvu_id] [int] NULL,
	[ngaytao] [date] NULL,
	[ngaydangky] [date] NULL,
	[phieuthu_id] [int] NULL,
	[thongtin] [nvarchar](255) NULL,
	[trangthai] [int] NULL,
 CONSTRAINT [PK_dangkykham] PRIMARY KEY CLUSTERED 
(
	[hsdk_khamid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[view_hsdk_kham]    Script Date: 2/11/2025 5:25:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[view_hsdk_kham]
AS
SELECT 
    a.hsdk_khamid, 
    b.hoten, 
    c.hoten AS nguoikham, 
    a.ngaydangky, 
    a.thongtin,
    CASE
        WHEN a.trangthai = 1 THEN N'Đăng ký'
        WHEN a.trangthai = 2 THEN N'Đã khám'
    END AS trangthai
FROM dangkykham AS a
INNER JOIN hsbn AS b ON a.hs_id = b.hs_id  -- assuming hs_id links the two tables
INNER JOIN nhanvien AS c ON a.nhanvien_id = c.nhanvien_id  -- assuming nhanvien_id links the two tables
WHERE a.trangthai = 2
  AND CAST(a.ngaydangky AS DATE) = CAST(GETDATE() AS DATE);
GO
/****** Object:  View [dbo].[view_truockham]    Script Date: 2/11/2025 5:25:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create view [dbo].[view_truockham]
as
select hsdk_khamid as STT, b.ma_hs,b.hoten, b.bhyt, b.cccd, a.ngaytao, ngaydangky
from dangkykham a, hsbn b
where a.hs_id = b.hs_id and
a.trangthai = 1
  AND CAST(a.ngaydangky AS DATE) = CAST(GETDATE() AS DATE);
GO
/****** Object:  Table [dbo].[phieuthu]    Script Date: 2/11/2025 5:25:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phieuthu](
	[phieuthu_id] [int] IDENTITY(1,1) NOT NULL,
	[nhanvien_id] [int] NULL,
	[dichvu_id] [int] NULL,
	[hs_id] [int] NULL,
	[ngaytao] [date] NOT NULL,
	[ngaythu] [date] NOT NULL,
	[sotien] [int] NOT NULL,
	[ghichu] [nvarchar](255) NULL,
	[trangthai] [int] NOT NULL,
 CONSTRAINT [PK_phieuthu] PRIMARY KEY CLUSTERED 
(
	[phieuthu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dichvu]    Script Date: 2/11/2025 5:25:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dichvu](
	[dichvu_id] [int] IDENTITY(1,1) NOT NULL,
	[ma_dichvu] [nvarchar](50) NOT NULL,
	[ten_dichvu] [nvarchar](50) NOT NULL,
	[gia_dichvu] [int] NOT NULL,
	[trangthai] [int] NOT NULL,
 CONSTRAINT [PK_dichvu] PRIMARY KEY CLUSTERED 
(
	[dichvu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[view_baocaodoanhthu]    Script Date: 2/11/2025 5:25:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[view_baocaodoanhthu]
as
select phieuthu_id as STT, b.hoten as nguoithu, c.ten_dichvu, d.hoten as benhnhan,a.sotien,a.ghichu, a.ngaythu, a.ngaytao
from phieuthu a, nhanvien b, dichvu c, hsbn d
where a.trangthai=1 and a.dichvu_id = c.dichvu_id and a.nhanvien_id = b.nhanvien_id and a.hs_id=d.hs_id
GO
/****** Object:  View [dbo].[view_phieuthutien]    Script Date: 2/11/2025 5:25:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create view [dbo].[view_phieuthutien]
as
select phieuthu_id as STT, b.hoten, c.hoten as nhanvien, a.ngaythu, sotien   ,
case 
when a.trangthai = 1 then N'Đang hoạt động'
else N'Đã hủy'
end as trangthai
from phieuthu as a, hsbn as b, nhanvien as c

where a.hs_id = b.hs_id and a.nhanvien_id = c.nhanvien_id 

GO
/****** Object:  View [dbo].[view_thudichvu]    Script Date: 2/11/2025 5:25:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create view [dbo].[view_thudichvu]
as
select a.phieuthu_id as STT, a.ngaythu, b.ten_dichvu, c.hoten, a.sotien,
case 
when a.trangthai = 1 then N'Đang hoạt động'
else N'Đã hủy'
end as trangthai
from phieuthu a, dichvu b, nhanvien c
where  a.dichvu_id = b.dichvu_id and a.nhanvien_id = c.nhanvien_id


GO
/****** Object:  Table [dbo].[phieuxetnghiem]    Script Date: 2/11/2025 5:25:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phieuxetnghiem](
	[phieuxn_id] [int] IDENTITY(1,1) NOT NULL,
	[ma_phieu] [nvarchar](50) NOT NULL,
	[hs_id] [int] NOT NULL,
	[dichvu_id] [int] NOT NULL,
	[ketqua] [nvarchar](50) NULL,
	[ngaytao] [datetime] NULL,
	[nhanvien_id] [int] NOT NULL,
	[trangthai] [int] NOT NULL,
 CONSTRAINT [PK_phieuxetnghiem] PRIMARY KEY CLUSTERED 
(
	[phieuxn_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[view_phieuxetnghiem]    Script Date: 2/11/2025 5:25:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[view_phieuxetnghiem] AS
SELECT        
    dbo.phieuxetnghiem.phieuxn_id, 
    dbo.phieuxetnghiem.ma_phieu, 
    dbo.hsbn.hoten AS ten_benh_nhan, 
    dbo.dichvu.ten_dichvu, 
    dbo.nhanvien.hoten AS ten_nhan_vien, 
    dbo.phieuxetnghiem.ketqua, 
    dbo.phieuxetnghiem.ngaytao, 
    CASE 
        WHEN dbo.phieuxetnghiem.trangthai = 0 THEN N'Hủy kết quả' 
        WHEN dbo.phieuxetnghiem.trangthai = 1 THEN N'Đăng ký' 
        WHEN dbo.phieuxetnghiem.trangthai = 2 THEN N'Đã xét nghiệm' 
        ELSE N'Đã thu tiền' 
    END AS trangthai
FROM            
    dbo.phieuxetnghiem 
INNER JOIN dbo.dichvu ON dbo.phieuxetnghiem.dichvu_id = dbo.dichvu.dichvu_id 
INNER JOIN dbo.hsbn ON dbo.phieuxetnghiem.hs_id = dbo.hsbn.hs_id 
INNER JOIN dbo.nhanvien ON dbo.phieuxetnghiem.nhanvien_id = dbo.nhanvien.nhanvien_id;
GO
/****** Object:  Table [dbo].[phongbenh]    Script Date: 2/11/2025 5:25:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phongbenh](
	[phong_id] [int] IDENTITY(1,1) NOT NULL,
	[maphongbenh] [nvarchar](50) NOT NULL,
	[tenphongbenh] [nvarchar](50) NOT NULL,
	[loaiphongbenh] [nvarchar](50) NOT NULL,
	[gia] [int] NOT NULL,
	[trangthai] [int] NOT NULL,
	[sogiuong_moi] [int] NOT NULL,
 CONSTRAINT [PK_phongbenh] PRIMARY KEY CLUSTERED 
(
	[phong_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[view_phongbenh]    Script Date: 2/11/2025 5:25:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[view_phongbenh]
as
SELECT        phong_id AS STT, maphongbenh, tenphongbenh, loaiphongbenh, gia, sogiuong_moi,
case

when trangthai = 1 then N'Còn trống'
when trangthai = 2 then N'Đầy'
when trangthai = 0  then N'Ngừng'
end as trangthai
FROM            phongbenh
GO
/****** Object:  Table [dbo].[phieunhapvien]    Script Date: 2/11/2025 5:25:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phieunhapvien](
	[nhapvien_id] [int] IDENTITY(1,1) NOT NULL,
	[hs_id] [int] NOT NULL,
	[nhanvien_id] [int] NOT NULL,
	[phong_id] [int] NOT NULL,
	[ngaytao] [date] NULL,
	[ngaynhapvien] [date] NOT NULL,
	[ngayxuatvien] [date] NULL,
	[tongtien] [int] NULL,
	[trangthai] [int] NOT NULL,
 CONSTRAINT [PK_phieunhapvien] PRIMARY KEY CLUSTERED 
(
	[nhapvien_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[view_nhapvien]    Script Date: 2/11/2025 5:25:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[view_nhapvien]
as
SELECT        a.nhapvien_id AS STT, d.hoten, a.ngaynhapvien, c.tenphongbenh, a.ngayxuatvien, b.hoten AS nguoitao, 
case
when a.trangthai=1 then N'Chưa thu tiền'
when a.trangthai=2 then N'Xuất viện'
else N'Không xác định'
end as trangthai
FROM            phieunhapvien as a, nhanvien as b, phongbenh as c, hsbn as d
where	a.hs_id = d.hs_id and a.nhanvien_id = b.nhanvien_id and a.phong_id = c.phong_id
GO
/****** Object:  View [dbo].[view_chitietnhapvien]    Script Date: 2/11/2025 5:25:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[view_chitietnhapvien]
as
select ma_phieu, b.ngaytao , ketqua, b.trangthai from phieunhapvien as a, phieuxetnghiem as b
where a.hs_id = b.hs_id
GO
/****** Object:  View [dbo].[view_nhanvien]    Script Date: 2/11/2025 5:25:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[view_nhanvien]
AS
SELECT        nhanvien_id, ma_nhanvien, hoten, chucvu, ngaysinh, sdt, gioitinh, hocvan, chuyenkhoa, exp, taikhoan, ngaytao, 
CASE 
        WHEN trangthai = 1 THEN N'Đang sử dụng' 
        ELSE N'Đã khóa' 
    END AS Trang_thai
FROM            dbo.nhanvien
GO
/****** Object:  Table [dbo].[phongkham]    Script Date: 2/11/2025 5:25:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phongkham](
	[phongkham_id] [int] IDENTITY(1,1) NOT NULL,
	[ma_phongkham] [nvarchar](50) NOT NULL,
	[ten_phongkham] [nvarchar](50) NOT NULL,
	[nhanvien_id] [int] NOT NULL,
	[trangthai] [int] NOT NULL,
 CONSTRAINT [PK_phongkham] PRIMARY KEY CLUSTERED 
(
	[phongkham_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[view_phongkham]    Script Date: 2/11/2025 5:25:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[view_phongkham]
as
SELECT        
     
    dbo.phongkham.phongkham_id, 
    dbo.phongkham.ma_phongkham, 
    dbo.phongkham.ten_phongkham,
	dbo.nhanvien.hoten,
    CASE 
        WHEN dbo.phongkham.trangthai = 1 THEN N'Đang hoạt động'
        WHEN dbo.phongkham.trangthai = 2 THEN N'Ngừng hoạt động'
        ELSE N'Không xác định' 
    END AS trangthai
FROM            
    dbo.nhanvien 
INNER JOIN dbo.phongkham ON dbo.nhanvien.nhanvien_id = dbo.phongkham.nhanvien_id;
GO
/****** Object:  View [dbo].[view_dichvu]    Script Date: 2/11/2025 5:25:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[view_dichvu]
as
SELECT        dichvu_id, ma_dichvu, ten_dichvu, gia_dichvu, 
case
	when trangthai = 1 then N'Đang hoạt động'
	else N'Dừng hoạt động'
end as trangthai

FROM            dbo.dichvu
GO
/****** Object:  View [dbo].[view_hsbn]    Script Date: 2/11/2025 5:25:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE VIEW [dbo].[view_hsbn]
AS
SELECT        hsbn.hs_id, hsbn.ma_hs, hsbn.hoten, hsbn.ngaysinh, hsbn.bhyt, hsbn.sdt, hsbn.cccd, hsbn.diachi, hsbn.gioitinh,hsbn.ngaytao,	nhanvien.hoten AS Nguoitao,
CASE 
        WHEN hsbn.trangthai = 1 THEN N'Đang hoạt động' 
		WHEN hsbn.trangthai = 2 THEN N'Đang khám' 
		WHEN hsbn.trangthai = 3 THEN N'Đang nhập viện'
        ELSE N'Đã khóa' 
    END AS trangthai

FROM            hsbn INNER JOIN
                         nhanvien ON hsbn.nhanvien_id = nhanvien.nhanvien_id
GO
/****** Object:  Table [dbo].[chitiet_nhapvien]    Script Date: 2/11/2025 5:25:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitiet_nhapvien](
	[chitiet_id] [int] IDENTITY(1,1) NOT NULL,
	[nhapvien_id] [int] NOT NULL,
	[dichvu_id] [int] NULL,
	[ghichu] [nvarchar](255) NULL,
	[giatien] [int] NULL,
 CONSTRAINT [PK_chitiet_nhapvien] PRIMARY KEY CLUSTERED 
(
	[chitiet_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[chitiet_toathuoc]    Script Date: 2/11/2025 5:25:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitiet_toathuoc](
	[chitiettoathuoc_id] [int] IDENTITY(1,1) NOT NULL,
	[toathuoc_id] [int] NOT NULL,
	[thuoc_id] [int] NOT NULL,
	[soluong] [int] NOT NULL,
 CONSTRAINT [PK_chitiet_toathuoc] PRIMARY KEY CLUSTERED 
(
	[chitiettoathuoc_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lichsunamvien]    Script Date: 2/11/2025 5:25:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lichsunamvien](
	[lichsu_id] [int] IDENTITY(1,1) NOT NULL,
	[nhapvien_id] [int] NOT NULL,
	[phong_id] [int] NOT NULL,
	[ngayvao] [date] NOT NULL,
	[ngayra] [date] NULL,
	[so_ngay]  AS (datediff(day,[ngayvao],[ngayra])) PERSISTED,
	[trangthai] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[thuoc]    Script Date: 2/11/2025 5:25:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[thuoc](
	[thuoc_id] [int] IDENTITY(1,1) NOT NULL,
	[mathuoc] [nvarchar](50) NOT NULL,
	[tenthuoc] [nvarchar](50) NOT NULL,
	[mota] [nvarchar](250) NULL,
	[thuocbaohiem] [int] NOT NULL,
	[trangthai] [nchar](10) NULL,
 CONSTRAINT [PK_thuoc] PRIMARY KEY CLUSTERED 
(
	[thuoc_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[toathuoc]    Script Date: 2/11/2025 5:25:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[toathuoc](
	[toathuoc_id] [int] IDENTITY(1,1) NOT NULL,
	[tentoathuoc] [nvarchar](50) NOT NULL,
	[hs_id] [int] NOT NULL,
	[ngaytao] [date] NOT NULL,
	[ngayxuattoa] [date] NOT NULL,
	[nhanvien_id] [int] NOT NULL,
	[trangthai] [int] NULL,
 CONSTRAINT [PK_toathuoc] PRIMARY KEY CLUSTERED 
(
	[toathuoc_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[chitiet_nhapvien] ON 
GO
INSERT [dbo].[chitiet_nhapvien] ([chitiet_id], [nhapvien_id], [dichvu_id], [ghichu], [giatien]) VALUES (1, 4, 3, N'demo', 1230321)
GO
INSERT [dbo].[chitiet_nhapvien] ([chitiet_id], [nhapvien_id], [dichvu_id], [ghichu], [giatien]) VALUES (2, 4, 1, N'test', 111111)
GO
INSERT [dbo].[chitiet_nhapvien] ([chitiet_id], [nhapvien_id], [dichvu_id], [ghichu], [giatien]) VALUES (3, 6, 2, N'', 200000)
GO
INSERT [dbo].[chitiet_nhapvien] ([chitiet_id], [nhapvien_id], [dichvu_id], [ghichu], [giatien]) VALUES (4, 7, 3, N'', 500000)
GO
INSERT [dbo].[chitiet_nhapvien] ([chitiet_id], [nhapvien_id], [dichvu_id], [ghichu], [giatien]) VALUES (5, 8, 6, N'', 250000)
GO
SET IDENTITY_INSERT [dbo].[chitiet_nhapvien] OFF
GO
SET IDENTITY_INSERT [dbo].[dangkykham] ON 
GO
INSERT [dbo].[dangkykham] ([hsdk_khamid], [hs_id], [nhanvien_id], [dichvu_id], [ngaytao], [ngaydangky], [phieuthu_id], [thongtin], [trangthai]) VALUES (3, 1, NULL, NULL, CAST(N'2025-02-10' AS Date), CAST(N'2025-02-10' AS Date), NULL, NULL, 1)
GO
INSERT [dbo].[dangkykham] ([hsdk_khamid], [hs_id], [nhanvien_id], [dichvu_id], [ngaytao], [ngaydangky], [phieuthu_id], [thongtin], [trangthai]) VALUES (4, 2, NULL, NULL, CAST(N'2025-02-10' AS Date), CAST(N'2025-02-10' AS Date), NULL, NULL, 1)
GO
INSERT [dbo].[dangkykham] ([hsdk_khamid], [hs_id], [nhanvien_id], [dichvu_id], [ngaytao], [ngaydangky], [phieuthu_id], [thongtin], [trangthai]) VALUES (5, 1, NULL, NULL, CAST(N'2025-02-10' AS Date), CAST(N'2025-02-10' AS Date), NULL, NULL, 1)
GO
INSERT [dbo].[dangkykham] ([hsdk_khamid], [hs_id], [nhanvien_id], [dichvu_id], [ngaytao], [ngaydangky], [phieuthu_id], [thongtin], [trangthai]) VALUES (6, 2, 4, NULL, CAST(N'2025-02-10' AS Date), CAST(N'2025-02-10' AS Date), NULL, N'không có gì', 2)
GO
INSERT [dbo].[dangkykham] ([hsdk_khamid], [hs_id], [nhanvien_id], [dichvu_id], [ngaytao], [ngaydangky], [phieuthu_id], [thongtin], [trangthai]) VALUES (7, 1, NULL, NULL, CAST(N'2025-02-10' AS Date), CAST(N'2025-02-10' AS Date), NULL, NULL, 1)
GO
INSERT [dbo].[dangkykham] ([hsdk_khamid], [hs_id], [nhanvien_id], [dichvu_id], [ngaytao], [ngaydangky], [phieuthu_id], [thongtin], [trangthai]) VALUES (8, 1, NULL, NULL, CAST(N'2025-02-11' AS Date), CAST(N'2025-02-11' AS Date), NULL, NULL, 1)
GO
INSERT [dbo].[dangkykham] ([hsdk_khamid], [hs_id], [nhanvien_id], [dichvu_id], [ngaytao], [ngaydangky], [phieuthu_id], [thongtin], [trangthai]) VALUES (9, 1, NULL, NULL, CAST(N'2025-02-11' AS Date), CAST(N'2025-02-11' AS Date), NULL, NULL, 1)
GO
SET IDENTITY_INSERT [dbo].[dangkykham] OFF
GO
SET IDENTITY_INSERT [dbo].[dichvu] ON 
GO
INSERT [dbo].[dichvu] ([dichvu_id], [ma_dichvu], [ten_dichvu], [gia_dichvu], [trangthai]) VALUES (1, N'XN_00000000001', N'Xét nghiệm máu', 150000, 1)
GO
INSERT [dbo].[dichvu] ([dichvu_id], [ma_dichvu], [ten_dichvu], [gia_dichvu], [trangthai]) VALUES (2, N'XN_00000000002', N'Xét nghiệm nước tiểu', 200000, 1)
GO
INSERT [dbo].[dichvu] ([dichvu_id], [ma_dichvu], [ten_dichvu], [gia_dichvu], [trangthai]) VALUES (3, N'XN_00000000003', N'Xét nghiệm test', 500000, 1)
GO
INSERT [dbo].[dichvu] ([dichvu_id], [ma_dichvu], [ten_dichvu], [gia_dichvu], [trangthai]) VALUES (4, N'XN_00000000004', N'Xét nghiệm test', 500000, 0)
GO
INSERT [dbo].[dichvu] ([dichvu_id], [ma_dichvu], [ten_dichvu], [gia_dichvu], [trangthai]) VALUES (5, N'XN_00000000005', N'Xét nghiệm test', 500000, 0)
GO
INSERT [dbo].[dichvu] ([dichvu_id], [ma_dichvu], [ten_dichvu], [gia_dichvu], [trangthai]) VALUES (6, N'DNA', N'Xét nghiệm DNA', 250000, 1)
GO
SET IDENTITY_INSERT [dbo].[dichvu] OFF
GO
SET IDENTITY_INSERT [dbo].[hsbn] ON 
GO
INSERT [dbo].[hsbn] ([hs_id], [ma_hs], [hoten], [ngaysinh], [bhyt], [sdt], [cccd], [diachi], [gioitinh], [nhanvien_id], [ngaytao], [trangthai]) VALUES (1, N'HSBN_DEMO', N'DEMO', CAST(N'1980-02-02T00:00:00.000' AS DateTime), N'019283338315', N'0192444283', N'019255528312', N'Tiền Giang', N'Nam', 1, CAST(N'2025-02-02T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[hsbn] ([hs_id], [ma_hs], [hoten], [ngaysinh], [bhyt], [sdt], [cccd], [diachi], [gioitinh], [nhanvien_id], [ngaytao], [trangthai]) VALUES (2, N'HSBN_01', N'Lương bàng quang', CAST(N'1980-02-02T00:00:00.000' AS DateTime), N'019282928315', N'0192829283', N'019282928312', N'Tiền giang', N'Nam', 1, CAST(N'2025-02-02T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[hsbn] ([hs_id], [ma_hs], [hoten], [ngaysinh], [bhyt], [sdt], [cccd], [diachi], [gioitinh], [nhanvien_id], [ngaytao], [trangthai]) VALUES (3, N'HS_Test', N'test', CAST(N'1999-02-02T00:00:00.000' AS DateTime), N'00000000000', N'00000000000', N'00000000000', N'Demo tét', N'Nam', 4, CAST(N'2025-02-02T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[hsbn] ([hs_id], [ma_hs], [hoten], [ngaysinh], [bhyt], [sdt], [cccd], [diachi], [gioitinh], [nhanvien_id], [ngaytao], [trangthai]) VALUES (4, N'HSBN_NhapVien', N'Demo nhập viện', CAST(N'1990-02-02T00:00:00.000' AS DateTime), N'11111111111', N'03940394039', N'039403940391', N'Vĩnh Long', N'Nam', 4, CAST(N'2025-02-02T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[hsbn] ([hs_id], [ma_hs], [hoten], [ngaysinh], [bhyt], [sdt], [cccd], [diachi], [gioitinh], [nhanvien_id], [ngaytao], [trangthai]) VALUES (5, N'HSBN_NhapVien1', N'test nữ nằm viện', CAST(N'1990-02-02T00:00:00.000' AS DateTime), N'2222222222', N'039403940391', N'202500112233', N'Trà Vinh', N'Nữ', 4, CAST(N'2025-02-02T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[hsbn] ([hs_id], [ma_hs], [hoten], [ngaysinh], [bhyt], [sdt], [cccd], [diachi], [gioitinh], [nhanvien_id], [ngaytao], [trangthai]) VALUES (6, N'HSBN_khambenh', N'Bệnh nhân đang khám bệnh', CAST(N'1990-02-02T00:00:00.000' AS DateTime), N'03940344039111', N'039403940491', N'0394039443911', N'Sóc trăng', N'Nữ', 1, CAST(N'2025-02-02T00:00:00.000' AS DateTime), 1)
GO
SET IDENTITY_INSERT [dbo].[hsbn] OFF
GO
SET IDENTITY_INSERT [dbo].[lichsunamvien] ON 
GO
INSERT [dbo].[lichsunamvien] ([lichsu_id], [nhapvien_id], [phong_id], [ngayvao], [ngayra], [trangthai]) VALUES (1, 9, 1, CAST(N'2025-02-01' AS Date), CAST(N'2025-02-11' AS Date), 1)
GO
INSERT [dbo].[lichsunamvien] ([lichsu_id], [nhapvien_id], [phong_id], [ngayvao], [ngayra], [trangthai]) VALUES (2, 10, 3, CAST(N'2025-02-02' AS Date), CAST(N'2025-02-11' AS Date), 1)
GO
INSERT [dbo].[lichsunamvien] ([lichsu_id], [nhapvien_id], [phong_id], [ngayvao], [ngayra], [trangthai]) VALUES (3, 9, 3, CAST(N'2025-02-11' AS Date), CAST(N'2025-02-11' AS Date), 1)
GO
INSERT [dbo].[lichsunamvien] ([lichsu_id], [nhapvien_id], [phong_id], [ngayvao], [ngayra], [trangthai]) VALUES (4, 10, 1, CAST(N'2025-02-11' AS Date), CAST(N'2025-02-11' AS Date), 1)
GO
INSERT [dbo].[lichsunamvien] ([lichsu_id], [nhapvien_id], [phong_id], [ngayvao], [ngayra], [trangthai]) VALUES (5, 10, 3, CAST(N'2025-02-11' AS Date), CAST(N'2025-02-11' AS Date), 1)
GO
SET IDENTITY_INSERT [dbo].[lichsunamvien] OFF
GO
SET IDENTITY_INSERT [dbo].[nhanvien] ON 
GO
INSERT [dbo].[nhanvien] ([nhanvien_id], [ma_nhanvien], [hoten], [chucvu], [ngaysinh], [sdt], [gioitinh], [hocvan], [chuyenkhoa], [exp], [taikhoan], [matkhau], [ngaytao], [trangthai]) VALUES (1, N'NV_0000001', N'Trần tiến sỉ', N'Bác sỉ', CAST(N'1981-02-02T10:10:00.000' AS DateTime), N'0123456781', N'Nam', N'Tiến sỉ', N'Nội tổng hợp', 20, N'tiensi', N'123456', CAST(N'2025-02-02T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[nhanvien] ([nhanvien_id], [ma_nhanvien], [hoten], [chucvu], [ngaysinh], [sdt], [gioitinh], [hocvan], [chuyenkhoa], [exp], [taikhoan], [matkhau], [ngaytao], [trangthai]) VALUES (2, N'NV_00000002', N'Tiến sỉ giấy', N'Bác sỉ', CAST(N'1983-02-02T00:00:00.000' AS DateTime), N'0192829281', N'Nam', N'tiến sỉ giấy', N'nội tá lả', 30, N'demo12345', N'123456', CAST(N'2025-02-02T00:00:00.000' AS DateTime), 0)
GO
INSERT [dbo].[nhanvien] ([nhanvien_id], [ma_nhanvien], [hoten], [chucvu], [ngaysinh], [sdt], [gioitinh], [hocvan], [chuyenkhoa], [exp], [taikhoan], [matkhau], [ngaytao], [trangthai]) VALUES (3, N'NV_00000003', N'Tiến sỉ giấy', N'Bác sỉ', CAST(N'1983-02-02T00:00:00.000' AS DateTime), N'0192829280', N'Nam', N'tiến sỉ giấy', N'nội tá lả', 30, N'demond1', N'123456', CAST(N'2025-02-02T00:00:00.000' AS DateTime), 0)
GO
INSERT [dbo].[nhanvien] ([nhanvien_id], [ma_nhanvien], [hoten], [chucvu], [ngaysinh], [sdt], [gioitinh], [hocvan], [chuyenkhoa], [exp], [taikhoan], [matkhau], [ngaytao], [trangthai]) VALUES (4, N'NV_00000004', N'check', N'Bác sỉ', CAST(N'1983-02-02T00:00:00.000' AS DateTime), N'0192829279', N'Nam', N'check', N'ngoại tá lả', 10, N'demo', N'123456', CAST(N'2025-02-02T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[nhanvien] ([nhanvien_id], [ma_nhanvien], [hoten], [chucvu], [ngaysinh], [sdt], [gioitinh], [hocvan], [chuyenkhoa], [exp], [taikhoan], [matkhau], [ngaytao], [trangthai]) VALUES (5, N'NV000xxx01', N'demo yta', N'Y tá', CAST(N'1999-02-10T00:00:00.000' AS DateTime), N'0394839483', N'Nam', N'Thạc sỉ', N'Mổ cận', 5, N'abc', N'123456', CAST(N'2025-02-10T00:00:00.000' AS DateTime), 1)
GO
SET IDENTITY_INSERT [dbo].[nhanvien] OFF
GO
SET IDENTITY_INSERT [dbo].[phieunhapvien] ON 
GO
INSERT [dbo].[phieunhapvien] ([nhapvien_id], [hs_id], [nhanvien_id], [phong_id], [ngaytao], [ngaynhapvien], [ngayxuatvien], [tongtien], [trangthai]) VALUES (4, 4, 1, 1, CAST(N'2025-02-07' AS Date), CAST(N'2025-02-07' AS Date), CAST(N'2025-02-10' AS Date), 100000, 2)
GO
INSERT [dbo].[phieunhapvien] ([nhapvien_id], [hs_id], [nhanvien_id], [phong_id], [ngaytao], [ngaynhapvien], [ngayxuatvien], [tongtien], [trangthai]) VALUES (5, 5, 1, 3, CAST(N'2025-02-05' AS Date), CAST(N'2025-02-05' AS Date), CAST(N'2025-02-10' AS Date), 250000, 2)
GO
INSERT [dbo].[phieunhapvien] ([nhapvien_id], [hs_id], [nhanvien_id], [phong_id], [ngaytao], [ngaynhapvien], [ngayxuatvien], [tongtien], [trangthai]) VALUES (6, 1, 4, 1, CAST(N'2025-02-11' AS Date), CAST(N'2025-02-01' AS Date), CAST(N'2025-02-10' AS Date), 2, 2)
GO
INSERT [dbo].[phieunhapvien] ([nhapvien_id], [hs_id], [nhanvien_id], [phong_id], [ngaytao], [ngaynhapvien], [ngayxuatvien], [tongtien], [trangthai]) VALUES (7, 2, 4, 3, CAST(N'2025-02-11' AS Date), CAST(N'2025-02-02' AS Date), CAST(N'2025-02-10' AS Date), 2, 2)
GO
INSERT [dbo].[phieunhapvien] ([nhapvien_id], [hs_id], [nhanvien_id], [phong_id], [ngaytao], [ngaynhapvien], [ngayxuatvien], [tongtien], [trangthai]) VALUES (8, 6, 4, 1, CAST(N'2025-02-11' AS Date), CAST(N'2025-02-03' AS Date), CAST(N'2025-02-10' AS Date), 2, 2)
GO
INSERT [dbo].[phieunhapvien] ([nhapvien_id], [hs_id], [nhanvien_id], [phong_id], [ngaytao], [ngaynhapvien], [ngayxuatvien], [tongtien], [trangthai]) VALUES (9, 2, 4, 3, CAST(N'2025-02-11' AS Date), CAST(N'2025-02-01' AS Date), CAST(N'2025-02-11' AS Date), NULL, 2)
GO
INSERT [dbo].[phieunhapvien] ([nhapvien_id], [hs_id], [nhanvien_id], [phong_id], [ngaytao], [ngaynhapvien], [ngayxuatvien], [tongtien], [trangthai]) VALUES (10, 1, 4, 3, CAST(N'2025-02-11' AS Date), CAST(N'2025-02-02' AS Date), CAST(N'2025-02-11' AS Date), NULL, 2)
GO
SET IDENTITY_INSERT [dbo].[phieunhapvien] OFF
GO
SET IDENTITY_INSERT [dbo].[phieuthu] ON 
GO
INSERT [dbo].[phieuthu] ([phieuthu_id], [nhanvien_id], [dichvu_id], [hs_id], [ngaytao], [ngaythu], [sotien], [ghichu], [trangthai]) VALUES (1, 4, 3, NULL, CAST(N'2025-02-11' AS Date), CAST(N'2025-02-11' AS Date), 500000, N'', 1)
GO
INSERT [dbo].[phieuthu] ([phieuthu_id], [nhanvien_id], [dichvu_id], [hs_id], [ngaytao], [ngaythu], [sotien], [ghichu], [trangthai]) VALUES (2, 4, 6, NULL, CAST(N'2025-02-11' AS Date), CAST(N'2025-02-11' AS Date), 500000, N'', 1)
GO
INSERT [dbo].[phieuthu] ([phieuthu_id], [nhanvien_id], [dichvu_id], [hs_id], [ngaytao], [ngaythu], [sotien], [ghichu], [trangthai]) VALUES (3, 4, 1, NULL, CAST(N'2025-02-11' AS Date), CAST(N'2025-02-11' AS Date), 150000, N'', 1)
GO
INSERT [dbo].[phieuthu] ([phieuthu_id], [nhanvien_id], [dichvu_id], [hs_id], [ngaytao], [ngaythu], [sotien], [ghichu], [trangthai]) VALUES (4, 4, 3, NULL, CAST(N'2025-02-11' AS Date), CAST(N'2025-02-11' AS Date), 500000, N'', 1)
GO
INSERT [dbo].[phieuthu] ([phieuthu_id], [nhanvien_id], [dichvu_id], [hs_id], [ngaytao], [ngaythu], [sotien], [ghichu], [trangthai]) VALUES (5, 4, NULL, 2, CAST(N'2025-02-11' AS Date), CAST(N'2025-02-11' AS Date), 3000, N'thu rồi 1 thằng', 1)
GO
INSERT [dbo].[phieuthu] ([phieuthu_id], [nhanvien_id], [dichvu_id], [hs_id], [ngaytao], [ngaythu], [sotien], [ghichu], [trangthai]) VALUES (6, 4, NULL, 1, CAST(N'2025-02-11' AS Date), CAST(N'2025-02-11' AS Date), 5400000, N'thu rồi 1 thằng r3r4fq43q43g43qrq', 1)
GO
SET IDENTITY_INSERT [dbo].[phieuthu] OFF
GO
SET IDENTITY_INSERT [dbo].[phieuxetnghiem] ON 
GO
INSERT [dbo].[phieuxetnghiem] ([phieuxn_id], [ma_phieu], [hs_id], [dichvu_id], [ketqua], [ngaytao], [nhanvien_id], [trangthai]) VALUES (4, N'XN_Test', 5, 2, N'bt', CAST(N'2025-02-02T00:00:00.000' AS DateTime), 1, 2)
GO
INSERT [dbo].[phieuxetnghiem] ([phieuxn_id], [ma_phieu], [hs_id], [dichvu_id], [ketqua], [ngaytao], [nhanvien_id], [trangthai]) VALUES (5, N'XN_ChuaThuTien', 4, 3, N'binh thường', CAST(N'2025-02-02T00:00:00.000' AS DateTime), 1, 2)
GO
INSERT [dbo].[phieuxetnghiem] ([phieuxn_id], [ma_phieu], [hs_id], [dichvu_id], [ketqua], [ngaytao], [nhanvien_id], [trangthai]) VALUES (6, N'XN_HuyKETQUA', 5, 2, N'binh thường', CAST(N'2025-02-02T00:00:00.000' AS DateTime), 1, 0)
GO
INSERT [dbo].[phieuxetnghiem] ([phieuxn_id], [ma_phieu], [hs_id], [dichvu_id], [ketqua], [ngaytao], [nhanvien_id], [trangthai]) VALUES (11, N'XN_testdemo', 4, 1, N'abc', CAST(N'2025-02-02T00:00:00.000' AS DateTime), 1, 2)
GO
INSERT [dbo].[phieuxetnghiem] ([phieuxn_id], [ma_phieu], [hs_id], [dichvu_id], [ketqua], [ngaytao], [nhanvien_id], [trangthai]) VALUES (12, N'DNA DEMO', 1, 6, N'Khớp tùm lum', CAST(N'2025-02-11T00:00:00.000' AS DateTime), 4, 3)
GO
INSERT [dbo].[phieuxetnghiem] ([phieuxn_id], [ma_phieu], [hs_id], [dichvu_id], [ketqua], [ngaytao], [nhanvien_id], [trangthai]) VALUES (13, N'XNM', 2, 1, N'abc', CAST(N'2025-02-11T00:00:00.000' AS DateTime), 4, 3)
GO
INSERT [dbo].[phieuxetnghiem] ([phieuxn_id], [ma_phieu], [hs_id], [dichvu_id], [ketqua], [ngaytao], [nhanvien_id], [trangthai]) VALUES (14, N'XNT', 2, 3, N'chưa có kết quả', CAST(N'2025-02-11T00:00:00.000' AS DateTime), 4, 3)
GO
SET IDENTITY_INSERT [dbo].[phieuxetnghiem] OFF
GO
SET IDENTITY_INSERT [dbo].[phongbenh] ON 
GO
INSERT [dbo].[phongbenh] ([phong_id], [maphongbenh], [tenphongbenh], [loaiphongbenh], [gia], [trangthai], [sogiuong_moi]) VALUES (1, N'PS1', N'Phồng số 1', N'Thường', 300, 1, 10)
GO
INSERT [dbo].[phongbenh] ([phong_id], [maphongbenh], [tenphongbenh], [loaiphongbenh], [gia], [trangthai], [sogiuong_moi]) VALUES (2, N'test', N'test', N'Thường', 1, 0, 1)
GO
INSERT [dbo].[phongbenh] ([phong_id], [maphongbenh], [tenphongbenh], [loaiphongbenh], [gia], [trangthai], [sogiuong_moi]) VALUES (3, N'PS2', N'Phòng số 2', N'Dịch vụ', 600000, 1, 2)
GO
SET IDENTITY_INSERT [dbo].[phongbenh] OFF
GO
SET IDENTITY_INSERT [dbo].[phongkham] ON 
GO
INSERT [dbo].[phongkham] ([phongkham_id], [ma_phongkham], [ten_phongkham], [nhanvien_id], [trangthai]) VALUES (1, N'Phong_TMH', N'Phòng khám tai mũi họng', 1, 1)
GO
INSERT [dbo].[phongkham] ([phongkham_id], [ma_phongkham], [ten_phongkham], [nhanvien_id], [trangthai]) VALUES (2, N'Phong_RHM', N'Phòng khám răng hàm mặt', 1, 1)
GO
INSERT [dbo].[phongkham] ([phongkham_id], [ma_phongkham], [ten_phongkham], [nhanvien_id], [trangthai]) VALUES (3, N'Phong_Test', N'Phòng khám test', 1, 0)
GO
INSERT [dbo].[phongkham] ([phongkham_id], [ma_phongkham], [ten_phongkham], [nhanvien_id], [trangthai]) VALUES (4, N'Phong_XuongKhop', N'Phòng khám Xương Khớp', 1, 1)
GO
SET IDENTITY_INSERT [dbo].[phongkham] OFF
GO
ALTER TABLE [dbo].[chitiet_nhapvien]  WITH CHECK ADD  CONSTRAINT [FK_chitiet_nhapvien_phieunhapvien] FOREIGN KEY([nhapvien_id])
REFERENCES [dbo].[phieunhapvien] ([nhapvien_id])
GO
ALTER TABLE [dbo].[chitiet_nhapvien] CHECK CONSTRAINT [FK_chitiet_nhapvien_phieunhapvien]
GO
ALTER TABLE [dbo].[chitiet_toathuoc]  WITH CHECK ADD  CONSTRAINT [FK_chitiet_toathuoc_thuoc] FOREIGN KEY([thuoc_id])
REFERENCES [dbo].[thuoc] ([thuoc_id])
GO
ALTER TABLE [dbo].[chitiet_toathuoc] CHECK CONSTRAINT [FK_chitiet_toathuoc_thuoc]
GO
ALTER TABLE [dbo].[chitiet_toathuoc]  WITH CHECK ADD  CONSTRAINT [FK_chitiet_toathuoc_toathuoc] FOREIGN KEY([toathuoc_id])
REFERENCES [dbo].[toathuoc] ([toathuoc_id])
GO
ALTER TABLE [dbo].[chitiet_toathuoc] CHECK CONSTRAINT [FK_chitiet_toathuoc_toathuoc]
GO
ALTER TABLE [dbo].[dangkykham]  WITH CHECK ADD  CONSTRAINT [FK_dangkykham_hsbn] FOREIGN KEY([hs_id])
REFERENCES [dbo].[hsbn] ([hs_id])
GO
ALTER TABLE [dbo].[dangkykham] CHECK CONSTRAINT [FK_dangkykham_hsbn]
GO
ALTER TABLE [dbo].[hsbn]  WITH CHECK ADD  CONSTRAINT [FK_hsbn_nhanvien] FOREIGN KEY([nhanvien_id])
REFERENCES [dbo].[nhanvien] ([nhanvien_id])
GO
ALTER TABLE [dbo].[hsbn] CHECK CONSTRAINT [FK_hsbn_nhanvien]
GO
ALTER TABLE [dbo].[phieunhapvien]  WITH CHECK ADD  CONSTRAINT [FK_phieunhapvien_hsbn] FOREIGN KEY([hs_id])
REFERENCES [dbo].[hsbn] ([hs_id])
GO
ALTER TABLE [dbo].[phieunhapvien] CHECK CONSTRAINT [FK_phieunhapvien_hsbn]
GO
ALTER TABLE [dbo].[phieunhapvien]  WITH CHECK ADD  CONSTRAINT [FK_phieunhapvien_phongbenh] FOREIGN KEY([phong_id])
REFERENCES [dbo].[phongbenh] ([phong_id])
GO
ALTER TABLE [dbo].[phieunhapvien] CHECK CONSTRAINT [FK_phieunhapvien_phongbenh]
GO
ALTER TABLE [dbo].[phieuthu]  WITH CHECK ADD  CONSTRAINT [FK_phieuthu_hsbn] FOREIGN KEY([hs_id])
REFERENCES [dbo].[hsbn] ([hs_id])
GO
ALTER TABLE [dbo].[phieuthu] CHECK CONSTRAINT [FK_phieuthu_hsbn]
GO
ALTER TABLE [dbo].[phieuthu]  WITH CHECK ADD  CONSTRAINT [FK_phieuthu_nhanvien] FOREIGN KEY([nhanvien_id])
REFERENCES [dbo].[nhanvien] ([nhanvien_id])
GO
ALTER TABLE [dbo].[phieuthu] CHECK CONSTRAINT [FK_phieuthu_nhanvien]
GO
ALTER TABLE [dbo].[phieuxetnghiem]  WITH CHECK ADD  CONSTRAINT [FK_phieuxetnghiem_dichvu] FOREIGN KEY([dichvu_id])
REFERENCES [dbo].[dichvu] ([dichvu_id])
GO
ALTER TABLE [dbo].[phieuxetnghiem] CHECK CONSTRAINT [FK_phieuxetnghiem_dichvu]
GO
ALTER TABLE [dbo].[phieuxetnghiem]  WITH CHECK ADD  CONSTRAINT [FK_phieuxetnghiem_hsbn] FOREIGN KEY([hs_id])
REFERENCES [dbo].[hsbn] ([hs_id])
GO
ALTER TABLE [dbo].[phieuxetnghiem] CHECK CONSTRAINT [FK_phieuxetnghiem_hsbn]
GO
ALTER TABLE [dbo].[phieuxetnghiem]  WITH CHECK ADD  CONSTRAINT [FK_phieuxetnghiem_nhanvien] FOREIGN KEY([nhanvien_id])
REFERENCES [dbo].[nhanvien] ([nhanvien_id])
GO
ALTER TABLE [dbo].[phieuxetnghiem] CHECK CONSTRAINT [FK_phieuxetnghiem_nhanvien]
GO
ALTER TABLE [dbo].[phongkham]  WITH CHECK ADD  CONSTRAINT [FK_phongkham_nhanvien] FOREIGN KEY([nhanvien_id])
REFERENCES [dbo].[nhanvien] ([nhanvien_id])
GO
ALTER TABLE [dbo].[phongkham] CHECK CONSTRAINT [FK_phongkham_nhanvien]
GO
ALTER TABLE [dbo].[toathuoc]  WITH CHECK ADD  CONSTRAINT [FK_toathuoc_hsbn] FOREIGN KEY([hs_id])
REFERENCES [dbo].[hsbn] ([hs_id])
GO
ALTER TABLE [dbo].[toathuoc] CHECK CONSTRAINT [FK_toathuoc_hsbn]
GO
/****** Object:  StoredProcedure [dbo].[pro_chitiet_nhapvien]    Script Date: 2/11/2025 5:25:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pro_chitiet_nhapvien]
    @param INT
AS
BEGIN
    SELECT 
        a.chitiet_id AS STT, 
        b.ten_dichvu, 
        a.giatien, 
        a.ghichu
    FROM 
        chitiet_nhapvien AS a
    INNER JOIN 
        dichvu AS b ON a.dichvu_id = b.dichvu_id
    WHERE 
        a.nhapvien_id = @param;
END;
GO
/****** Object:  StoredProcedure [dbo].[pro_chitiet_nhapvien_xetnghiem]    Script Date: 2/11/2025 5:25:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pro_chitiet_nhapvien_xetnghiem]
@hs int
AS
BEGIN
select b.ma_phieu, b.ngaytao ,c.ten_benh_nhan, c.ten_dichvu,c.ten_nhan_vien, b.ketqua, 
case
when b.trangthai = 1 then N'Chưa thu tiền'
when b.trangthai = 2 then N'Đã thu tiền'
else N'Hủy kết quả'
end as trangthai 
from phieunhapvien as a, phieuxetnghiem as b, view_phieuxetnghiem as c
where a.hs_id = b.hs_id and b.hs_id = @hs and c.ma_phieu = b.ma_phieu
order by c.phieuxn_id DESC
END;
GO
USE [master]
GO
ALTER DATABASE [QLBN] SET  READ_WRITE 
GO
