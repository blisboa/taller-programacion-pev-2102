use ene_aiep
go

create table rol ( idrol varchar(20) primary key, nombre varchar(100))

insert rol select 'administrador','Administrador del sistema'
insert rol select 'analista','Analista de Requerimientos'

select *  from rol 