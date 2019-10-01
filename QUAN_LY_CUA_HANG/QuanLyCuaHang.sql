--DATABASE
create database	QUANLYCUAHANG
go
use QUANLYCUAHANG
go

create table taikhoan
(
TENTK VARCHAR(30),
MATKHAU VARCHAR(30),
IDTAIKHOAN CHAR(20),
CONSTRAINT PK_TENTK PRIMARY KEY(TENTK)
)
-------------------------------------------------------------------
--Procedure table TAIKHOAN
create procedure Load_TaiKhoan
as
begin
 SELECT * FROM taikhoan
end
go

create procedure Insert_TaiKhoan
@TENTK VARCHAR(30),@MATKHAU VARCHAR(30),@IDTAIKHOAN CHAR(20)
as
begin
 INSERT INTO taikhoan(TENTK,MATKHAU,IDTAIKHOAN) VALUES(@TENTK,@MATKHAU,@IDTAIKHOAN)
end
go

insert into taikhoan
values('hoanganh', 'abc', 'a1');