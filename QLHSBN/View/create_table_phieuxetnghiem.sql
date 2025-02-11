USE [QLBN]
GO

/****** Object:  Table [dbo].[phieuxetnghiem]    Script Date: 2/2/2025 5:46:30 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[phieuxetnghiem]') AND type in (N'U'))
DROP TABLE [dbo].[phieuxetnghiem]
GO

/****** Object:  Table [dbo].[phieuxetnghiem]    Script Date: 2/2/2025 5:46:30 PM ******/
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
	[ngaytao] datetime NULL,
	[nhanvien_id] [int] NOT NULL,
	[trangthai] [int] NOT NULL,
 CONSTRAINT [PK_phieuxetnghiem] PRIMARY KEY CLUSTERED 
(
	[phieuxn_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


