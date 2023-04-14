create database QLSV
go
use master
drop database QLSV
use QLSV
go

create table tblSinhVien(
      ngaytao datetime default(getdate()) null,
	  nguoitao varchar(30) default('admin') null,
	  ngaycapnhat datetime default(getdate()) null,
	  nguoicapnhat varchar(30) default('admin') null,
	  masinhvien varchar(50) not null primary key,
	  ho nvarchar(10) not null,
	  tendem nvarchar(20) null,
	  ten nvarchar(10) not null,
	  ngaysinh date,
	  gioitinh tinyint,
	  quequan nvarchar(150) null,
	  diachi nvarchar(150) null,
	  dienthoai varchar(30) null,
	  email varchar(150) null
)

create table tblGiaoVien(
      ngaytao datetime default(getdate()) null,
	  nguoitao varchar(30) default('admin') null,
	  ngaycapnhat datetime default(getdate()) null,
	  nguoicapnhat varchar(30) default('admin') null,
	  magiaovien int identity not null primary key,
	  ho nvarchar(10) not null,
	  tendem nvarchar(20) null,
	  ten nvarchar(10) not null,
	  gioitinh tinyint,
	  ngaysinh date,
	  dienthoai varchar(30) null,
	  email varchar(150) null, 
	  diachi nvarchar(150) null
)

create table  tblMonHoc(
     ngaytao datetime default(getdate()) null,
	 nguoitao varchar(30) default('admin') null,
	 ngaycapnhat datetime default(getdate()) null,
	 nguoicapnhat varchar(30) default('admin') null,
	 mamonhoc int identity not null primary key,
	 tenmonhoc nvarchar(50) not null,
	 sotinchi int null
)

create table tblDiem(
     ngaytao datetime default(getdate()) null,
	 nguoitao varchar(30) default('admin') null,
	 ngaycapnhat datetime default(getdate()) null,
	 nguoicapnhat varchar(30) default('admin') null,
	 mamonhoc int not null  foreign key(mamonhoc)  references tblMonHoc(mamonhoc) on update cascade on delete cascade,
	 magiaovien int not null foreign key(magiaovien)  references tblGiaoVien(magiaovien) on update cascade on delete cascade,
	 masinhvien varchar(50) not null foreign key(masinhvien)  references tblSinhVien(masinhvien) on update cascade on delete cascade,
	 lanhoc int not null,
	 diemthilan1 float null,
	 diemthilan2 float null,
	 primary key(mamonhoc,magiaovien,masinhvien,lanhoc)
)

select * from tblDiem
select * from tblGiaoVien
select * from tblSinhVien
select * from tblMonHoc
--mã giáo viên tự động tăng nên không cần cho vào lệnh insert
insert into tblGiaoVien(ho,tendem,ten,gioitinh,ngaysinh,dienthoai,email,diachi)
values(N'Nguyễn', N'Thị Thu' , N'Mai',0,'1987-01-01','0122345689','thumai@gmal.com', N'Địa chỉ của cô thu mai'),
(N'Trần', N'Như' , N'Cát',1,'1987-01-01','0122345688','nhucat@gmal.com', N'Địa chỉ của thầy như cát'),
(N'Bùi', N'Văn' , N'Hiến',1,'1984-01-01','0122345687','buivanhieu@gmal.com', N'Địa chỉ của thầy bùi văn chiến'),
(N'Nguyễn', N'Thị Hải' , N'Yến',0,'1977-12-11','0122345686','nguyenthihaiyen@gmal.com', N'Địa chỉ của cô hải yến'),
(N'Đoàn', N'Thị' , N'Nhi',0,'1987-10-20','0122345685','quynhnhi@gmal.com', N'Địa chỉ của cô nhi'),
(N'Trương', N'Bá' , N'Quan',1,'1968-11-25','0122345684','baquantruong@gmal.com', N'Địa chỉ của thầy quan')


insert into tblMonHoc(tenmonhoc,sotinchi)
values(N'Thiết kế giao diện',2),
(N'Quản lí dự án phần mềm',4),
(N'Công cụ và phát triển phần mềm',4),
(N'Phát triển phần mềm mã nguồn mở',3),
(N'Thiết kế hệ thống mạng',2),
(N'Chuyên đề .NET va XML',4),
(N'Phân tích thiết cơ sở dữ liệu',2),
(N'Lập trình winform C# bằng mô hình 3 lớp',2)


create sequence sinhvienSeq
       start with 1100 -- bắt đầu từ 1100
	   increment by 1; -- mỗi lần tăng lên một đơn vị

	   select next value for sinhvienSeq

insert into tblSinhVien(masinhvien,ho,tendem,ten,ngaysinh,gioitinh)
values('19SV' + CAST(next value for sinhvienSeq as varchar(30)),N'Trần',N'Trọng',N'Quang','2000-01-12',1),
('19SV' + CAST(next value for sinhvienSeq as varchar(30)),N'Dương',N'',N'Quá','2000-01-11',1),
('19SV' + CAST(next value for sinhvienSeq as varchar(30)),N'Tiểu',N'Long',N'Nữ','2000-01-31',0),
('19SV' + CAST(next value for sinhvienSeq as varchar(30)),N'Đoàn',N'',N'Dự','2000-11-12',1),
('19SV' + CAST(next value for sinhvienSeq as varchar(30)),N'Hư',N'',N'Trúc','2000-01-12',1),
('19SV' + CAST(next value for sinhvienSeq as varchar(30)),N'Bắc',N'Kiều',N'Phong','2001-10-12',1),
('19SV' + CAST(next value for sinhvienSeq as varchar(30)),N'Nam',N'Mộ',N'Dung','2002-01-12',1),
('19SV' + CAST(next value for sinhvienSeq as varchar(30)),N'Vương',N'Ngữ',N'Yên','2000-06-12',0)


create table TaiKhoan(
       tentaikhoan varchar(50) not null primary key,
	   matkhau varchar(50)
)
select * from TaiKhoan
insert into TaiKhoan values ('admin','admin')