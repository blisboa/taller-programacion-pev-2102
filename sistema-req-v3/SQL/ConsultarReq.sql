use ene_aiep
go
-- exec ConsultarReq 0,0,'P'
select *  from tipoRequerimiento

alter  procedure ConsultarReq (	@tipoReq int, 
								@prioridad int, 
								@estado char(1))
as
begin
	select	idRequeriminto as 'C�digo',
			descripcion as 'Descripci�n',
			estado as 'Estado'
	from requerimiento
end