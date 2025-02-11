create view view_phieuxetnghiem
as
SELECT        dbo.phieuxetnghiem.phieuxn_id, dbo.phieuxetnghiem.ma_phieu, dbo.hsbn.hoten, dbo.dichvu.ten_dichvu, dbo.phieuxetnghiem.ketqua, 
case
	when dbo.phieuxetnghiem.trangthai = 0 then N'hủy kết quả'
	when dbo.phieuxetnghiem.trangthai = 1 then N'Chưa thu tiền'
	when dbo.phieuxetnghiem.trangthai = 2 then N'Đã thu tiền'
end as trangthai
FROM            dbo.dichvu INNER JOIN
                         dbo.phieuxetnghiem ON dbo.dichvu.dichvu_id = dbo.phieuxetnghiem.dichvu_id CROSS JOIN
                         dbo.hsbn