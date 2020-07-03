create database QuanLyDuAn
go
use QuanLyDuAn
go
create table ChiPhi(
	MaCongViecChiTieu nchar(20) primary key,
	CongViecChiTieu nchar(200),
	ThucHien date,
	ChiPhiCongViec int
)
create table Nhom(
	MaNhom nchar(200) primary key,
	TenNhom nchar(200),
	NhomTruong nchar(20)
)
go

create table NhanVien(
	MaNhanVien nchar(20) primary key,
	HoTen nchar(200),
	NgaySinh date,
	SoDienThoai nchar(11),
	DiaChi nchar(200),
	ChucVu nchar(200),
	Luong int,
	Nhom nchar(200),
	MatKhau nchar(20)
)
create table CongViecNhanVien(
	MaCongViecNhanVien nchar(20),
	MaNhanVienPhuTrach nchar(20),
	TenCongViec nchar(200),
	MoTa nchar(200),
	TaiLieu nchar(200),
	LuongCongViec int,
	DuKienHoanThanh date,
	NgayBatDau date,
	TienDo bit not null,
	NgayHoanThanh date,
	primary key (MaCongViecNhanVien, MaNhanVienPhuTrach)
)
create table CongViec(
	MaCongViec nchar(200) primary key,
	TenCongViec nchar(200),
	NoiDungCongViec nchar(200),
	ListNhomPhuTrach nchar(200),
	ChiPhi int,
	DuKienHoanThanh date,
	NgayBatDau date,
	TienDo int,
	NgayHoanThanh date
)
create table DuAn(
	MaDuAn nchar(20) primary key,
	TenDuAn nchar(200),
	MucTieuDuAn nchar(200),
	ChiPhiDuAn int,
	CongViecDuAn nchar(200),
	NhomPhuTrach nchar(200),
	DuKienHoanThanh date,
	NgayBatDau date,
	TienDo int,
	NgayHoanThanh date
)

insert into Nhom values('N01',N'Nhóm nghiên cứu sinh phẩm','NV001')
insert into Nhom values('N02',N'Nhóm hóa dược phẩm','NV002')
insert into Nhom values('N03',N'Nhóm sản xuất dược phẩm','NV003')
insert into Nhom values('N04',N'Nhóm sản xuất sinh phẩm','NV004')
insert into Nhom values('N05',N'Nhóm sản xuất máy móc','NV005')
insert into Nhom values('N06',N'Nhóm đánh giá rủi ro vật lí','NV006')
insert into Nhom values('N07',N'Nhóm đánh giá rủi ro  sinh học','NV007')
insert into Nhom values('N08',N'Nhóm đánh giá chuẩn đầu ra và cấp phép sản xuất','NV008')
insert into Nhom values('N09',N'Nhóm ký hợp đồng và phân phối đơn hàng','NV009')
insert into Nhom values('N10',N'Nhóm ký hợp đồng và phân phối đơn hàng','NV001')
insert into Nhom values('N11',N'Nhóm ký hợp đồng và phân phối đơn hàng','NV002')
insert into Nhom values('N12',N'Nhóm ký hợp đồng và phân phối đơn hàng','NV003')
insert into Nhom values('N13',N'Nhóm ký hợp đồng và phân phối đơn hàng','NV004')
insert into Nhom values('N14',N'Nhóm ký hợp đồng và phân phối đơn hàng','NV005')
insert into Nhom values('N15',N'Nhóm ký hợp đồng và phân phối đơn hàng','NV006')
insert into Nhom values('N16',N'Nhóm ký hợp đồng và phân phối đơn hàng','NV007')

