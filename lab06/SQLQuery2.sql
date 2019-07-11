

drop database test02

create database test02
drop table table02
create table table02(
id int  NOT NULL IDENTITY, 
name NVARCHAR(50) NOT NULL, 
date_of_birth DATETIME  NULL,
is_happy BIT
)
INSERT INTO table02 VALUES( 'bob', '2019-01-01', 'true')
INSERT INTO table02  VALUES('jim', '2019-01-01', 'false')
INSERT INTO table02 (name, date_of_birth) VALUES('fred', '2019-01-01')

select * from table02
/*new record but no name*/
UPDATE table02 SET is_happy='false' WHERE id =3
SELECT * from table02