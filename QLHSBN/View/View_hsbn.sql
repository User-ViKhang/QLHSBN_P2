CREATE VIEW [dbo].[view_hsbn]
AS
SELECT        hsbn.hs_id, hsbn.ma_hs, hsbn.hoten, hsbn.ngaysinh, hsbn.bhyt, hsbn.sdt, hsbn.cccd, hsbn.diachi, hsbn.gioitinh,hsbn.ngaytao,	nhanvien.hoten AS Nguoitao,
CASE 
        WHEN hsbn.trangthai = 1 THEN N'Đang sử dụng' 
        ELSE N'Đã khóa' 
    END AS Trang_thai

FROM            hsbn INNER JOIN
                         nhanvien ON hsbn.nhanvien_id = nhanvien.nhanvien_id
GO