insert into NhanVien values('NV001',N'Nguyễn Văn An','1985-02-21','0944332439',N'35/11, Hữu Nghị, Bình Thọ-Thủ Đức',N'Trưởng nhóm','','N01','123456789')
insert into NhanVien values('NV011',N'Ngô Công Trí','1987-02-28','0944332439',N'35/11, Hữu Nghị, Bình Thọ-Thủ Đức',N'Thành viên','','N01','123456789')
insert into NhanVien values('NV021',N'Huỳnh Minh Nhựt','1990-11-21','0944332439',N'35/11, Hữu Nghị, Bình Thọ-Thủ Đức',N'Thành viên','','N01','123456789')
insert into NhanVien values('NV031',N'Thái Thùy Tâm','1991-12-11','0944332439',N'35/11, Hữu Nghị, Bình Thọ-Thủ Đức',N'Thành viên','','N01','123456789')
insert into NhanVien values('NV041',N'Nguyễn Minh Tâm','1989-05-08','0944332439',N'35/11, Hữu Nghị, Bình Thọ-Thủ Đức',N'Thành viên','','N01','123456789')
insert into NhanVien values('NV051',N'Phan Công Thành','1986-08-24','0944332439',N'35/11, Hữu Nghị, Bình Thọ-Thủ Đức',N'Thành viên','','N01','123456789')
insert into NhanVien values('NV061',N'Lê Thúy Liễu','1988-07-19','0944332439',N'35/11, Hữu Nghị, Bình Thọ-Thủ Đức',N'Thành viên','','N01','123456789')

insert into NhanVien values('NV002',N'Hoàng An Bình','1987-04-01','0941245539',N'35/11,  Hữu Nghị, Bình Thọ-Thủ Đức',N'Trưởng nhóm','','N02','123456789')
insert into NhanVien values('NV012',N'Nguyễn Thành Công','1990-02-23','0945678439',N'35/11,  Hữu Nghị, Bình Thọ-Thủ Đức',N'Thành viên','','N02','123456789')
insert into NhanVien values('NV022',N'Ngô Thùy Dung','1989-05-28','0785634259',N'35/11,  Hữu Nghị, Bình Thọ-Thủ Đức',N'Thành viên','','N02','123456789')
insert into NhanVien values('NV032',N'Lê Duy Khánh','1988-07-11','0944336274',N'35/11,  Hữu Nghị, Bình Thọ-Thủ Đức',N'Thành viên','','N02','123456789')
insert into NhanVien values('NV042',N'Huỳnh Thiên Long','1992-02-01','0916789439',N'35/11,  Hữu Nghị, Bình Thọ-Thủ Đức',N'Thành viên','','N02','123456789')
insert into NhanVien values('NV052',N'Thái Phương Ly','1985-12-21','0949174239',N'35/11,  Hữu Nghị, Bình Thọ-Thủ Đức',N'Thành viên','','N02','123456789')
insert into NhanVien values('NV062',N'Nguyễn Khánh My','1988-11-22','0912345639',N'35/11,  Hữu Nghị, Bình Thọ-Thủ Đức',N'Thành viên','','N02','123456789')
insert into NhanVien values('NV072',N'Hoàng Nhật Nam','1985-03-13','0945426735',N'35/11,  Hữu Nghị, Bình Thọ-Thủ Đức',N'Thành viên','','N02','123456789')

insert into NhanVien values('NV003',N'Nguyễn Thành Công','1990-02-23','0945678439',N'35/11,  Hữu Nghị, Bình Thọ-Thủ Đức',N'Trưởng nhóm','','N03','123456789')
insert into NhanVien values('NV013',N'Ngô Thùy Dung','1989-05-28','0785634259',N'35/11,  Hữu Nghị, Bình Thọ-Thủ Đức',N'Thành viên','','N03','123456789')
insert into NhanVien values('NV023',N'Lê Duy Khánh','1988-07-11','0944336274',N'35/11,  Hữu Nghị, Bình Thọ-Thủ Đức',N'Thành viên','','N03','123456789')
insert into NhanVien values('NV033',N'Huỳnh Thiên Long','1992-02-01','0916789439',N'35/11,  Hữu Nghị, Bình Thọ-Thủ Đức',N'Thành viên','','N03','123456789')
insert into NhanVien values('NV043',N'Thái Phương Ly','1985-12-21','0949174239',N'35/11,  Hữu Nghị, Bình Thọ-Thủ Đức',N'Thành viên','','N03','123456789')
insert into NhanVien values('NV053',N'Nguyễn Khánh My','1988-11-22','0912345639',N'35/11,  Hữu Nghị, Bình Thọ-Thủ Đức',N'Thành viên','','N03','123456789')
insert into NhanVien values('NV063',N'Hoàng Nhật Nam','1985-03-13','0945426735',N'35/11,  Hữu Nghị, Bình Thọ-Thủ Đức',N'Thành viên','','N03','123456789')

