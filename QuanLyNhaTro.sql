CREATE DATABASE QuanLyNhaTro
GO
USE QuanLyNhaTro
GO

CREATE TABLE ChuSoHuu
(
	ID INT IDENTITY,
	MaChuSoHuu VARCHAR(20),
	TenChuSoHuu NVARCHAR(50)NOT NULL,
	Email NVARCHAR(100) NOT NULL,
	SoDienThoai VARCHAR(15) NOT NULL,
	DiaChi NVARCHAR(100) NOT NULL,
	MatKhau VARCHAR(50) NOT NULL,
	CONSTRAINT PK_NguoiDung PRIMARY KEY(MaChuSoHuu)
)
GO

CREATE TABLE PhongTro
(
	ID INT IDENTITY,
	MaPhong VARCHAR(20),
	DienTich VARCHAR(20) NOT NULL,
	Gia FLOAT NOT NULL,
	TinhTrang TINYINT DEFAULT 1,-- 1 la trong, 0 la da thue
	MaChuSoHuu VARCHAR(20) not null,
	GhiChu NVARCHAR(100)not null
	CONSTRAINT PK_PT PRIMARY KEY(MaPhong)
)
GO

CREATE TABLE KhachThue
(
	ID INT IDENTITY,
	MaKhach VARCHAR(20),
	TenKhach NVARCHAR(50) NOT NULL,
	SoDienThoai VARCHAR(15) NOT NULL,
	CCCD INT NOT NULL,
	MaChuSoHuu VARCHAR(20) NOT NULL,
	Maphong VARCHAR(20) NOT NULL,
	CONSTRAINT PK_KT PRIMARY KEY(MaKhach)
)
GO

CREATE TABLE HopDong
(
	ID INT IDENTITY,
	MaHopDong VARCHAR(20) PRIMARY KEY,
	MaChuSoHuu VARCHAR(20) NOT NULL,
	MaKhach VARCHAR(20)NOT NULL,
	NgayBatDau DATE NOT NULL,
	NgayKetThuc DATE NOT NULL,
	ChiSoDien NVARCHAR(20) NOT NULL, -- 3000/kWh
	ChiSoNuoc NVARCHAR(20) NOT NULL, -- 2500/m3
	TienCoc FLOAT NOT NULL,
	TienThue FLOAT NOT NULL,
)
GO

CREATE TABLE HoaDonThang 
(
	ID INT IDENTITY,
	MaHoaDon VARCHAR(20) PRIMARY KEY,
	MaKhach VARCHAR(20) NOT NULL,
	MaPhong VARCHAR(20) NOT NULL,
	NgayBatDau DATE NOT NULL,
	NgayKetThuc DATE NOT NULL,
	TienDien FLOAT NOT NULL,
	TienNuoc FLOAT NOT NULL,
	GiaPhong FLOAT NOT NULL,
	TongTien FLOAT NOT NULL,
)
GO

ALTER TABLE PhongTro ADD CONSTRAINT FK_PT_ND FOREIGN KEY (MaChuSoHuu) REFERENCES ChuSoHuu(MaChuSoHuu)
ALTER TABLE KhachThue ADD CONSTRAINT FK_KT_ND FOREIGN KEY (MaChuSoHuu) REFERENCES ChuSoHuu(MaChuSoHuu)
ALTER TABLE KhachThue ADD CONSTRAINT FK_KT_PT FOREIGN KEY (MaPhong) REFERENCES PhongTro(MaPhong)

ALTER TABLE HopDong ADD CONSTRAINT FK_HD_ND FOREIGN KEY (MaChuSoHuu) REFERENCES ChuSoHuu(MaChuSoHuu)
ALTER TABLE HopDong ADD CONSTRAINT FK_DH_KT FOREIGN KEY (MaKhach) REFERENCES KhachThue(MaKhach)

ALTER TABLE HoaDonThang ADD CONSTRAINT FK_HDT_KT FOREIGN KEY (MaKhach) REFERENCES KhachThue(MaKhach)
ALTER TABLE HoaDonThang ADD CONSTRAINT FK_HDT_PT FOREIGN KEY (MaPhong) REFERENCES PhongTro(MaPhong)
GO

