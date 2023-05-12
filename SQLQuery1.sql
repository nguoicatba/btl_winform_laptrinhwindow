
use master
GO
Drop Database if EXISTS btl
GO

create database btl
GO



GO
use btl
GO
--========================================================================================

GO
DROP TABLE IF EXISTS nguoidung
GO
create table nguoidung (
idnguoidung nvarchar(20) primary key,
taikhoan nvarchar(20),
matkhau nvarchar(20),
quyen int 
)
insert into nguoidung values (N'HS0001',N'Hs0001',N'kiencb1234',3)
insert into nguoidung values (N'HS0002',N'HS0002',N'kiencb1234',3)
insert into nguoidung values (N'HS0003',N'HS0003',N'kiencb1234',3)
insert into nguoidung values (N'HS0004',N'HS0004',N'kiencb1234',3)
insert into nguoidung values (N'HS0005',N'HS0005',N'kiencb1234',3)
insert into nguoidung values (N'HS0006',N'HS0006',N'kiencb1234',3)
insert into nguoidung values (N'HS0007',N'HS0007',N'kiencb1234',3)
insert into nguoidung values (N'GV0005',N'GV0005',N'kiencb1234',2)
insert into nguoidung values (N'NV0005',N'NV0005',N'kiencb1234',1)
insert into nguoidung values (N'QTV0005',N'QTV0005',N'kiencb1234',0)
--========================================================================================
GO
DROP TABLE IF EXISTS khoi
GO
create table khoi (
id_khoi nvarchar(10) primary key not null,
name_khoi nvarchar (15) ,
)

insert into khoi values (N'ID_K1',N'khối 1')
insert into khoi values (N'ID_K2',N'khối 2')
insert into khoi values (N'ID_K3',N'khối 3')
insert into khoi values (N'ID_K4',N'khối 4')
insert into khoi values (N'ID_K5',N'khối 5')
--========================================================================================



GO
DROP TABLE IF EXISTS lophoc
GO
create table lophoc(
id_class nvarchar(10) primary key not null,
name_class nvarchar(4),
soluong_class int,
id_khoi nvarchar(10) foreign key references khoi(id_khoi),
)
insert into lophoc values (N'LH001',N'1A1',40,N'ID_K1')
insert into lophoc values (N'LH002',N'1A2',40,N'ID_K1')
insert into lophoc values (N'LH003',N'1A3',40,N'ID_K1')
insert into lophoc values (N'LH004',N'1A4',40,N'ID_K1')
insert into lophoc values (N'LH005',N'2A1',40,N'ID_K2')
insert into lophoc values (N'LH006',N'2A2',40,N'ID_K2')
insert into lophoc values (N'LH007',N'2A3',40,N'ID_K2')
insert into lophoc values (N'LH008',N'2A4',40,N'ID_K2')
insert into lophoc values (N'LH009',N'3A1',40,N'ID_K3')
insert into lophoc values (N'LH010',N'3A2',40,N'ID_K3')
insert into lophoc values (N'LH011',N'3A3',40,N'ID_K3')
insert into lophoc values (N'LH012',N'3A4',40,N'ID_K3')

--========================================================================================
GO
DROP TABLE IF EXISTS namhoc
GO
create table namhoc (
key_year nvarchar (10) primary key not null,
nambatdau int ,
namketthuc int,
)