insert into NhanVien values('NV004',N'Ngô Thùy Dung','1989-05-28','0785634259',N'35/11,  Hữu Nghị, Bình Thọ-Thủ Đức',N'Trưởng nhóm','','N04','123456789')
insert into NhanVien values('NV014',N'Lê Duy Khánh','1988-07-11','0944336274',N'35/11,  Hữu Nghị, Bình Thọ-Thủ Đức',N'Thành viên','','N04','123456789')
insert into NhanVien values('NV024',N'Huỳnh Thiên Long','1992-02-01','0916789439',N'35/11,  Hữu Nghị, Bình Thọ-Thủ Đức',N'Thành viên','','N04','123456789')
insert into NhanVien values('NV034',N'Thái Phương Ly','1985-12-21','0949174239',N'35/11,  Hữu Nghị, Bình Thọ-Thủ Đức',N'Thành viên','','N04','123456789')
insert into NhanVien values('NV044',N'Nguyễn Khánh My','1988-11-22','0912345639',N'35/11,  Hữu Nghị, Bình Thọ-Thủ Đức',N'Thành viên','','N04','123456789')
insert into NhanVien values('NV054',N'Hoàng Nhật Nam','1985-03-13','0945426735',N'35/11,  Hữu Nghị, Bình Thọ-Thủ Đức',N'Thành viên','','N04','123456789')

insert into NhanVien values('NV005',N'Lê Duy Khánh','1988-07-11','0944336274',N'35/11,  Hữu Nghị, Bình Thọ-Thủ Đức',N'Trưởng nhóm','','N05','123456789')
insert into NhanVien values('NV015',N'Huỳnh Thiên Long','1992-02-01','0916789439',N'35/11,  Hữu Nghị, Bình Thọ-Thủ Đức',N'Thành viên','','N05','123456789')
insert into NhanVien values('NV025',N'Thái Phương Ly','1985-12-21','0949174239',N'35/11,  Hữu Nghị, Bình Thọ-Thủ Đức',N'Thành viên','','N05','123456789')
insert into NhanVien values('NV035',N'Nguyễn Khánh My','1988-11-22','0912345639',N'35/11,  Hữu Nghị, Bình Thọ-Thủ Đức',N'Thành viên','','N05','123456789')
insert into NhanVien values('NV045',N'Hoàng Nhật Nam','1985-03-13','0945426735',N'35/11,  Hữu Nghị, Bình Thọ-Thủ Đức',N'Thành viên','','N05','123456789')

insert into NhanVien values('NV006',N'Huỳnh Thiên Long','1992-02-01','0916789439',N'35/11,  Hữu Nghị, Bình Thọ-Thủ Đức',N'Trưởng nhóm','','N06','123456789')
insert into NhanVien values('NV016',N'Thái Phương Ly','1985-12-21','0949174239',N'35/11,  Hữu Nghị, Bình Thọ-Thủ Đức',N'Thành viên','','N067','123456789')
insert into NhanVien values('NV026',N'Nguyễn Khánh My','1988-11-22','0912345639',N'35/11,  Hữu Nghị, Bình Thọ-Thủ Đức',N'Thành viên','','N07','123456789')
insert into NhanVien values('NV036',N'Hoàng Nhật Nam','1985-03-13','0945426735',N'35/11,  Hữu Nghị, Bình Thọ-Thủ Đức',N'Thành viên','','N07','123456789')

insert into NhanVien values('NV007',N'Thái Phương Ly','1985-12-21','0949174239',N'35/11,  Hữu Nghị, Bình Thọ-Thủ Đức',N'Trưởng nhóm','','N07','123456789')
insert into NhanVien values('NV008',N'Nguyễn Khánh My','1988-11-22','0912345639',N'35/11,  Hữu Nghị, Bình Thọ-Thủ Đức',N'Trưởng nhóm','','N08','123456789')
insert into NhanVien values('NV009',N'Hoàng Nhật Nam','1985-03-13','0945426735',N'35/11,  Hữu Nghị, Bình Thọ-Thủ Đức',N'Trưởng nhóm','','N09','123456789')

