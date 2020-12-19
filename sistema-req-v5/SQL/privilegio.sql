use ene_aiep
go

create table privilegio ( idrol varchar(20), idMenu varchar(10))

insert privilegio select 'administrador','SR01'
insert privilegio select 'administrador','SR02'
insert privilegio select 'analista','SR02'

select *  from privilegio 