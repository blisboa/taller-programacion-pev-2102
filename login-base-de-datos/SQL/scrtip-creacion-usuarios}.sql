create database sistema_req
go

use sistema_req
go
create table usuario ( idUsuario varchar(30) Primary Key,
                       nombreUsuario varchar(100),
					   clave varchar(32))

select *  from usuario
insert usuario select 'blisboa','Bernardo Lisboa','123456'
insert usuario select 'spizarro','Sebastian Pizarro','abcdef'
