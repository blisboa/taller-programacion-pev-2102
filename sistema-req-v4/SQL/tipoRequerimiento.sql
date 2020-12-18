--create database ene_aiep
--go
use ene_aiep
go
create table tipoRequerimiento ( idTipo int primary key , glosa varchar(50))

insert tipoRequerimiento  select 1,'Base de Datos'
insert tipoRequerimiento  select 2,'Sistemas'
insert tipoRequerimiento  select 3,'Instalación Software'

select *  from tipoRequerimiento 
