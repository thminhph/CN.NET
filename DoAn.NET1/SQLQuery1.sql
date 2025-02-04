CREATE DATABASE QLSV
go

USE QLSV
go

SET DATEFORMAT dmy;
CREATE TABLE khoa(
maKhoa nvarchar (20) not null,
tenKhoa nvarchar (30),
PRIMARY KEY (maKhoa)
)
CREATE TABLE GiaoVien (
maGV nvarchar (20) not null,
hoTenGV nvarchar (30),
gioitinh  nvarchar (40),
ngaySinh date ,
noiSinh nvarchar (20),
sDT nvarchar(10) ,
eMail nvarchar (30),
tenCV nvarchar(20),
tenLop nvarchar (20),
passTK nvarchar (20),
maKhoa nvarchar (20) not null,
primary key (maGV),
FOREIGN KEY (maKhoa) REFERENCES  Khoa(maKhoa),
)
CREATE TABLE SinhVien (
maSV nvarchar (20) not null,
hoTenSV nvarchar (30),
gioitinh  nvarchar (40),
ngaySinh date ,
noiSinh nvarchar (20),
sDT nvarchar(10) ,
eMail nvarchar (30),
tenCV nvarchar(20) ,
tenLop nvarchar (20),
maGV nvarchar (20) not null,
passTK nvarchar (20)
primary key (maSV),
FOREIGN KEY (maGV) REFERENCES  GiaoVien(maGV)
)

CREATE TABLE Lop(
tenLop nvarchar (20),
maKhoa nvarchar (20) not null,
PRIMARY KEY (maKhoa),
FOREIGN KEY (maKhoa) REFERENCES  Khoa(maKhoa),
)

CREATE TABLE hocPhan(
maHP nvarchar (20) not null,
tenHP nvarchar (30),
soTC int ,
loaiHP nvarchar (10),
gia int ,
tenHK nvarchar (10),
maKhoa nvarchar (20),
PRIMARY KEY (maHP),
FOREIGN KEY (maKhoa) REFERENCES  khoa(maKhoa)
)
CREATE TABLE bangDiem (
maHP nvarchar (20) not null,
maSV nvarchar (20) not null, 
tenHK nvarchar (10),
diemGK float ,
diemCK float ,
diemTB float,
thoigian date ,
primary key (maSV),
FOREIGN KEY (maSV) REFERENCES SinhVien(maSV),
FOREIGN KEY (maHP) REFERENCES hocPhan(maHP),
)
CREATE TABLE BangViPham(
maVP nvarchar (20) not null,
noidungVP nvarchar (200),
maSV nvarchar (20) not null, 
maHP nvarchar (20) not null,
primary key (maVP,maSV),
FOREIGN KEY (maSV) REFERENCES SinhVien(maSV),
FOREIGN KEY (maHP) REFERENCES hocPhan(maHP),
)

CREATE TABLE diemDanh(
maSV nvarchar (20) not null,
maHP nvarchar (20) not null,
sotiet int ,
thoiGian date,
primary key (maSV,maHP,thoiGian),
FOREIGN KEY (maSV) REFERENCES SinhVien(maSV),
FOREIGN KEY (maHP) REFERENCES hocPhan(maHP),
)

CREATE TABLE [dbo].[LOAITAIKHOAN]
(
ID [INT] IDENTITY(0,1) PRIMARY KEY,
TenLoai NVARCHAR(100) NOT NULL,
)

CREATE TABLE [dbo].[TAIKHOAN](
	[TenDangNhap] [nvarchar](100) NOT NULL,
	[HoTen] [nvarchar](100) NOT NULL,
	[MatKhau] [nvarchar](1000) NOT NULL,
	[ID] INT NOT NULL
	CONSTRAINT fk_TK FOREIGN KEY (ID) REFERENCES LOAITAIKHOAN(ID)
)
CREATE TABLE [dbo].[LUUTAIKHOAN](
	[TenDangNhap] [nvarchar](100) NOT NULL,
	[MatKhau] [nvarchar](1000) NOT NULL,
)
GO