--========================================================================================
GO
DROP TABLE IF EXISTS student
GO
create table student(
id_student nvarchar(20) primary key not null,
name_student nvarchar(20),
ngaysinh date,
diachi nvarchar(60),
gender nvarchar(10),
id_class nvarchar(10) foreign key references lophoc(id_class),
anh nvarchar(200),
idnguoidung nvarchar(20) foreign key references nguoidung(idnguoidung)
)
insert into student (id_student,name_student,ngaysinh,diachi,gender,idnguoidung) values (N'HS0001',N'Nguyễn Lê Trung Kiên','2003-01-01',N'chịu',N'Nam',N'HS0001')
insert into student (id_student,name_student,ngaysinh,diachi,gender,idnguoidung) values (N'HS0002',N'Nguyễn Thế Sơn Dương','2003-01-01',N'chịu',N'Nam',N'HS0002')
insert into student (id_student,name_student,ngaysinh,diachi,gender,idnguoidung) values (N'HS0003',N'Đinh Khắc Duy','2003-01-01',N'chịu',N'Nam',N'HS0003')
insert into student (id_student,name_student,ngaysinh,diachi,gender,idnguoidung) values (N'HS0004',N'Nguyễn Trung Sơn','2003-01-01',N'chịu',N'Nam',N'HS0004')
insert into student (id_student,name_student,ngaysinh,diachi,gender,idnguoidung) values (N'HS0005',N'Phan Công Lý','2003-01-01',N'chịu',N'Nam',N'HS0005')
insert into student (id_student,name_student,ngaysinh,diachi,gender,idnguoidung,id_class) values (N'HS0006',N'Phan Công Lý','2003-01-01',N'chịu',N'Nam',N'HS0006',N'LH001')
--========================================================================================
GO
DROP TABLE IF EXISTS hocki
GO
create table hocki(
id_hocki nvarchar(10) primary key not  null,
name_hocki nvarchar(10) ,
heso int ,
)
insert into hocki values (N'HOCKI01',N'học kì 1',1)
insert into hocki values (N'HOCKI02',N'học kì 2',2)
--========================================================================================
GO
DROP TABLE IF EXISTS score_hanhkiem
GO
create table score_hanhkiem(
id_hanhkiem nvarchar(10) primary key not null,
loaihanhkiem  nvarchar(20),
)
insert into score_hanhkiem values (N'HK001',N'Tốt')
insert into score_hanhkiem values (N'HK002',N'Khá')
insert into score_hanhkiem values (N'HK003',N'Trung bình')
insert into score_hanhkiem values (N'HK004',N'Yếu')
--========================================================================================
GO
DROP TABLE IF EXISTS score_hocluc
GO
create table score_hocluc(
id_hocluc nvarchar(10) primary key not null,
loai_hocluc  nvarchar(20),
)
insert into score_hocluc values (N'HL001',N'Giỏi')
insert into score_hocluc values (N'HL002',N'Khá')
insert into score_hocluc values (N'HL003',N'Trung bình')
insert into score_hocluc values (N'HL004',N'Yếu')
--========================================================================================
GO
DROP TABLE IF EXISTS monhoc
GO
create table monhoc(
id_subject nvarchar(10) primary key not null,
name_subject nvarchar (30),
hinhthuc int
)
insert into monhoc values (N'MH001',N'Toán',0)
insert into monhoc values (N'MH002',N'Tiếng Việt',0)
insert into monhoc values (N'MH003',N'Lịch sử và Địa lý',0)
insert into monhoc values (N'MH004',N'Đạo đức',1)
insert into monhoc values (N'MH005',N'Tự nhiên và xã hội',0)
insert into monhoc values (N'MH006',N'Âm nhạc',1)
insert into monhoc values (N'MH007',N'Mỹ thuật',1)
insert into monhoc values (N'MH008',N'Thể dục',1)
--========================================================================================
GO
DROP TABLE IF EXISTS hocsinh_monhoc
GO
create table hocsinh_monhoc(
STT INT IDENTITY PRIMARY KEY,
id_student nvarchar(20) foreign key references student(id_student),
id_hocki nvarchar(10)  foreign key references hocki(id_hocki),
id_subject nvarchar(10) foreign key references monhoc(id_subject),
diem_dgtx nvarchar(4),
diem_dk nvarchar(4),
diem_ck nvarchar(4),
diem_hk_tbm nvarchar(4),
)
--========================================================================================
GO
DROP TABLE IF EXISTS tk_hocki
GO
create table tk_hocki(
id_student nvarchar(20) foreign key references student(id_student),
id_hocki nvarchar(10)  foreign key references hocki(id_hocki),
primary key(id_student,id_hocki),
id_hanhkiem nvarchar(10) foreign key references score_hanhkiem(id_hanhkiem),
id_hocluc nvarchar(10) foreign key references score_hocluc(id_hocluc),
diem_tbhk nvarchar(3)
)

GO
DROP TABLE IF EXISTS tk_canam
GO
create table tk_canam_monhoc(
id_student nvarchar(20) foreign key references student(id_student),
primary key(id_student),
id_hanhkiem nvarchar(10) foreign key references score_hanhkiem(id_hanhkiem),
id_hocluc nvarchar(10) foreign key references score_hocluc(id_hocluc),
id_subject nvarchar(10) foreign key references monhoc(id_subject),
diem_tbhk nvarchar(3),
)
select hinhthuc,diem_hk_tbm from hocsinh_monhoc inner join monhoc on hocsinh_monhoc.id_subject =monhoc.id_subject  where id_student =N'HS0003' and id_hocki =N'HOCKI01' and name_subject =N'Toán'