USE [QLBN]
GO

/****** Object:  Table [dbo].[phongkham]    Script Date: 2/2/2025 1:41:03 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[phongkham]') AND type in (N'U'))
DROP TABLE [dbo].[phongkham]
GO

/****** Object:  Table [dbo].[phongkham]    Script Date: 2/2/2025 1:41:03 PM ******/
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


