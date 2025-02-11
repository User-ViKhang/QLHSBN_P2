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