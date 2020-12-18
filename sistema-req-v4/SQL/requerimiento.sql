use ene_aiep
go

create table requerimiento (idRequeriminto int primary key, 
							descripcion varchar(300),
							estado char(1),
							idTipo int,
							idPrioridad int,
							fechaIngreso date,
							idUsuario varchar(30))
select *  from requerimiento

select *  from usuario
select *  from tipoPrioridad
select *  from tipoRequerimiento

insert requerimiento select 1,'instalar office','P',3,2,'20201212','gmoya'
insert requerimiento select 2,'instalar antivirus','P',3,1,'20201212','gmoya'