insert into CongViecNhanVien values ('CV01.1.1','NV001',N'Nghiên cứu',N'Nghiên cứu nguyên lý hoạt động của virus','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','1000000','2019-12-30','2019-12-08','1','2019-12-30')
insert into CongViecNhanVien values ('CV01.1.1','NV011',N'Nghiên cứu',N'Nghiên cứu nguyên lý hoạt động của virus','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','1000000','2019-12-30','2019-12-08','1','2019-12-30')
insert into CongViecNhanVien values ('CV01.1.1','NV021',N'Nghiên cứu',N'Nghiên cứu nguyên lý hoạt động của virus','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','1000000','2019-12-30','2019-12-08','1','2019-12-30')
insert into CongViecNhanVien values ('CV01.1.2','NV011',N'Nghiên cứu',N'Tìm điểm yếu của virus','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','1500000','2019-12-30','2019-12-08','1','2019-12-30')
insert into CongViecNhanVien values ('CV01.1.2','NV021',N'Nghiên cứu',N'Tìm điểm yếu của virus','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','1500000','2019-12-30','2019-12-08','1','2019-12-30')
insert into CongViecNhanVien values ('CV01.1.3','NV031',N'Nghiên cứu',N'Tìm cách khắc chế tiêu diệt virus','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','1000000','2019-12-30','2019-12-08','1','2019-12-30')
insert into CongViecNhanVien values ('CV01.1.3','NV041',N'Nghiên cứu',N'Tìm cách khắc chế tiêu diệt virus','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','1000000','2019-12-30','2019-12-08','1','2019-12-30')
insert into CongViecNhanVien values ('CV01.1.4','NV051',N'Nghiên cứu',N'Ngăn ngừa tác hại của virus gây ra cho nội tạng','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','2000000','2019-12-30','2019-12-08','1','2019-12-30')
insert into CongViecNhanVien values ('CV01.1.4','NV061',N'Nghiên cứu',N'Ngăn ngừa tác hại của virus gây ra cho nội tạng','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','2000000','2019-12-30','2019-12-08','1','2019-12-30')

insert into CongViecNhanVien values ('CV01.2.1','NV002',N'Nghiên cứu',N'Nghiên cứu nguyên lý hoạt động của virus','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','1000000','2019-12-30','2019-12-08','0','2019-12-30')
insert into CongViecNhanVien values ('CV01.2.1','NV012',N'Nghiên cứu',N'Nghiên cứu nguyên lý hoạt động của virus','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','1000000','2019-12-30','2019-12-08','0','2019-12-30')
insert into CongViecNhanVien values ('CV01.2.1','NV022',N'Nghiên cứu',N'Nghiên cứu nguyên lý hoạt động của virus','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','1000000','2019-12-30','2019-12-08','0','2019-12-30')
insert into CongViecNhanVien values ('CV01.2.2','NV032',N'Nghiên cứu',N'Tìm điểm yếu của virus','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','1500000','2019-12-30','2019-12-08','0','2019-12-30')
insert into CongViecNhanVien values ('CV01.2.2','NV042',N'Nghiên cứu',N'Tìm điểm yếu của virus','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','1500000','2019-12-30','2019-12-08','0','2019-12-30')
insert into CongViecNhanVien values ('CV01.2.3','NV052',N'Nghiên cứu',N'Tìm cách khắc chế tiêu diệt virus','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','1000000','2019-12-30','2019-12-08','0','2019-12-30')
insert into CongViecNhanVien values ('CV01.2.3','NV062',N'Nghiên cứu',N'Tìm cách khắc chế tiêu diệt virus','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','1000000','2019-12-30','2019-12-08','0','2019-12-30')
insert into CongViecNhanVien values ('CV01.2.4','NV012',N'Nghiên cứu',N'Ngăn ngừa tác hại của virus gây ra cho nội tạng','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','2000000','2019-12-30','2019-12-08','0','2019-12-30')
insert into CongViecNhanVien values ('CV01.2.4','NV022',N'Nghiên cứu',N'Ngăn ngừa tác hại của virus gây ra cho nội tạng','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','2000000','2019-12-30','2019-12-08','0','2019-12-30')

