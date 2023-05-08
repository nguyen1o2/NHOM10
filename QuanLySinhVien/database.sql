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


create procedure SelectAllSinhVien -- Tạo procedure để lấy toàn bộ sinh viên
as
select 
   masinhvien,
   case 
       when LEN(tendem) > 0 then --nếu độ cài > 0 tức là có tên đệm
	        CONCAT(ho,' ',tendem,'  ',ten) -- thì nối họ + tên đệm + tên bảng các khoảng trống
       else CONCAT(ho,' ',ten) -- ngược lại không có tên đệm -> nối họ với tên bằng khoảng trống
   end as hoten,
   CONVERT(varchar(10),ngaysinh,103) as nsinh, -- định lại ngày sinh theo kiểu dd/mm/yy
   case
       when gioitinh = 1 then 'Nam'
	   else N'Nữ'
   end as gt,
   quequan,
   diachi,
   dienthoai,
   email  
   from tblSinhVien
go;

exec  SelectAllSinhVien
drop procedure SelectAllSinhVien
select * from tblSinhVien

--Tạo stored procedure để thêm mới một sinh viên vào bảng tblSinhVien

create procedure ThemMoiSV
--Khai báo danh sách tham số truyền vào
       @Ho nvarchar(10),
	   @TenDem nvarchar(20),
	   @Ten nvarchar(10),
	   @Ngaysinh date,
	   @Gioitinh tinyint,
	   @Quequan nvarchar(150),
	   @Diachi nvarchar(150),
	   @Dienthoai varchar(30),
	   @Email varchar(150)
	   --kết thúc khai báo
as
begin
--thêm dữ liệu mới
      insert into tblSinhVien
	  (
	     masinhvien,
		 ho,tendem,ten,
		 ngaysinh,gioitinh,
		 quequan,diachi,
		 dienthoai,email
       )values(
	     '19SV' + CAST(next value for sinhvienSeq as varchar(30)),--mã sinh tự động
		 --Giá trị là các tham số được khai báo ở trên
		 @Ho,@TenDem,@Ten,
		 @Ngaysinh,@Gioitinh,
		 @Quequan,@Diachi,
		 @Dienthoai,@Email
		 );--kết thúc thêm mới dữ liệu

		 --Kiểm tra xem đã insert thanh công chưa
		 if @@ROWCOUNT > 0 begin return 1 end --Nếu insert thành công trả về 1
		 else begin return 0 end; --Ngược lại return 0
end

exec ThemMoiSV N'Nguyễn',N'Văn',N'Nguyên','2002-04-15',1,N'Thanh Hóa',N'Hà Nội','0814116368','muradnvn@gmail.com'
select * from tblSinhVien

create procedure updateSV
--Khai báo danh sách tham số truyền vào
       @masinhvien varchar(50),
       @ho nvarchar(10),
	   @tendem nvarchar(20),
	   @ten nvarchar(10),
	   @ngaysinh date,
	   @gioitinh tinyint,
	   @quequan nvarchar(150),
	   @diachi nvarchar(150),
	   @dienthoai varchar(30),
	   @email varchar(150)
	   --kết thúc khai báo
as
begin
     update tblSinhVien
	 set 
	     ho = @ho,
		 tendem = @tendem,
		 ten = @ten,
		 ngaysinh = @ngaysinh,
		 gioitinh =@gioitinh,
		 quequan = @quequan,
		 diachi = @diachi,
		 dienthoai = @dienthoai,
		 email = @email
     where masinhvien = @masinhvien;
	 if @@ROWCOUNT > 0 begin return 1 end
	 else begin return 0 end;
end

select * from tblSinhVien
exec updateSV '19SV1109',N'Nguyễn',N'Văn',N'Nguyên','2002-04-15',1,N'Thanh Hóa',N'Hà Nội','0814116368','muradnvn@gmail.com'

-- tạo procedure để select thông tin chi tiết của 1 sinh viên

create procedure selectSV
    @masinhvien varchar(50)
as
begin
    select
	   ho,tendem,ten,CONVERT(nvarchar(10),ngaysinh,103) as ngsinh,
	   case  
	       when gioitinh = 1 then N'Nam' else N'Nữ'
	   end as gtinh,
	   quequan,diachi,dienthoai,email
	   from tblSinhVien
	   where masinhvien=@masinhvien
end
go;

exec selectSV '19SV1109'


select * from tblGiaoVien

create procedure selectAllGV
       @tukhoa nvarchar(50)
as
begin
     select 
	      magiaovien,
		  case 
       when LEN(tendem) > 0 then --nếu độ cài > 0 tức là có tên đệm
	        CONCAT(ho,' ',tendem,'  ',ten) -- thì nối họ + tên đệm + tên bảng các khoảng trống
       else CONCAT(ho,' ',ten) -- ngược lại không có tên đệm -> nối họ với tên bằng khoảng trống
   end as hoten,
   case
       when gioitinh = 1 then 'Nam'
	   else N'Nữ'
   end as gt,
   dienthoai,
   email,
   diachi
   from tblGiaoVien
   where
        LOWER(concat(ho,' ',tendem,' ',ten)) like '%' + LOWER(trim(@tukhoa))+'%'
		or dienthoai like '%' + LOWER(trim(@tukhoa))+'%'
		or CAST(magiaovien as varchar(30)) like '%' + LOWER(trim(@tukhoa))+'%'
		or lower(email) like '%' + LOWER(trim(@tukhoa))+'%'
		order by ten;
end

exec selectAllGV N'Mai'

create procedure InsertGV
--Khai báo danh sách tham số truyền vào
       @nguoitao varchar(30),
       @ho nvarchar(10),
	   @tendem nvarchar(20),
	   @ten nvarchar(10),
	   @gioitinh tinyint,
	   @ngaysinh date,
	   @email varchar(150),
	   @dienthoai varchar(30),
	   @diachi nvarchar(150)
	   --kết thúc khai báo
as
begin
     insert into tblGiaoVien
	 (
	       nguoitao,
		   ho,tendem,ten,
		   gioitinh,ngaysinh,
		   dienthoai,email,diachi
		   )
		   values(
		   @nguoitao,
		   @ho,@tendem,@ten,
		   @gioitinh,@ngaysinh,
		   @dienthoai,@email,@diachi
		   );
		  
     if @@ROWCOUNT > 0 begin return 1 end
	 else begin return 0 end;
end



create procedure updateGV
--Khai báo danh sách tham số truyền vào
       @nguoicapnhat varchar(30),
       @magiaovien int,
       @ho nvarchar(10),
	   @tendem nvarchar(20),
	   @ten nvarchar(10),
	   @gioitinh tinyint,
	   @ngaysinh date,
	   @dienthoai varchar(30),
	   @email varchar(150),
	   @diachi nvarchar(150)
	   --kết thúc khai báo
as
begin
     update tblGiaoVien
	 set
	    nguoicapnhat = @nguoicapnhat,
		ngaycapnhat = GETDATE(),
		ho = @ho,tendem=@tendem,ten=@ten,
		gioitinh=@gioitinh,ngaysinh=@ngaysinh,
		dienthoai=@dienthoai,email=@email, diachi=@diachi
		where magiaovien=@magiaovien;
end

create procedure selectGV
       @magiaovien int
as
begin
     select
	     ho,
		 tendem,
		 ten,
		 gioitinh,
		 CONVERT(varchar(10),ngaysinh,103) as ngsinh,
		 dienthoai,
		 email,diachi
		 from tblGiaoVien
		 where magiaovien =@magiaovien;
end