BEGIN --Loại tài khoản
INSERT [dbo].[LOAITAIKHOAN](TenLoai) VALUES (N'Sinh Viên')
INSERT [dbo].[LOAITAIKHOAN](TenLoai) VALUES (N'Giáo Viên')
END
GO
BEGIN --tài khoản
INSERT [dbo].[TAIKHOAN] VALUES ('GV',N'Phạm Thế Minh','123',1)
INSERT [dbo].[LUUTAIKHOAN] VALUES ('admin','admin')
END
go

select * from [dbo].[TAIKHOAN]
Update [TAIKHOAN] set  MatKhau =  '234' Where TenDangNhap = 'minh'
go

BEGIN
INSERT [dbo].[khoa](maKhoa,tenKhoa) VALUES (N'KH01',N'CNTT')
INSERT [dbo].[khoa](maKhoa,tenKhoa) VALUES (N'KH02',N'Tieng Anh')
INSERT [dbo].[khoa](maKhoa,tenKhoa) VALUES (N'KH03',N'Tieng Nhat')
INSERT [dbo].[khoa](maKhoa,tenKhoa) VALUES (N'KH04',N'Quan Tri Kinh Doanh')
INSERT [dbo].[khoa](maKhoa,tenKhoa) VALUES (N'KH05',N'Co Khi')
end
go

BEGIN
INSERT [dbo].[GiaoVien](maGV,hoTenGV,gioitinh,ngaySinh,sDT,eMail,tenCV,tenLop,passTK,maKhoa)
VALUES (N'GV01',N'Nguyen Van Nam',N'Nam',N'12/03/1998',N'3423423145',N'nam@gmail.com',N'Giáo viên hướng dẫn',N'TT1',N'123',N'KH01')
INSERT [dbo].[GiaoVien](maGV,hoTenGV,gioitinh,ngaySinh,sDT,eMail,tenCV,tenLop,passTK,maKhoa)
VALUES (N'GV02',N'Nguyen Van Sang',N'Nam',N'15/03/1998',N'3423423143',N'vannam@gmail.com',N'Giáo viên hướng dẫn',N'TT1',N'123',N'KH01')
INSERT [dbo].[GiaoVien](maGV,hoTenGV,gioitinh,ngaySinh,sDT,eMail,tenCV,tenLop,passTK,maKhoa)
VALUES (N'GV03',N'Nguyen Van Tung',N'Nam',N'11/03/1996',N'3423423165',N'tung@gmail.com',N'Giáo viên bộ môn',N'TT2',N'123',N'KH02')
INSERT [dbo].[GiaoVien](maGV,hoTenGV,gioitinh,ngaySinh,sDT,eMail,tenCV,tenLop,passTK,maKhoa)
VALUES (N'GV04',N'Tran Dinh Xu',N'Nu',N'06/03/1998',N'3423423177',N'xu@gmail.com',N'Giáo viên bộ môn',N'TT2',N'123',N'KH02')
INSERT [dbo].[GiaoVien](maGV,hoTenGV,gioitinh,ngaySinh,sDT,eMail,tenCV,tenLop,passTK,maKhoa)
VALUES (N'GV05',N'Nguyen Thi Thao',N'Nu',N'16/03/1994',N'3423423188',N'thao@gmail.com',N'Giáo viên hướng dẫn',N'TT3',N'123',N'KH03')
INSERT [dbo].[GiaoVien](maGV,hoTenGV,gioitinh,ngaySinh,sDT,eMail,tenCV,tenLop,passTK,maKhoa)
VALUES (N'GV06',N'Nguyen Thi Van',N'Nu',N'01/03/1998',N'3423423133',N'van@gmail.com',N'Giáo viên bộ môn',N'TT3',N'123',N'KH04')
end
go


