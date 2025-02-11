CREATE PROCEDURE pro_chitiet_nhapvien
    @param INT
AS
BEGIN
    SELECT 
        a.chitiet_id AS STT, 
        b.ten_dichvu, 
        a.giatien, 
        a.ghichu
    FROM 
        chitiet_nhapvien AS a
    INNER JOIN 
        dichvu AS b ON a.dichvu_id = b.dichvu_id
    WHERE 
        a.nhapvien_id = @param;
END;
go

CREATE PROCEDURE pro_chitiet_nhapvien_xetnghiem
    @param INT
AS
BEGIN
    SELECT 
        b.ma_phieu,
		b.ngaytao,
		b.ten_benh_nhan,
		b.ten_dichvu,
		b.ten_nhan_vien,
		b.ketqua,
		b.trangthai

    FROM 
        chitiet_nhapvien AS a, view_phieuxetnghiem as b
        
    WHERE a.phieuxn_id = b.phieuxn_id and
        a.nhapvien_id = @param;
END;


exec pro_chitiet_nhapvien 1