insert into CongViecNhanVien values ('CV02.1.1','NV003',N'Nghiên cứu',N'Nghiên cứu nguyên lý hoạt động của virus','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','1000000','2019-12-30','2019-12-08','1','2019-12-30')
insert into CongViecNhanVien values ('CV02.1.1','NV013',N'Nghiên cứu',N'Nghiên cứu nguyên lý hoạt động của virus','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','1000000','2019-12-30','2019-12-08','1','2019-12-30')
insert into CongViecNhanVien values ('CV02.1.1','NV023',N'Nghiên cứu',N'Nghiên cứu nguyên lý hoạt động của virus','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','1000000','2019-12-30','2019-12-08','1','2019-12-30')
insert into CongViecNhanVien values ('CV02.1.2','NV013',N'Nghiên cứu',N'Tìm điểm yếu của virus','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','1500000','2019-12-30','2019-12-08','1','2019-12-30')
insert into CongViecNhanVien values ('CV02.1.2','NV023',N'Nghiên cứu',N'Tìm điểm yếu của virus','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','1500000','2019-12-30','2019-12-08','1','2019-12-30')
insert into CongViecNhanVien values ('CV02.1.3','NV033',N'Nghiên cứu',N'Tìm cách khắc chế tiêu diệt virus','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','1000000','2019-12-30','2019-12-08','1','2019-12-30')
insert into CongViecNhanVien values ('CV02.1.3','NV043',N'Nghiên cứu',N'Tìm cách khắc chế tiêu diệt virus','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','1000000','2019-12-30','2019-12-08','1','2019-12-30')
insert into CongViecNhanVien values ('CV02.1.4','NV053',N'Nghiên cứu',N'Ngăn ngừa tác hại của virus gây ra cho nội tạng','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','2000000','2019-12-30','2019-12-08','1','2019-12-30')
insert into CongViecNhanVien values ('CV02.1.4','NV063',N'Nghiên cứu',N'Ngăn ngừa tác hại của virus gây ra cho nội tạng','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','2000000','2019-12-30','2019-12-08','1','2019-12-30')

insert into CongViecNhanVien values ('CV02.2.1','NV004',N'Nghiên cứu',N'Nghiên cứu nguyên lý hoạt động của virus','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','1000000','2019-12-30','2019-12-08','1','2019-12-30')
insert into CongViecNhanVien values ('CV02.2.1','NV014',N'Nghiên cứu',N'Nghiên cứu nguyên lý hoạt động của virus','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','1000000','2019-12-30','2019-12-08','1','2019-12-30')
insert into CongViecNhanVien values ('CV02.2.1','NV024',N'Nghiên cứu',N'Nghiên cứu nguyên lý hoạt động của virus','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','1000000','2019-12-30','2019-12-08','1','2019-12-30')
insert into CongViecNhanVien values ('CV02.2.2','NV014',N'Nghiên cứu',N'Tìm điểm yếu của virus','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','1500000','2019-12-30','2019-12-08','1','2019-12-30')
insert into CongViecNhanVien values ('CV02.2.2','NV024',N'Nghiên cứu',N'Tìm điểm yếu của virus','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','1500000','2019-12-30','2019-12-08','1','2019-12-30')
insert into CongViecNhanVien values ('CV02.2.3','NV034',N'Nghiên cứu',N'Tìm cách khắc chế tiêu diệt virus','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','1000000','2019-12-30','2019-12-08','1','2019-12-30')
insert into CongViecNhanVien values ('CV02.2.3','NV044',N'Nghiên cứu',N'Tìm cách khắc chế tiêu diệt virus','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','1000000','2019-12-30','2019-12-08','1','2019-12-30')
insert into CongViecNhanVien values ('CV02.2.4','NV054',N'Nghiên cứu',N'Ngăn ngừa tác hại của virus gây ra cho nội tạng','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','2000000','2019-12-30','2019-12-08','1','2019-12-30')

