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