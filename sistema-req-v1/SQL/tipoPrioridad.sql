--create database ene_aiep
--go
use ene_aiep
go
create table tipoPrioridad ( idPrioridad int primary key , glosa varchar(50), plazo int)

insert tipoPrioridad  select 1,'Alta',3
insert tipoPrioridad  select 2,'Media',4
insert tipoPrioridad  select 3,'Baja',5

select *  from tipoPrioridad 