insert into CongViecNhanVien values ('CV02.3.1','NV014',N'Nghiên cứu',N'Nghiên cứu nguyên lý hoạt động của virus','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','1000000','2019-12-30','2019-12-08','0','2019-12-30')
insert into CongViecNhanVien values ('CV02.3.1','NV024',N'Nghiên cứu',N'Nghiên cứu nguyên lý hoạt động của virus','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','1000000','2019-12-30','2019-12-08','0','2019-12-30')
insert into CongViecNhanVien values ('CV02.3.2','NV014',N'Nghiên cứu',N'Tìm điểm yếu của virus','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','1500000','2019-12-30','2019-12-08','0','2019-12-30')
insert into CongViecNhanVien values ('CV02.3.2','NV024',N'Nghiên cứu',N'Tìm điểm yếu của virus','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','1500000','2019-12-30','2019-12-08','0','2019-12-30')
insert into CongViecNhanVien values ('CV02.3.3','NV034',N'Nghiên cứu',N'Tìm cách khắc chế tiêu diệt virus','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','1000000','2019-12-30','2019-12-08','0','2019-12-30')
insert into CongViecNhanVien values ('CV02.3.3','NV044',N'Nghiên cứu',N'Tìm cách khắc chế tiêu diệt virus','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','1000000','2019-12-30','2019-12-08','0','2019-12-30')
insert into CongViecNhanVien values ('CV02.3.4','NV054',N'Nghiên cứu',N'Ngăn ngừa tác hại của virus gây ra cho nội tạng','drive.google.com/drive/folders/1bxJYgSv5hHLvyO6gzqJi7s76Cx9-rzqj','2000000','2019-12-30','2019-12-08','0','2019-12-30')


insert into CongViec values ('CV01.1',N'Nghiên cứu thuốc','CV01.1.1,CV01.1.2,CV01.1.3,CV01.1.4','N01,N02,N03','','2020-01-01','2019-12-08','100','2019-12-30')
insert into CongViec values ('CV01.2',N'Nghiên cứu thuốc','CV01.2.1,CV01.2.2,CV01.2.3,CV01.2.4','N04,N05,N06,N07','','2020-01-01','2019-12-08','100','2019-12-30')
insert into CongViec values ('CV02.1',N'Nghiên cứu vắc xin','CV02.1.1,CV02.1.2,CV02.1.3,CV02.1.4','N08,N09','','2020-01-01','2019-12-08','100','2019-12-30')
insert into CongViec values ('CV02.2',N'Nghiên cứu vắc xin','CV02.2.1,CV02.2.2,CV02.2.3,CV02.2.4','N10,N11,N12,N13','','2020-01-01','2019-12-08','100','2019-12-30')
insert into CongViec values ('CV02.3',N'Nghiên cứu vắc xin','CV02.3.1,CV02.3.2,CV02.3.3,CV02.3.4','N14,N15,N16','','2020-01-01','2019-12-08','100','2019-12-30')


insert into DuAn values ('DA01A',N'Sản xuất thuốc điều trị COVID-19',N'sxtdtcv19','','CV01.1,CV01.2','N01','2019-12-30','2019-12-08','','2019-12-30')
insert into DuAn values ('DA02A',N'Sản xuất vắc xin phòng ngừa COVID-19',N'sxvxpncv19','','CV02.1,CV02.2,CV02.3','N01','2019-12-30','2019-12-08','','2019-12-30')

insert into ChiPhi values ('CV01.1.5',N'Mua vật tư thí nghiệm','2019-12-12','10000000')
insert into ChiPhi values ('CV01.1.6',N'Mua vật tư thí nghiệm','2019-12-12','2000000')
insert into ChiPhi values ('CV01.2.5',N'Mua vật tư thí nghiệm','2019-12-12','10000000')
insert into ChiPhi values ('CV01.2.6',N'Mua vật tư thí nghiệm','2019-12-12','10000000')
insert into ChiPhi values ('CV01.1.7',N'Mua vật tư thí nghiệm','2019-12-12','10000000')
insert into ChiPhi values ('CV02.1.5',N'Mua vật tư thí nghiệm','2019-12-12','10000000')
insert into ChiPhi values ('CV02.1.6',N'Mua vật tư thí nghiệm','2019-12-12','50000000')
insert into ChiPhi values ('CV02.2.5',N'Mua vật tư thí nghiệm','2019-12-12','30000000')
insert into ChiPhi values ('CV02.2.6',N'Mua vật tư thí nghiệm','2019-12-12','10000000')
insert into ChiPhi values ('CV02.3.5',N'Mua vật tư thí nghiệm','2019-12-12','30000000')
insert into ChiPhi values ('CV02.3.6',N'Mua vật tư thí nghiệm','2019-12-12','30000000')
