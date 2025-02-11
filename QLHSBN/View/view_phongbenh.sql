create view view_phongbenh
as
SELECT        phong_id AS STT, maphongbenh, tenphongbenh, loaiphongbenh, gia, sogiuong_moi,
case

when trangthai = 1 then N'Còn trống'
when trangthai = 2 then N'Đầy'
when trangthai = 0  then N'Ngừng'
end as trangthai
FROM            phongbenh
GO