--===========================================================================================
--================================== Dữ liệu Database =======================================

--==== Chủ sở hữu ====
INSERT INTO ChuSoHuu
VALUES 
('SH001', N'Nguyễn Hoàng Anh', 'anhnh@gmail.com', '0123456789', N'261, Phạm Văn Đồng, Quận 1, TP HCM', 'anhnh'),
('SH002', N'Nguyễn Đình Vương', 'vuongnd@gmail.com', '0333505127', N'41/2/5A, Nguyễn Văn Quá, Quận 12, TP HCM', 'vuongnd'),
('SH003', N'Trương Thanh Bạch', 'bachtt@gmail.com', '0576892842', N'Hẻm 23, Quận Tân Bình, TP HCM', 'bachtt'),
('SH004', N'Cao Quốc Thịnh', 'thinhcq@gmail.com', '0908338060', N'Thới An 16, Phường Thới An, Quận 12, TP HCM', 'caoqt'),
('SH006', N'Trần Quốc Trương', 'truongtq@gmail.com', '0845783210', N'Đường Phan Văn Hớn, Phường Tân Thới Nhất, Quận 12, TP HCM', 'truongtq'),
('SH007', N'Trần Minh Sang', 'sangtm@gmail.com', '0321847395', N'Đường Tô Ký, Phường Trung Mỹ Tây, Quận 12, TP HCM', 'sangtm');

SELECT * FROM ChuSoHuu

-- ===== Phòng trọ

ID INT IDENTITY,
	MaPhong VARCHAR(20),
	DienTich VARCHAR(20) NOT NULL,
	Gia FLOAT NOT NULL,
	TinhTrang TINYINT DEFAULT 1,-- 1 la trong, 0 la da thue
	MaChuSoHuu VARCHAR(20) not null,
	GhiChu NVARCHAR(100)not null

INSERT INTO PhongTro
VALUES
('PT001', '30m2', N'2.5 triệu/tháng', 0, 'SH007', N'Thiết kế Phòng trước có Ban công lớn'),
('PT002', '20m2', N'1.8 triệu/tháng', 0, 'SH007', N'Phòng có tolet riêng, cửa sổ, ban công, có phòng dưới trệt'),
('PT003', '30m2', N'2.5 triệu/tháng', 0, 'SH007', N'Thiết kế Phòng trước có Ban công lớn'),
('PT004', '30m2', N'2.5 triệu/tháng', 0, 'SH007', N'Thiết kế Phòng trước có Ban công lớn'),
('PT005', '30m2', N'2.5 triệu/tháng', 0, 'SH007', N'Thiết kế Phòng trước có Ban công lớn'),
('PT006', '30m2', N'2.5 triệu/tháng', 0, 'SH007', N'Thiết kế Phòng trước có Ban công lớn');

--===========================================================================================
--=================================== Sự Kiện Đăng Nhập =====================================

-- Đăng Nhập
create proc SP_DangNhap
@email nvarchar(100),
@pass nvarchar(50)
as
begin
	declare @status int

	if(exists(select * from dbo.NguoiDung where Email = @email and MatKhau = @Pass) ) 
		set @status = 1
	else 
		set @status = 0
	select @status
end
go

--quên mật khẩu
create proc SP_QuenMatKhau
@email nvarchar(100)
as
begin

	declare @status int 

	if exists(select MaNguoiDung from dbo.NguoiDung where Email = @email)
		set @status = 1
	else 
		set @status = 0
	select @status
end
go

-- đổi mật khẩu
create proc SP_DoiMatKhau
@email nvarchar(50),
@oldpass nvarchar(50),
@newpass nvarchar(50)
as
begin

	declare @old nvarchar(50)
	select @old = MatKhau 
	from dbo.NguoiDung 
	where Email = @email

	if (@old = @oldpass)
		begin
		update NguoiDung set MatKhau = @newpass where Email = @email
		return 1
		end
	else 
		return -1
end
go
