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