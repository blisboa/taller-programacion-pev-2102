use ene_aiep
go
create table menu ( idMenu varchar(10) primary key, glosa varchar(100), url varchar(150))

insert menu select 'SR01','Ingresar Requerimiento','http://misitio/sistema-req/ingreso.aspx'
insert menu select 'SR02','Consultar Requerimiento','http://misitio/sistema-req/consulta.aspx'

select *  from menu 