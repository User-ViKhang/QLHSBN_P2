create view view_dichvu
as
SELECT        dichvu_id, ma_dichvu, ten_dichvu, gia_dichvu, 
case
	when trangthai = 1 then N'Đang hoạt động'
	else N'Dừng hoạt động'
end as trangthai

FROM            dbo.dichvu