USE [QLBN]
GO

/****** Object:  View [dbo].[view_nhanvien]    Script Date: 2/2/2025 9:39:37 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [dbo].[view_nhanvien]
AS
SELECT        nhanvien_id, ma_nhanvien, hoten, chucvu, ngaysinh, sdt, gioitinh, hocvan, chuyenkhoa, exp, taikhoan, ngaytao, 
CASE 
        WHEN trangthai = 1 THEN N'Đang sử dụng' 
        ELSE N'Đã khóa' 
    END AS Trang_thai
FROM            dbo.nhanvien
GO


