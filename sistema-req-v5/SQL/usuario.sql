use ene_aiep
go
create table usuario ( idUsuario varchar(30) primary key, nombre varchar(100), clave varchar(30), idrol varchar(20))

insert usuario  select 'blisboa','bernardo lisboa','123456','administrador'
insert usuario  select 'gmoya','gonzalo moya','123456','administrador'
insert usuario  select 'mferrada','mauricio ferrada','123456','analista'
insert usuario  select 'spizarro','sebastian pizarro','123456','analista'