INSERT [dbo].[SinhVien](maSV,hoTenSV,gioitinh,ngaySinh,noiSinh,sDT,eMail,tenCV,tenLop,maGV,passTK)
VALUES (N'SV01',N'Pham Dinh Tung',N'Nam',N'01/03/2005',N'TP.HCM',N'123456789',N'tung@gmail.com',N'Sinh Viên',N'TT1',N'GV01',N'123')

INSERT [dbo].[SinhVien](maSV,hoTenSV,gioitinh,ngaySinh,noiSinh,sDT,eMail,tenCV,tenLop,maGV,passTK)
VALUES (N'SV02',N'Pham Van Khoa',N'Nam',N'01/03/2005',N'TP.HCM',N'123456755',N'khoa@gmail.com',N'Sinh Viên',N'TT1',N'GV01',N'123')

INSERT [dbo].[SinhVien](maSV,hoTenSV,gioitinh,ngaySinh,noiSinh,sDT,eMail,tenCV,tenLop,maGV,passTK)
VALUES (N'SV03',N'Nguyen Van Toan',N'Nam',N'12/03/2005',N'TP.HCM',N'123556789',N'toan@gmail.com',N'Sinh Viên',N'TT2',N'GV02',N'123')

INSERT [dbo].[SinhVien](maSV,hoTenSV,gioitinh,ngaySinh,noiSinh,sDT,eMail,tenCV,tenLop,maGV,passTK)
VALUES (N'SV04',N'Nguyen Phong Phu',N'Nam',N'15/04/2005',N'TP.HCM',N'123456789',N'phu@gmail.com',N'Sinh Viên',N'TT2',N'GV02',N'123')

INSERT [dbo].[SinhVien](maSV,hoTenSV,gioitinh,ngaySinh,noiSinh,sDT,eMail,tenCV,tenLop,maGV,passTK)
VALUES (N'SV05',N'Tran Dinh Soan',N'Nam',N'21/03/2005',N'Dong Nai',N'123456559',N'soan@gmail.com',N'Sinh Viên',N'TT3',N'GV03',N'123')

INSERT [dbo].[SinhVien](maSV,hoTenSV,gioitinh,ngaySinh,noiSinh,sDT,eMail,tenCV,tenLop,maGV,passTK)
VALUES (N'SV06',N'Nguyen Thi Tu',N'Nu',N'01/03/2005',N'Dong Nai',N'123456722',N'tu@gmail.com',N'Sinh Viên',N'TT3',N'GV04',N'123')

INSERT [dbo].[SinhVien](maSV,hoTenSV,gioitinh,ngaySinh,noiSinh,sDT,eMail,tenCV,tenLop,maGV,passTK)
VALUES (N'SV07',N'Tran Thi Thao',N'Nu',N'01/03/2005',N'Binh Duong',N'123488789',N'thao@gmail.com',N'Sinh Viên',N'TT3',N'GV04',N'123')

INSERT [dbo].[SinhVien](maSV,hoTenSV,gioitinh,ngaySinh,noiSinh,sDT,eMail,tenCV,tenLop,maGV,passTK)
VALUES (N'SV08',N'Tran Thi My',N'Nam',N'01/03/2006',N'TP.HCM',N'123456789',N'my@gmail.com',N'Sinh Viên',N'TT1',N'GV01',N'123')

INSERT [dbo].[SinhVien](maSV,hoTenSV,gioitinh,ngaySinh,noiSinh,sDT,eMail,tenCV,tenLop,maGV,passTK)
VALUES (N'SV09',N'Nguyen Thu Thao',N'Nu',N'01/03/2005',N'TP.HCM',N'123123789',N'tung@gmail.com',N'Sinh Viên',N'TT1',N'GV01',N'123')

INSERT [dbo].[SinhVien](maSV,hoTenSV,gioitinh,ngaySinh,noiSinh,sDT,eMail,tenCV,tenLop,maGV,passTK)
VALUES (N'SV10',N'Phan Chu Trinh',N'Nu',N'30/03/2005',N'Vung Tau',N'123456129',N'trinh@gmail.com',N'Sinh Viên',N'TT1',N'GV01',N'123')

go
