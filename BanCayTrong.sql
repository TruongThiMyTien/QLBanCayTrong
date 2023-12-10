create database BanCayTrong
go


use BanCayTrong
go

create table DanhMuc
(
	madm int primary key identity(1, 1),
	ten nvarchar(100) not null
);
go

create table MatHang
(
	mamh int primary key identity(1, 1),
	ten nvarchar(100) not null,
	giagoc int,
	giaban int,
	soluong int,
	mota nvarchar(500),
	hinhanh varchar(255),
	daxoa int,
	madm int not null foreign key (madm) references danhmuc(madm)
);
go

create table KhachHang
(
	makh int primary key identity(1, 1),
	ten nvarchar(100) not null,
	dienthoai varchar(20) not null,
	email varchar(255),
	matkhau varchar(255),
	daxoa int
);
go

create table DiaChi
(
	madc int primary key identity(1, 1),
	diachi nvarchar(100) not null,
	phuongxa nvarchar(100) not null,
	quanhuyen nvarchar(100) not null,
	tinhthanh nvarchar(100) not null,
	makh int not null foreign key (makh) references khachhang(makh),
	macdinh int,           -- 1: yes  0: no
	daxoa int
);
go


create table NhanVien
(
	manv int primary key identity(1, 1),
	ten nvarchar(100) not null,
	dienthoai varchar(20) not null,
	email varchar(255) not null,	
	matkhau varchar(255) not null,
	quyen int   ---- 0: nhân viên, 1: quản lý
);
go

create table HoaDon
(
	mahd int primary key identity(1, 1),
	ngay datetime,
	tongtien int default 0,
	makh int not null foreign key (makh) references khachhang(makh),
	madc int not null foreign key (madc) references diachi(madc),
	trangthai int -- 0.chưa duyệt 1.đã duyệt 2.hủy 
);
go

create table CTHoaDon
(
	macthd int primary key identity(1, 1),
	mahd int not null foreign key (mahd) references HoaDon(mahd),
	mamh int not null foreign key (mamh) references MatHang(mamh),
	dongia int default 0,
	soluong smallint default 0,
	thanhtien int default 0
);
go

