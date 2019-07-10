
SP_HELP table01
select * from sysdatabases
use master
drop database test01
go

create database test01
go
/*use this database*/
use test01
create table table01 (
name VARCHAR(10),
description VARCHAR(30)
)

go
ALTER TABLE table01 ALTER COLUMN description VARCHAR(50) NOT NULL;
ALTER TABLE table01 ADD age int NOT NULL;
ALTER TABLE table01 ADD date_of_birth DATETIME ;
select * from table01